using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Protobuf
{
    /// <summary>
    /// A simple object pool.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessagePool<T> where T : IMessageCustom, new()
    {
        private Stack<T> _pooledObjects;

        /// <summary>
        /// Constructor
        /// </summary>
        public MessagePool()
        {
            _pooledObjects = new Stack<T>();
        }

        /// <summary>
        /// Pop
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (_pooledObjects.Count > 0)
                return _pooledObjects.Pop();

            var obj = new T();
            return obj;
        }

        /// <summary>
        /// Push
        /// </summary>
        /// <param name="obj"></param>
        public void Push(T obj)
        {
            obj.Clear();
            _pooledObjects.Push(obj);
        }

        private static MessagePool<T> _pool = new MessagePool<T>();

        public static MessagePool<T> GetPool()
        {
            return _pool;
        }
    }
}
