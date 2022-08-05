//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Geometry
{
    public class MWrenchStamped : Message
    {
        public const string RosMessageName = "geometry_msgs/WrenchStamped";

        //  A wrench with reference coordinate frame and timestamp
        public MHeader header;
        public MWrench wrench;

        public MWrenchStamped()
        {
            this.header = new MHeader();
            this.wrench = new MWrench();
        }

        public MWrenchStamped(MHeader header, MWrench wrench)
        {
            this.header = header;
            this.wrench = wrench;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.AddRange(wrench.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            offset = this.wrench.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "MWrenchStamped: " +
            "\nheader: " + header.ToString() +
            "\nwrench: " + wrench.ToString();
        }
    }
}
