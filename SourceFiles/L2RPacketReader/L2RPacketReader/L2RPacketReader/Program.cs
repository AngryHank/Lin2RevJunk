using System;
using System.IO;
using SharpPcap;

namespace L2RPacketReader
{
    public class Globals { public static int lootIndex;}

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

            // If the buffer contains any complete packets, process them
            while (_incomingBuffer.Count >= 2)
            {
                ushort packetLength = BitConverter.ToUInt16(_incomingBuffer.GetRange(0, 2).ToArray(), 0);
                if (_incomingBuffer.Count >= packetLength)
                {
                    byte spacer = _incomingBuffer[2]; // skip 1 byte

                    byte[] packetData = _incomingBuffer.GetRange(3, packetLength - 3).ToArray();
                    _incomingBuffer.RemoveRange(0, packetLength);

                    DecryptPacket(packetData);
                    ParsePacket(new PacketReader(packetData));
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
                packet[i] = (byte)(packet[i] ^ EncryptionKey[i % EncryptionKey.Length]);
            }
        }

        private static void ParsePacket(PacketReader packet)
        {
            ushort packetId = (ushort)(packet.ReadUInt16() - 1);

            // Change the following for different Servers. INT/JAP/KOR/SEA
            Parser.HandlerINT.TypePacket(packet, packetId);

        }

        private static int Initialization(string[] args)
        {
            int delData = 0;


            // Sets optional values based on what arguement is used.
            for (int i = 0; i < args.Length; i++)
            {
                string value = args[i];
                Console.WriteLine(value.Substring(0, 1));
                if (value.Substring(0, 1) != "-")
                {
                    value = "h";

                }
                else
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
            if (!Directory.Exists(@"Output\"))
                Directory.CreateDirectory(@"Output\");

            // Deletes old record files if it exists.
            if (delData == 1)
            {
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


            if (defaultDevice < 0)
            {
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
            Environment.Exit(0);
        }


    }
}