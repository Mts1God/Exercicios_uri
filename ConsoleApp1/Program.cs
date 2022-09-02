using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidadeCarroX = 60;
            int velocidadeCarroY = 90;

            int distancia = velocidadeCarroY - velocidadeCarroX;
            int x = (60 * distancia) / 30;
            int tempo = x - distancia;

            System.out.println(tempo + " minutos");
        }
    }
}
