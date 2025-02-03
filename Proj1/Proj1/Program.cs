using System;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Daddos P1:");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Daddos P2:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Older(p1, p2);
        }
    }
}