using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salario, Tvendas, TOTAL;

            nomeVendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Tvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TOTAL = salario + (Tvendas * 0.15);
            
            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
