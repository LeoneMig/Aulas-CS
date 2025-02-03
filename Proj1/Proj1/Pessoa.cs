using System;
using System.Collections.Generic;


namespace Proj1
{
    class Pessoa
    {
        public int Age;
        public string Name;

        public void Older(Pessoa p1, Pessoa p2)
        {
            if (p1.Age > p2.Age)
            {
                Console.WriteLine("Older: " + p1.Name);
            }
            else
            {
                Console.WriteLine("Older: " + p2.Name);
            }
            return;
        }
    }
}
