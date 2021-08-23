using System;
using System.Globalization;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
        double raio, area;
        raio = Convert.ToDouble(Console.ReadLine());
        area = 3.14159 * (raio * raio);
        Console.WriteLine("A="+area.ToString("F4"));
        Console.ReadKey();
        }
    }
}
