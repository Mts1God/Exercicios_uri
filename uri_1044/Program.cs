using System;

namespace uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            long sobra = 0;
            Math.DivRem(b, a, out sobra);
            if (sobra == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
