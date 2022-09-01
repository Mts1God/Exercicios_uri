using System;
using System.Globalization;

namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cm = D / L;
            Console.WriteLine(cm.ToString("F3", CultureInfo.InvariantCulture) + "km/l");

        }
    }
}
