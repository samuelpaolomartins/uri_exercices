using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            // horas 60 min, 3600 seg.
            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
