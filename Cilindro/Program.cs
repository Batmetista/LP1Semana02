using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do cilindro:");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio do cilindro:");
            float raio = float.Parse(Console.ReadLine());

            float volume = MathF.PI * MathF.Pow(raio, 2) * altura;
            float areaSuperficie = 2 * MathF.PI * raio * (raio + altura);

            Console.WriteLine($"Volume do cilindro: {volume}");
            Console.WriteLine($"Área de superfície do cilindro: {areaSuperficie}");
        }
    }
}
