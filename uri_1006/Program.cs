using System;
using System.Globalization;

namespace uri_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double prova1 = A * 2.0;
            double prova2 = B * 3.0;
            double prova3 = C * 5.0;

            double media = (prova1 + prova2 + prova3) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
