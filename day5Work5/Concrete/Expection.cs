using System;
using System.Runtime.Serialization;

namespace day5Work5.Concrete
{
    [Serializable]
    internal class Expection : Exception
    {
        public Expection()
        {
        }

        public Expection(string message) : base(message)
        {
        }

        public Expection(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Expection(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}