using System;
using System.Globalization;
using Exercicio1;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Altura = double.Parse(Console.ReadLine());
            x.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Area: " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}