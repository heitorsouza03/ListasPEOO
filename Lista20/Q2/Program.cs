using System;
using System.Collections.Generic;

namespace Q2
{
    class Pilha1<T>
    {
        List<T> lista = new List<T>();
        private int k;
        
        public void Push(T obj)
        {
            lista.Add(obj);
            k++;
        }
        public T Pop()
        {
            T r = lista[k];
            lista.RemoveAt(k);
            return r;
        }
        public T Top()
        {
            T r = lista[k];
            return r;
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
