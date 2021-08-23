using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, mes, dia, N, resto;

            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            resto = N % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
