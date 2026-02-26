using System;

namespace MeuPrograma
{
    /// <summary>
    /// Classe principal
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Método principal
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro: ");
            sbyte n = Console.ReadLine();
            sbyte m = --n;
            sbyte l = ++m;
            console.WriteLine(m);
            console.WriteLine(l);
        }
    }
}