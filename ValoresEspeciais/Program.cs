using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            Console.WriteLine("");

            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity);

            Console.WriteLine(double.NaN);

            Console.WriteLine("");

            uint ui = uint.MaxValue;
            Console.WriteLine(ui + 1);

            Console.WriteLine(2 * float.MaxValue);
            Console.WriteLine(float.MaxValue + 1);

            Console.WriteLine(2 * float.MinValue);
            Console.WriteLine(float.MinValue - 1);
        }
    }
}
