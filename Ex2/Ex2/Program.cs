using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func x = new Func();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário : " + x.ToString());
            Console.WriteLine();

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double pct = double.Parse(Console.ReadLine());
            x.AumentaSalario(pct);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + x.ToString());
        }
    }
}
