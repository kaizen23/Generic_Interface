﻿using System;
//using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public interface IBuffer<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();

    }

    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();
        public virtual bool IsEmpty
        {
            get
            {
               return _queue.Count == 0;
            }
        }

        public virtual T Read()
        {
            return _queue.Dequeue();
        }

        public virtual void Write(T value)
        {
            _queue.Enqueue(value);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }
    }
    public class CircularBuffer<T> : Buffer<T>
    {
        int _capacity;
        public CircularBuffer(int capacity = 10)
        {
            _capacity = _capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }

        public bool IsFull { get { return _queue.Count == _capacity; } }
    }
}

