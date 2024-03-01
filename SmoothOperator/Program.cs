using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro não-negativo.");
            string input = Console.ReadLine();
            int number = int.Parse( input );
            if (number >= 0 && number <= byte.MaxValue)
            {
                byte n = (byte)number;

                Console.WriteLine($"{--n}");
                Console.WriteLine($"{++n}");
                Console.WriteLine($"{n / 2}");
                Console.WriteLine($"{n << 3}");
                Console.WriteLine($"{n ^ 5}");
                if(n > 10);
                {
                    Console.WriteLine("True");

                }
                else;
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
}
