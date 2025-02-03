using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int aux_id = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular: ");
            string aux_nome = Console.ReadLine();
            Console.Write("Depósito inicial (s/n) ? ");
            char dep = char.Parse(Console.ReadLine());
            double aux_valor = 0.0;
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                aux_valor = double.Parse(Console.ReadLine());
            }

            Conta conta1 = new Conta(aux_nome, aux_id, aux_valor);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.WriteLine();

            Console.Write("Entre o valor do depósito: ");
            conta1.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
            Console.WriteLine();

            Console.Write("Entre o valor de saque: ");
            conta1.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);

        }
    }
}