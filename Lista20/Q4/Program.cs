using System;
using System.Collections;
using System.Collections.Generic;

namespace Q4
{
    class Agenda
    {
        private List<Contato> cs = new List<Contato>();

        public void Inserir(Contato c)
        {
            cs.Add(c);
        }
        public List<Contato> Listar()
        {
            return cs;
        }
        public List<Contato> Pesquisar(string inicio)
        {
            return cs[cs.BinarySearch(inicio)];
        }

    }
    class Contato
    {
        public string nome, email, fone;
        public override string ToString()
        {
            return $"{nome} - {email} - {fone}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
