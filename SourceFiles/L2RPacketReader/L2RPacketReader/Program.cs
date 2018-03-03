using System;
using System.IO;
using SharpPcap;

namespace L2RPacketReader
{
    public class RecordPackets
    {

        // A few variable used throughout the program
        private static byte[] EncryptionKey = { 0xA7, 0x84, 0x20, 0xD0, 0xC9, 0x78, 0xB3, 0x9A };
        private static string filter = "port 12000 and len > 60";
        private static int readTimeoutMilliseconds = 1000;
        private static int defaultDevice = -1;


        /// <summary>
        /// Main Program, calls all the individual parts.
        /// </summary>
        public static void Main(string[] args)
        {
            /* Retrieve the device list  part of initialization*/
            var devices = CaptureDeviceList.Instance;
            // reads args and sets up options.
            var device = devices[Initialization(args)];

            //Register our handler function to the 'packet arrival' event
            device.OnPacketArrival +=
                new PacketArrivalEventHandler(PacketCapturer);

            // Open the device for capturing
            device.Open(DeviceMode.Promiscuous, readTimeoutMilliseconds);

            //filter to capture only packets from L2R that have data
            //string filter = "src port 12000 and len > 60";
            device.Filter = filter;


            Console.WriteLine
                ("\n-- The following filter will be applied: \"{0}\"",
                filter);
            Console.WriteLine
                ("-- Listening on {0} {1}. \n\n Hit 'Enter' to stop...\n\n",
                              device.Name, device.Description);

            // Start the capturing process
            device.StartCapture();

            // Wait for 'Enter' from the user.
            Console.ReadLine();

            // Stop the capturing process
            device.StopCapture();
            Console.WriteLine("-- Capture stopped.");

            // Print out the device statistics
            Console.WriteLine(device.Statistics.ToString());

            // Close the pcap device
            device.Close();

            ExitProgram();
        }

        /// <summary>
        /// Prints the time, length, src ip, src port, dst ip and dst port
        /// for each packet recieved then writes payload data to a file.
        /// </summary>
        private static void PacketCapturer(object sender, CaptureEventArgs e)
        {
            var time = e.Packet.Timeval.Date;
            var len = e.Packet.Data.Length;

            var packet = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);

            var tcpPacket = (PacketDotNet.TcpPacket)packet.Extract(typeof(PacketDotNet.TcpPacket));
            if (tcpPacket != null)
            {
                var ipPacket = (PacketDotNet.IpPacket)tcpPacket.ParentPacket;
                System.Net.IPAddress srcIp = ipPacket.SourceAddress;
                System.Net.IPAddress dstIp = ipPacket.DestinationAddress;
                int srcPort = tcpPacket.SourcePort;
                int dstPort = tcpPacket.DestinationPort;
                byte[] payloadData = tcpPacket.PayloadData;

                Console.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                time.Hour, time.Minute, time.Second, time.Millisecond, len,
                srcIp, srcPort, dstIp, dstPort);


