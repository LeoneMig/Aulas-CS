using System;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            Data[] list = new Data[qtd];
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Nome: ");
                string nombre = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list[i]= new Data(nombre, preco);
            }

            double avg = 0.0;
            for (int i = 0; i < qtd; i++)
            {
                avg += list[i].Value;
            }
            

            Console.WriteLine("AVERAGE: " + (avg / qtd).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
