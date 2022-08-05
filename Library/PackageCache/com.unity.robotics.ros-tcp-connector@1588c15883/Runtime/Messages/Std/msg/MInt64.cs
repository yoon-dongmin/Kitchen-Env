//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Std
{
    public class MInt64 : Message
    {
        public const string RosMessageName = "std_msgs/Int64";

        public long data;

        public MInt64()
        {
            this.data = 0;
        }

        public MInt64(long data)
        {
            this.data = data;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.Add(BitConverter.GetBytes(this.data));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            this.data = BitConverter.ToInt64(data, offset);
            offset += 8;

            return offset;
        }

        public override string ToString()
        {
            return "MInt64: " +
            "\ndata: " + data.ToString();
        }
    }
}
