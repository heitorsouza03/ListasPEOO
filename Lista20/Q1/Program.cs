using System;
using System.Collections;
using System.Collections.Generic;

namespace Q1
{
    class Conversor
    {
        private int num;
        private Stack pilha = new Stack();

        public void SetNum(int num) { num = this.num; }
        public string Binario()
        {
            string numero = null;
            int q = num;
            while (q != 1)
            {
                pilha.Push(q % 2);
                q = num / 2;
                num = q;
                if (q == 1) { pilha.Push(q); }
            }
            // while (pilha.Count > 0) { numero += pilha.Pop(); }
            // return numero;
            //COMO RETORNAR A PILHA?
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();
            Console.WriteLine("Digite um número para converter:");
            conversor.SetNum(int.Parse(Console.ReadLine()));

            Console.WriteLine(conversor.Binario());
        }
    }
}
