using System;

namespace Uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] vetor = Console.ReadLine().Split(' ');
            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }

           
        }
    }
}
