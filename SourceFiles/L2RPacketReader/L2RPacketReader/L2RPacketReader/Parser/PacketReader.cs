using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2RPacketReader
{
    class PacketReader
    {
        public PacketReader(byte[] bytes)
            : this(bytes, 0)
        {
        }

        private PacketReader(byte[] bytes, int index)
        {
            _bytes = bytes;
            _index = index;
        }

        public UInt16 ReadUInt16()
        {
            UInt16 value = BitConverter.ToUInt16(_bytes, _index);
            _index += 2;
            return value;
        }

        public UInt32 ReadUInt32()
        {
            UInt32 value = BitConverter.ToUInt32(_bytes, _index);
            _index += 4;
            return value;
        }

        public UInt64 ReadUInt64()
        {
            UInt64 value = BitConverter.ToUInt64(_bytes, _index);
            _index += 8;
            return value;
        }

        public Int16 ReadInt16()
        {
            Int16 value = BitConverter.ToInt16(_bytes, _index);
            _index += 2;
            return value;
        }

        public Int32 ReadInt32()
        {
            Int32 value = BitConverter.ToInt32(_bytes, _index);
            _index += 4;
            return value;
        }

        public Int64 ReadInt64()
        {
            Int64 value = BitConverter.ToInt64(_bytes, _index);
            _index += 8;
            return value;
        }

        public byte ReadByte()
        {
            byte value = _bytes[_index];
            _index += 1;
            return value;
        }
        public string ReadString()
        {
            int length = ReadUInt16();
            if (length > 0)
            {
                string value = Encoding.UTF8.GetString(_bytes, _index, length);
                _index += length;
                return value;
            }
            else
            {
                return string.Empty;
            }
        }

        public Single ReadSingle()
        {
            Single value = BitConverter.ToSingle(_bytes, _index);
            _index += 4;
            return value;
        }

        // TODO: Consider custom reader extensions for different types instead of embedding interpretation here.
        public DateTime ReadDate()
        {
            Int64 seconds = ReadInt64();
            if (seconds > 0)
            {
                return new DateTime(1970, 1, 1).AddSeconds(seconds - 18000 /* TODO: This a time zone adjustment? Check it. */);
            }
            else
            {
                return DateTime.MaxValue;
            }
        }

        public void Skip(int count)
        {
            _index += count;
        }

        public int Remaining
        {
            get
            {
                return _bytes.Length - _index;
            }
        }

        public byte[] ReadBytes(int length)
        {
            byte[] value = new byte[length];
            Array.Copy(_bytes, _index, value, 0, length);
            _index += length;
            return value;
        }

        public PacketReader Clone()
        {
            return new PacketReader(_bytes, _index);
        }

        private byte[] _bytes;
        private int _index;
    }
}
