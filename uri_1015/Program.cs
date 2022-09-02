using System;
using System.Globalization;

namespace uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, Distancia;
            string[] valores;

            valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.00) + Math.Pow(y1 - y2, 2.00));
            Console.WriteLine(Distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