                // Decrypt and process incoming packets
                if (srcPort == 12000)
                {
                    AppendIncomingData(payloadData);
                }
            }
        }

        private static System.Collections.Generic.List<byte> _incomingBuffer = new System.Collections.Generic.List<byte>();

        private static void AppendIncomingData(byte[] payloadData)
        {
            _incomingBuffer.AddRange(payloadData);
            while (_incomingBuffer.Count >= 2)
            {
                int packetLength = _incomingBuffer[1] * 256 + _incomingBuffer[0];
                if (_incomingBuffer.Count >= packetLength)
                {
                    byte spacer = _incomingBuffer[2];

                    byte[] packet = new byte[packetLength - 3];
                    for (int i=0; i<packet.Length; i++)
                    {
                        packet[i] = _incomingBuffer[i + 3];
                    }

                    _incomingBuffer.RemoveRange(0, packetLength);

                    DecryptPacket(packet);
                    ParsePacket(packet);
                }
                else
                {
                    break;
                }
            }            
        }

        private static void DecryptPacket(byte[] packet)
        {
            for (int i = 0; i < packet.Length; i++)
            {
                byte val = packet[i];
                byte key = EncryptionKey[i % EncryptionKey.Length];
                val ^= key;
                packet[i] = val;
            }
        }

        private static void ParsePacket(byte[] packet)
        {
            ushort packetID = (ushort)(packet[1] * 256 + packet[0] - 1);

            byte[] packetData = new byte[packet.Length - 2];
            for (int i=0; i<packetData.Length; i++)
            {
                packetData[i] = packet[i + 2];
            }

            Parser.Handler.Parse(packetData, (ushort)packetData.Length, packetID, 0);
        }

        private static int Initialization(string[] args)
        {
            
            int delCaptures = 1;
            int delLogs = 1;
            int delData = 1;


            // Sets optional values based on what arguement is used.
            for (int i = 0; i < args.Length; i++)
            {
                string value = args[i];
                Console.WriteLine(value.Substring(0, 1));
                if (value.Substring(0,1)!= "-")
                {
                    value = "h";

                } else
                {
                    value = value.Substring(1, 1).ToLower();
                }
                switch (value)
                {
                    case "f":
                        i++;
                        filter = args[i];
                        break;
                    case "t":
                        i++;
                        readTimeoutMilliseconds = Convert.ToInt32(args[i]);
                        break;
                    case "i":
                        i++;
                        defaultDevice = Convert.ToInt32(args[i]);
                        break;
                    case "d":
                        delData = 0;
                        break;
                    case "l":
                        delLogs = 0;
                        break;
                    case "c":
                        delCaptures = 0;
                        break;
                    case "h":
                        Help();
                        break;
                    default:
                        Console.WriteLine("Incorrect arguement used when lauching program. /n/n");
                        Help();
                        break;
                }
            }


            // Creates folders if they do not exist yet.
            if (!Directory.Exists(@"Captures\"))
                Directory.CreateDirectory(@"Captures\");
            if (!Directory.Exists(@"Logs\"))
                Directory.CreateDirectory(@"Logs\");
            if (!Directory.Exists(@"Data\"))
                Directory.CreateDirectory(@"Data\");
            if (!Directory.Exists(@"Output\"))
                Directory.CreateDirectory(@"Output\");

            // Deletes old record files if it exists.
            if (delLogs == 1)
                foreach (var item in Directory.GetFiles(@"Logs\", "*log.txt")) File.Delete(item);
            if (delData == 1) { 
                foreach (var item in Directory.GetFiles(@"Data\", "*.csv")) File.Delete(item);
                foreach (var item in Directory.GetFiles(@"Output\", "*.csv")) File.Delete(item);
                foreach (var item in Directory.GetFiles(@"Output\", "*.txt")) File.Delete(item);
            } 
            /* Retrieve the device list */
            var devices = CaptureDeviceList.Instance;
            
           // Returns error if no devices found.
           // If only one device found uses that device.
            if (devices.Count < 1)
            {
                Console.WriteLine("No device found on this machine");
                // Exits the program.
                ExitProgram();
            }
            else if (devices.Count == 1)
            {
                defaultDevice = 0;
            }


            if (defaultDevice < 0) { 
                defaultDevice = 0;
                // Lists each of the devices that can be captured
                // and then has you select the device you want to use.
                Console.WriteLine("The following devices are available on this machine:");
                Console.WriteLine("----------------------------------------------------\n");
                foreach (var dev in devices)
                {
                    Console.WriteLine("{0}) {1} {2}", defaultDevice, dev.Name, dev.Description);
                    defaultDevice++;
                }
                Console.Write("\n-- Please choose a device to capture: ");
                defaultDevice = int.Parse(Console.ReadLine());
            }
            return defaultDevice;
        }

        private static void Help()
        {
            Console.WriteLine("\nHelp\n");
            Console.WriteLine("Correct usage: L2RPacketReader.exe -(option) (value)");
            Console.WriteLine("\nStandalone Options\n");
            Console.WriteLine("-h: Displays this document.");
            Console.WriteLine("-c: Saves Capture files between executions.");
            Console.WriteLine("    Decrypted Capture files will still be deleted.");
            Console.WriteLine("-l: Saves Log files between executions.");
            Console.WriteLine("-d: Saves Data files between executions.");
            Console.WriteLine("\nOptions That Require Values\n");
            Console.WriteLine("-i #: Sets which device to listen for packets to capture.");
            Console.WriteLine("-f \"filter\": Sets a custom filter for the packets using winPCap's filtering.");
            Console.WriteLine("               default filter value is \"port 12000 and len > 60\"");
            Console.WriteLine("-t #: Sets a custom timeout value. Default value is 1000.\n\n");
            ExitProgram();
        }

        private static void ExitProgram()
        {
            Console.WriteLine("Press enter to exit the application");
            string CurDir = System.IO.Directory.GetCurrentDirectory();
            CurDir += @"\Data\";
//            Console.WriteLine(CurDir);
//            Console.ReadLine();
            Environment.Exit(0);
        }


    }
}
