using System;
using System.Globalization;

namespace uri__1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prod1 = Console.ReadLine().Split();
            string[] prod2 = Console.ReadLine().Split();




            int codigo = int.Parse(prod1[0]);
            int np = int.Parse(prod1[1]);
            double valor = double.Parse(prod1[2], CultureInfo.InvariantCulture);



            int codigo2 = int.Parse(prod2[0]);
            int np2 = int.Parse(prod2[1]);
            double valor_2 = double.Parse(prod2[2], CultureInfo.InvariantCulture);



            //Fórmula
            double valor1 = np * valor;
            double valor2 = np2 * valor_2;
            double vt = valor1 + valor2;



            Console.WriteLine("VALOR A PAGAR: R$ " + vt.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
