namespace Google.Protobuf
{
    /// <summary>
    /// Interface for a Protocol Buffers message to clear.
    /// </summary>
    public interface IMessageCustom
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
    public interface IMessageCustom<T> : IMessageCustom where T : IMessageCustom<T>
    {
    }
}
