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

        public byte[] ToBytes()
        {
            byte[] value = new byte[_bytes.Length - _index];
            Array.Copy(_bytes, _index, value, 0, value.Length);
            _index += value.Length;
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
