using System;
using System.Collections;
using System.Collections.Generic;

namespace Q3
{
    class Pilha2<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        private int k = 1;

        public void Push(T obj)
        {
            q1.Enqueue(obj);
            for (int i = 0; i != k; i++) {
                q2.Enqueue(q1.Dequeue());
            }
            k++;
        }
        public T Pop()
        {
            return q2.Dequeue();
        }
        public T Top()
        {
            return q2.Peek();
        }
        public int Count()
        {
            return k;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
