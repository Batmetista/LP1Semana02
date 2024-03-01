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

                Console.WriteLine($"Resultado da operação de decremento de {n}: {--n}");
                Console.WriteLine($"Resultado da operação de incremento de {n}: {++n}");
            }
            else
            {
                Console.WriteLine("Número inválido. Certifique-se de digitar um número inteiro não-negativo dentro do intervalo permitido para um byte (0 a 255).");
            }
        }
    }
}
