using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, cedula100, cedula50, cedula20, cedula10, cedula5, cedula2, cedula1;

            N = int.Parse(Console.ReadLine());

            cedula100 = N / 100;
            resto = N % 100;
            cedula50 = resto / 50; 
            cedula20 = (resto % 50) / 20;
            cedula10 = ((resto % 50) % 20) / 10;
            cedula5 = (((resto % 50) % 20) % 10) / 5;
            cedula2 = ((((resto % 50) % 20) % 10) % 5) / 2;
            cedula1 = (((((resto % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine(N);
            Console.WriteLine(cedula100 + " nota(s) de R$ 100,00");
            Console.WriteLine(cedula50 + " nota(s) de R$ 50,00");
            Console.WriteLine(cedula20 + " nota(s) de R$ 20,00");
            Console.WriteLine(cedula10 + " nota(s) de R$ 10,00");
            Console.WriteLine(cedula5 + " nota(s) de R$ 5,00");
            Console.WriteLine(cedula2 + " nota(s) de R$ 2,00");
            Console.WriteLine(cedula1 + " nota(s) de R$ 1,00");
        }
    }
}
