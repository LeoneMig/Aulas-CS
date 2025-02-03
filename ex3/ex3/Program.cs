using System;
using System.Globalization;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do Aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas dos 3 trimestres: ");
            x.N1 = double.Parse(Console.ReadLine());
            x.N2 = double.Parse(Console.ReadLine());
            x.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("NOTA FINAL: " + x.Media());
            if (x.Media() < 6.0)
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM " + (6 -  x.Media()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            } else
            {
                Console.WriteLine("APROVADO!");
            }
        }
    }
}