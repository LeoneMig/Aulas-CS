using System;

namespace Ex_Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented: ");
            int qtd = int.Parse(Console.ReadLine());

            Pensionato[] list = new Pensionato[10];

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nRent #" + (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                list[(room-1)] = new Pensionato(name, email, room);
            }

            Console.WriteLine("\nBusy Rooms:");
            for (int i = 0;i < list.Length; i++)
            {
                if (list[i].Room != null)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}