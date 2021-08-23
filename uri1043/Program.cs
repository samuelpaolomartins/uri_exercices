using System;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, area, perimetro;

            string[] valor = Console.ReadLine().Split(' ');

            A = double.Parse(valor[0]);
            B = double.Parse(valor[1]);
            C = double.Parse(valor[2]);

            if(A < B + C && B < A + C && C < B + A){

                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));

            }else{

                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1"));

            }
        }
    }
}
