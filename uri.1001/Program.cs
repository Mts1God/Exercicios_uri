using System;

namespace uri._1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====");
            Console.WriteLine("SOMA");
            Console.WriteLine("====");
            Console.WriteLine("digite um numero");                                 
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int x = n1 + n2;

            Console.WriteLine("x =" + x);            
        }
    }
}
