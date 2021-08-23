using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, total;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = X/Y;

            Console.WriteLine(total.ToString("F3") + " km/l");
        }
    }
}
