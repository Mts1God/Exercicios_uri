using System;
using System.Globalization;

namespace uri_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double peso1= p1 * 3.5;
            double peso2= p2 * 7.5;
            double MEDIA = (peso1 + peso2) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
