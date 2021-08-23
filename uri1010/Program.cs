using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int peça1, npeça1, peça2, npeça2;
            double resultado, vpeça1, vpeça2;
            string[] valor = Console.ReadLine().Split(' ');

            peça1 = int.Parse(valor[0]);
            npeça1 = int.Parse(valor[1]);
            vpeça1 = double.Parse(valor[2]);

            valor = Console.ReadLine().Split(' ');
            peça2 = int.Parse(valor[0]);
            npeça2 = int.Parse(valor[1]);
            vpeça2 = double.Parse(valor[2]);

            resultado = (npeça1 * vpeça1) + (npeça2 * vpeça2);

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2"));
        }
    }
}
