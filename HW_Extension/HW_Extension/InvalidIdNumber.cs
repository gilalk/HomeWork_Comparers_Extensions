using System;
using System.Runtime.Serialization;

namespace HW_Extension
{
    [Serializable]
    internal class InvalidIdNumber : Exception
    {
        public InvalidIdNumber()
        {
        }

        public InvalidIdNumber(string message) : base(message)
        {
        }

        public InvalidIdNumber(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidIdNumber(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}