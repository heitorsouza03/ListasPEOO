using System;
using System.Linq;

namespace Q5
{
    class Contato
    {
        private string nome;
        private string fone;

        public Contato(string n, string f)
        {
            nome = n;
            fone = f;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetFone()
        {
            return fone;
        }
        public override string ToString()
        {
            return $"{nome} ({fone})";

        }
    }
    class Grupo
    {
        private string descricao;
        private Contato[] contatos = new Contato[50];
        private int k;

        public Grupo(string d) { descricao = d; }
        public void Adicionar(Contato c)
        {
            if (k <= 50) contatos[k++] = c;
        }
        public void Excluir(Contato c)
        {
            var membros = contatos.ToList();
            membros.Remove(c);
        }
        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[k];
            Array.Copy(contatos, c, k);
            Array.Sort(c);
            return c;
        }
        public override string ToString()
        {
            return $"{k} - '{descricao}'";
        }
    }
    class Usuario : Contato
    {
        private Contato[] contatos = new Contato[1000];
        private Grupo[] grupos = new Grupo[100];
        private int co, gu;

        public Usuario(string n, string f) : base(n, f) { }
        public void InserirContato(Contato c)
        {
            if (co <= 1000) contatos[co++] = c;
        }
        public void InserirGrupo(Grupo g)
        {
            if (gu <= 1000) grupos[gu++] = g;
        }
        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[co];
            Array.Copy(contatos, c, co);
            Array.Sort(c);
            return c;
        }
        public Contato[] ListarGrupos()
        {
            Contato[] c = new Contato[gu];
            Array.Copy(contatos, c, gu);
            Array.Sort(c);
            return c;
        }
        public override string ToString()
        {
            return $"{GetNome()} ({GetFone()})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
