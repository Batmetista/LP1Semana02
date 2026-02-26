using System;

namespace TempConvert
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
            Console.WriteLine("Temperature: ");
            float t = Console.ReadLine();
            Console.WriteLine("Unit: ");
            string u = Console.ReadLine();
            float n;
        }
        private static void Switch(string[] args)
        {
            if (u == F)
        {
                n = t * 1.8 + 32;
                Console.WriteLine(u "F = " n "C");
                Console.WriteLine("Absolute value: " n);
        }
            else
        {
                n = (t - 32) / 1.8;
                Console.WriteLine(u "C = " n "F");
                Console.WriteLine("Absolute value: " n);
        }
        }
    }
}