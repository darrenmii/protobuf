namespace Google.Protobuf
{
    /// <summary>
    /// Interface for a Protocol Buffers message to clear.
    /// </summary>
    public interface IMessageClear
    {
        /// <summary>
        /// Clear function.
        /// </summary>
        void Clear();
    }

    /// <summary>
    /// Generic interface for a Protocol Buffers message,
    /// where the type parameter is expected to be the same type as
    /// the implementation class.
    /// </summary>
    /// <typeparam name="T">The message type.</typeparam>
    public interface IMessageClear<T> : IMessageClear where T : IMessageClear<T>
    {
        /// <summary>
        /// Clear function.
        /// </summary>
        //void Clear();
    }
}
