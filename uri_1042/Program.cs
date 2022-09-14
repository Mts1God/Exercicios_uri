using System;

namespace uri_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] valores = Console.ReadLine().Split();
            //int meio = 0;
            //int maior = Math.Max(Math.Max(int.Parse(valores[0]), int.Parse(valores[1])), int.Parse(valores[2]));
            //int menor = Math.Min(Math.Min(int.Parse(valores[0]), int.Parse(valores[1])), int.Parse(valores[2]));
            //
            //for (int x = 0; x < 3; x++)
            //{
            //    if (int.Parse(valores[x]) != maior && int.Parse(valores[x]) != menor)
            //    {
            //        meio = int.Parse(valores[x]);
            //        break;
            //    }
            //    else if (int.Parse(valores[x]) >= meio)
            //    {
            //        meio = int.Parse(valores[x]);
            //    }
            //}
            //Console.WriteLine($"{menor}\n{meio}\n{maior}\n");
            //
            //foreach (string valor in valores)
            //{
            //    Console.WriteLine(valor);
            //}

            string[] numeros = Console.ReadLine().Split(' ');
            int numOne = int.Parse(numeros[0]);
            int numTwo = int.Parse(numeros[1]);
            int numThree = int.Parse(numeros[2]);
            int menor = 0, medio = 0, maior = 0;
            if (numOne < numTwo && numOne < numThree && numTwo < numThree)
            {
                menor = numOne;
                medio = numTwo;
                maior = numThree;
            }
            else if (numOne < numTwo && numOne < numThree && numTwo > numThree)
            {
                menor = numOne;
                medio = numThree;
                maior = numTwo;
            }
            else if (numOne > numTwo && numOne < numThree && numTwo < numThree)
            {
                menor = numTwo;
                medio = numOne;
                maior = numThree;
            }
            else if (numOne > numTwo && numOne > numThree && numTwo < numThree)
            {
                menor = numTwo;
                medio = numThree;
                maior = numOne;
            }
            else if (numOne > numTwo && numOne > numThree && numTwo > numThree)
            {
                menor = numThree;
                medio = numTwo;
                maior = numOne;
            }
            else
            {
                menor = numThree;
                medio = numOne;
                maior = numTwo;
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine("");
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);
            Console.WriteLine(numThree);
        }
    }
}
