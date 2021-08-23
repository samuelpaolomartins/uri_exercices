using System;
using System.Globalization;

namespace uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++){
                string[] valor = Console.ReadLine().Split(' ');

                double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0)/10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
