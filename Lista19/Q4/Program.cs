using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q4
{
    class Funcionario
    {
        public string nome { get => nome; set => nome = value; }
        public string email { get => email; set => email = value; }
        public string fone { get => fone; set => fone = value; }

        public override string ToString()
        {
            return $"{nome} - {email} - {fone}";
        }
    }
    class Engenheiro : Funcionario
    {
        public string crea { get => crea; set => crea = value; }
        public override string ToString()
        {
            return $"Engenheiro - {nome} - {crea} - {email} - {fone}";
        }
    }
    class Motorista : Funcionario
    {
        public string cnh { get => cnh; set => cnh = value; }
        public override string ToString()
        {
            return $"Motorista - {nome} - {cnh} - {email} - {fone}";
        }
    }
    class Construtora
    {
        private List<Funcionario> funcs = new List<Funcionario>();
        
        public void Inserir(Funcionario f){
            funcs.Add(f);
        }
        public List<Funcionario> Funcionarios()
        {
            return funcs;
        }
        public bool Teste(Funcionario f)
        {
            return (f.ToString().IndexOf("cnh") == -1);
        }
        public List<Engenheiro> Engenheiros()
        {
            List<Engenheiro> engs = new List<Engenheiro>();
            foreach(Funcionario f in funcs)
            {
                if(f is Engenheiro) { engs.Add(f as Engenheiro); }
            }
            return engs;
        }
        public List<Motorista> Motoristas()
        {
            List<Motorista> moto = new List<Motorista>();
            foreach (Funcionario f in funcs)
            {
                if (f is Motorista) { moto.Add(f as Motorista); }
            }
            return moto;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Construtora c = new Construtora();
        }
    }
}
