using System;
using System.Globalization;

namespace uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double V = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Salario = (H * V);
            Console.WriteLine("NUMBER = " + N);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2" + CultureInfo.InvariantCulture));
        }
    }
}
