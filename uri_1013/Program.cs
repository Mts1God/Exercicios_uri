using System;
using System.Globalization;

namespace uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0], CultureInfo.InvariantCulture);
            int b = int.Parse(valores[1], CultureInfo.InvariantCulture);
            int c = int.Parse(valores[2], CultureInfo.InvariantCulture);

            //Fórmula
            double MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            double MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine(+MaiorABC + " eh o maior");

        }
    }
}
