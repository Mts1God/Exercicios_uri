using System;
using System.Globalization;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            //formula triângulo retângulo
            double atr = (a * c) / 2;
            //formula círculo
            double cir = pi * (c * c);
            //formula trapézio
            double trap = ((a + b) * c) / 2;
            //formula quadrado
            double qua = b * b;
            //formula retangulo
            double ret = a * b;

            Console.WriteLine("TRIANGULO: " + atr.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + qua.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
