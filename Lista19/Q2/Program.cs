using System;

namespace Q2
{
    class Frete
    {
        private double distancia;
        private double peso;

        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        public virtual decimal CalcFrete()
        {
            return decimal.Parse($"{distancia * peso * 0.01}");
        }
        public override string ToString()
        {
            return $"Distância: {distancia} - Peso: {peso} - Valor do Frete {CalcFrete()}";
        }
        public double GetDistancia() { return distancia; }
        public double GetPeso() { return peso; }
    }
    class FreteExpresso : Frete
    {
        private decimal seguro;
        public FreteExpresso(double d, double p, decimal s) : base(d, p)
        {
            seguro = s; 
        }
        public override decimal CalcFrete()
        {
            return decimal.Parse($"{GetDistancia() * GetPeso() * 2 + 1/100 * double.Parse($"{seguro}")}");
        }
        public override string ToString()
        {
            return $"Distância: {GetDistancia()} - Peso: {GetPeso()} - Percentagem do Seguro{seguro*1/100}- Valor do Frete {CalcFrete()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Normal ou Expresso?");
            string r = Console.ReadLine();
            if (r == "Normal")
            {
                Console.WriteLine("Digite a distância e o peso");
                Frete f = new Frete(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine(f);
            }
            else if (r == "Expresso")
            {
                Console.WriteLine("Digite a distancia, o peso e o valor do seguro");
                FreteExpresso f = new FreteExpresso(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), decimal.Parse(Console.ReadLine()));
                Console.WriteLine(f);
            }
        }
    }
}
