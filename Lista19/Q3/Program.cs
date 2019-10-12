using System;

namespace Q3
{
    class ContaCorrente
    {
        private string titular;
        private string numeroConta;
        protected double saldo;
        
        public ContaCorrente(string t, string n)
        {
            titular = t;
            numeroConta = n;
        }
        public void Depositar(double valor){ saldo += valor; }
        public virtual bool Sacar(double valor)
        {
            if (saldo >= valor){
                saldo -= valor;
                return true;
            }
            else { return false; }
        }
        public double RetornarSaldo(){ return saldo; }
        public override string ToString()
        {
            return $"Titular: {titular} - Conta: {numeroConta} - Saldo = R${saldo}";
        }
    }
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l) : base(t, n)
        {
            limite = l;
        }
        public override bool Sacar(double valor)
        {
            if (saldo - valor >= limite * -1)
            {
                saldo -= valor;
                return true;
            }
            else { return false; }
        }
    }
    class Poupança : ContaCorrente
    {
        public Poupança(string t, string n) : base(t, n) {}
        public void Render(double juros)
        {
            saldo += (saldo * juros);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tipo de conta:");
            string r = Console.ReadLine();
            if (r == "ContaCorrente")
            {
                Console.WriteLine("Informe o nome do titular e o número da conta:");
                ContaCorrente c = new ContaCorrente(Console.ReadLine(), Console.ReadLine());

                Console.WriteLine("Insira o saldo inicial:");
                c.Depositar(double.Parse(Console.ReadLine()));

                Console.WriteLine("Saldo disponível: R$" + c.RetornarSaldo() + " Quanto deseja tirar?");
                bool saque = c.Sacar(double.Parse(Console.ReadLine()));
                if (saque == true) { Console.WriteLine("Sucesso!"); Console.WriteLine(c); }
                else { Console.WriteLine("Algo deu errado!"); }

            }
            else if (r == "ContaEspecial")
            {
                Console.WriteLine("Informe o nome do titular, o número da conta e o limite:");
                ContaEspecial c = new ContaEspecial(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));

                Console.WriteLine("Insira o saldo inicial:");
                c.Depositar(double.Parse(Console.ReadLine()));

                Console.WriteLine("Saldo disponível: R$" + c.RetornarSaldo() + " Quanto deseja tirar?");
                bool saque = c.Sacar(double.Parse(Console.ReadLine()));
                if (saque == true) { Console.WriteLine("Sucesso!"); Console.WriteLine(c); }
                else { Console.WriteLine("Algo deu errado!"); }
            }
            else if (r =="Poupança")
            {
                Console.WriteLine("Informe o nome do titular e o número da conta:");
                Poupança c = new Poupança(Console.ReadLine(), Console.ReadLine());

                Console.WriteLine("Insira o saldo inicial:");
                c.Depositar(double.Parse(Console.ReadLine()));

                Console.WriteLine("Saldo disponível: R$" + c.RetornarSaldo() + " Quanto deseja tirar?");
                bool saque = c.Sacar(double.Parse(Console.ReadLine()));
                if (saque == true) { Console.WriteLine("Sucesso!"); Console.WriteLine(c); }
                else { Console.WriteLine("Algo deu errado!"); }

                Console.WriteLine("Informe os juros:");
                c.Render(double.Parse(Console.ReadLine()));
            }
            else { Console.WriteLine("Tipo não disponível!"); }
        }
    }
}
