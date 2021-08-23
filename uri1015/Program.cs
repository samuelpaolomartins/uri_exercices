﻿using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] vetor;

            vetor = Console.ReadLine().Split(' ');   

            x1 = double.Parse(vetor[0],CultureInfo.InvariantCulture);
            y1 = double.Parse(vetor[1],CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' '); 

            x2 = double.Parse(vetor[0],CultureInfo.InvariantCulture);
            y2 = double.Parse(vetor[1],CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
