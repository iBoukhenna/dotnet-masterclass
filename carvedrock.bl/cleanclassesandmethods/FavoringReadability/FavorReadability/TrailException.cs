using System.Runtime.Serialization;

namespace carvedrock.bl.CleanClassesAndMethods.FavoringReadability.FavorReadability
{
    [Serializable]
    internal class TrailException : Exception
    {
        public TrailException()
        {
        }

        public TrailException(string? message) : base(message)
        {
        }

        public TrailException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TrailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}