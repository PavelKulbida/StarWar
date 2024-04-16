using System.Runtime.Serialization;

namespace ServerLogic
{
    [Serializable]
    public class GameException : Exception
    {
        public GameException()
        {
        }

        public GameException(string? message) : base(message)
        {
        }

        public GameException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        [Obsolete("Deprecated")]
        protected GameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}