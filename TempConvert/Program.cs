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
            Console.WriteLine("Insira o vlaor da temperatura: ");
            float t = Console.ReadLine();
            Console.WriteLine("Insira a unidade de origem: ");
            string u = Console.ReadLine();
            float n;
        }
        private static void Switch(string[] args)
        {
            if (u == F)
        {
                n = t * 1.8 + 32;
        }
            else
        {
                n = (t - 32) / 1.8;
        }
        }
    }
}