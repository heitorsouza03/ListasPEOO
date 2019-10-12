using System;

namespace Q1
{
    class Retangulo
    {
        private double b;
        private double h;

        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double GetBase() { return b; }
        public double GetAltura() { return h; }
        public double CalcArea() { double A = b * h; return A; }
        public double CalcDiagonal() { double D = Math.Sqrt((b*b)+(h*h)); return D; }
        public override string ToString()
        {
            return $"Base = {b} - Altura = {h} - Área = {CalcArea()} - Diagonal = {CalcDiagonal()}";
        }
    }
    class Quadrado : Retangulo
    {
        private double l;
        public Quadrado(double l) : base(l, l) { this.l = l; }

        public override string ToString(){
            return $"Lado = {l} - Área = {CalcArea()} - Diagonal = {CalcDiagonal()}";  
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadrado ou Retângulo?");
            string r = Console.ReadLine();
            if (r == "Quadrado")
            {
                Console.WriteLine("Digite o lado:");
                Quadrado q = new Quadrado(double.Parse(Console.ReadLine()));
                Console.WriteLine(q);
            }
            else if (r == "Retângulo")
            {
                Console.WriteLine("Digite a base e a altura");
                Retangulo q = new Retangulo(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine(q);
            }
            else
            {
                Console.WriteLine("Não entendi!");
            }
        }
    }
}