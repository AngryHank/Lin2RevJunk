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

            /*test stuff
            DateTime dateTime = DateTime.Now;
            if ( dateTime.Year > 2018 || dateTime.DayOfYear > 42)
            {
                Console.WriteLine("Past Automatic Shutdown Date.");
                Console.ReadLine();
                ExitProgram();
            }
                
            */


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

            // Decrypts the packets
            Console.WriteLine("-- Decrypting Received Packets.");
            PacketReceivedDecrypter();
            Console.WriteLine("-- Analyzing Received Packets.");
            PacketRecievedAnalyzer();
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


                // Writes payloads that are received to first file and sent to the second file.
                if (srcPort == 12000)
                {
                    using (StreamWriter fileStream = new StreamWriter(@"Logs\ReceivedCaptureLog.txt", true))
                    {

                        fileStream.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                        time.Hour, time.Minute, time.Second, time.Millisecond, len,
                        srcIp, srcPort, dstIp, dstPort);

                    }
                    using (FileStream fileStream = new FileStream(@"Captures\ReceivedPackets.dat", FileMode.Append, FileAccess.Write, FileShare.Write))
                    {
                        for (int i = 0; i < payloadData.Length; i++)
                        {
                            fileStream.WriteByte(payloadData[i]);
                        }
                    }
                }
                else if (dstPort == 12000)
                {
                    using (StreamWriter fileStream = new StreamWriter(@"Logs\SentCaptureLog.txt", true))
                    {

                        fileStream.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                        time.Hour, time.Minute, time.Second, time.Millisecond, len,
                        srcIp, srcPort, dstIp, dstPort);

                    }
                    using (FileStream fileStream = new FileStream(@"Captures\SentPackets.dat", FileMode.Append, FileAccess.Write, FileShare.Write))
                    {
                        for (int i = 0; i < payloadData.Length; i++)
                        {
                            fileStream.WriteByte(payloadData[i]);
                        }
                    }
                }

                using (StreamWriter fileStream = new StreamWriter(@"Logs\CaptureLog.txt", true))
                {

                    fileStream.WriteLine("{0}:{1}:{2}.{3}\tLen={4}\t{5}:{6} -> {7}:{8}",
                    time.Hour, time.Minute, time.Second, time.Millisecond, len,
                    srcIp, srcPort, dstIp, dstPort);

                }
                using (FileStream fileStream = new FileStream(@"Captures\Packets.dat", FileMode.Append, FileAccess.Write, FileShare.Write))
                {
                    for (int i = 0; i < payloadData.Length; i++)
                    {
                        fileStream.WriteByte(payloadData[i]);
                    }
                }
            }
        }


        /// <summary>
        /// Decrypts every packet that was Received.
        /// </summary>
        private static void PacketReceivedDecrypter()
        {
            using (FileStream stream = File.OpenRead(@"Captures\ReceivedPackets.dat"))
            using (FileStream writeStream = File.OpenWrite(@"Captures\DecryptedReceivedPackets.dat"))
            {
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(writeStream);
                
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    short packetLength = reader.ReadInt16();
                    writer.Write(packetLength);
                    writer.Write(reader.ReadByte());

                    for (int i = 0; i < (packetLength - 3); i++)
                    {
                        byte EncryptionKeyByte = EncryptionKey[i % EncryptionKey.Length];
                        byte PacketByte = (reader.ReadByte());
                        PacketByte ^= EncryptionKeyByte;
                        writer.Write(PacketByte);
                    }
                }
            }
        }
        
        /// <summary>
        /// Analyzes every packet that was Received.
        /// </summary>
        private static void PacketRecievedAnalyzer()
        {
            using (FileStream stream = File.OpenRead(@"Captures\DecryptedReceivedPackets.dat"))
            {
                BinaryReader reader = new BinaryReader(stream);
                
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    long CurPos = reader.BaseStream.Position;
                    // Reads Packet Length and adjusts for data stripped below
                    ushort packetLength = reader.ReadUInt16();
                    reader.ReadByte(); // Spacer
                    packetLength -= 5;
                    // Server starts packetID at 1 while client starts at 0
                    // adjusts for the difference
                    ushort packetID = reader.ReadUInt16();
                    packetID -= 1;
                    byte[] packetData = reader.ReadBytes(packetLength);

                    using (StreamWriter fileStreamR = new StreamWriter(@"Logs\ReceivedParserLog.txt", true))
                    {

                        fileStreamR.WriteLine(Parser.Handler.Parse(packetData, packetLength, packetID, CurPos));

                    }

                }
            }

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
                    case "a":
                        PacketRecievedAnalyzer();
                        ExitProgram();
                        break;
                    case "z":
                        // Decrypts the packets
                        Console.WriteLine("-- Decrypting Received Packets.");
                        PacketReceivedDecrypter();
                        Console.WriteLine("-- Analyzing Received Packets.");
                        PacketRecievedAnalyzer();
                        ExitProgram();
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
            if (delCaptures == 1)
            {
                foreach (var item in Directory.GetFiles(@"Captures\", "*.dat")) File.Delete(item);
            }
            else
            {
                foreach (var item in Directory.GetFiles(@"Captures\", "*Decrypted*.dat")) File.Delete(item);
            }
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
            Console.WriteLine("-a: Reanalyzes the packets previously captured.");
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
