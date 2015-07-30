using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomQueue.Task3.Library
{
    public class CustomQueue<T>
    {
        private const int defaultSize = 4;
        private T[] items;
        private int count;

        public int Count { get { return count; }}

        public CustomQueue() : this(defaultSize) { }
        public CustomQueue(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity");
            items = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (items == null)
                throw new ArgumentNullException("item");
            
            if (count == items.Length)
            {
                int capacity = items.Length + defaultSize;
                Array.Resize<T>(ref items, capacity);
            }
            count++;
            items[count-1] = item;       
        }

        public T Dequeue()
        {
            T dequeued = items[0];
            int newCapacity = items.Length-1;
            T[] newItems = new T[newCapacity];
            Array.Copy(items, 1, newItems, 0, newCapacity);
            items = newItems;
            count--;
            return dequeued;     
        }

        public T Peek()
        {
            return items[0];
        }

        public Enumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        public sealed class Enumerator<U> where U : T
        {
            private U[] items;
            private int count;
            private int position = -1;

            public Enumerator(CustomQueue<U> customQueue)
            {
                this.items = customQueue.items;
                this.count = customQueue.count;
            }

            public U Current
            {
                get { return items[position]; }
            }

            public bool MoveNext()
            {
                if (position == count - 1)
                    return false;

                position++;
                return true;
            }

            public void Reset()
            {
               position = -1;
            }

            public void Dispose()
            {
                this.Reset();
            }

        }

       
    }

    

}
