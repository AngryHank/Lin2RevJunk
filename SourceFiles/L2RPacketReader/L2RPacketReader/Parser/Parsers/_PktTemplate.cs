using System;
using System.IO;
using System.Text;

namespace L2RPacketReader.Parser.Parsers
{
    class PktTemplate
    {
        public static void Packet(byte[] packetData, ushort packetLength)
        {
            using (StreamWriter fileStream = new StreamWriter(@"Data\PktTemplate.txt", true))
            {

                //how to call
                // PktTemplate.Packet(packetData, packetLength);


                // Header for top line only
                if (fileStream.BaseStream.Length < 1)
                    fileStream.WriteLine("header stuff");


                    // Read until end of stream
                    for (int i = 0; i < (packetLength); i++)
                    {


                    }
                                                                                                            for (int i = 0; i < (packetLength); i++){
                    //Number of items
                    UInt16 ItemsNumber = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    for (int j = 0; j < ItemsNumber; j++)
                    {

                    }

                    // Numbers
                    byte byte_ = packetData[i];
                    i++;
                    UInt16 int16_ = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    UInt32 int32_ = BitConverter.ToUInt32(packetData, i);
                    i += 4;
                    UInt64 int64_ = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    Single float_ = BitConverter.ToSingle(packetData, i);
                    i += 4;
                    Double double_ = BitConverter.ToDouble(packetData, i);
                    i += 8;

                    //Time
                    UInt64 tTime = BitConverter.ToUInt64(packetData, i);
                    i += 8;
                    tTime -= 18000; // Convert to est
                    System.DateTime dTime = new System.DateTime(1970, 1, 1).AddSeconds(tTime);

                    //Text
                    UInt16 Length = BitConverter.ToUInt16(packetData, i);
                    i += 2;
                    string Text_ = Encoding.UTF8.GetString(packetData, i, Length);
                    i += Length;
                }
            }
        }
    }
}