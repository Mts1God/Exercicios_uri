using System;
using System.Globalization;

namespace uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;



            //Fórmula
            double volume = (4 / 3.0) * pi * (r * r * r);



            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
