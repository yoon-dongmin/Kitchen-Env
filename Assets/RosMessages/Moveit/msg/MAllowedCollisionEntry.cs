//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    public class MAllowedCollisionEntry : Message
    {
        public const string RosMessageName = "moveit_msgs/AllowedCollisionEntry";

        //  whether or not collision checking is enabled
        public bool[] enabled;

        public MAllowedCollisionEntry()
        {
            this.enabled = new bool[0];
        }

        public MAllowedCollisionEntry(bool[] enabled)
        {
            this.enabled = enabled;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            
            listOfSerializations.Add(BitConverter.GetBytes(enabled.Length));
            foreach(var entry in enabled)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            
            var enabledArrayLength = DeserializeLength(data, offset);
            offset += 4;
            this.enabled= new bool[enabledArrayLength];
            for(var i = 0; i < enabledArrayLength; i++)
            {
                this.enabled[i] = BitConverter.ToBoolean(data, offset);
                offset += 1;
            }

            return offset;
        }

        public override string ToString()
        {
            return "MAllowedCollisionEntry: " +
            "\nenabled: " + System.String.Join(", ", enabled.ToList());
        }
    }
}