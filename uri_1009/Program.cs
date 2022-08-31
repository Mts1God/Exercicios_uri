using System;
using System.Globalization;

namespace uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = (Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comissao = totalv * 0.15;
            double salariofinal = salario + comissao;
            Console.WriteLine("TOTAL = R$ " + salariofinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
