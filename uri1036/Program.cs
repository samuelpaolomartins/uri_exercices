using System;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, r1, r2;
            string[] linha = Console.ReadLine().Split(' ');

            A = double.Parse(linha[0]);
            B = double.Parse(linha[1]);
            C = double.Parse(linha[2]);
            
            r1 = (B * (-1) + Math.Sqrt((B * B) - 4 * A * C)) / (2 * A);
            r2 = (B * (-1) - Math.Sqrt((B * B) - 4 * A * C)) / (2 * A);

            if(A == 0 || B == 0 || C == 0 || ((B * B) - 4 * A * C) < 0){
               
               Console.WriteLine("Impossivel calcular");

            }else{
                
                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            
            }
        }
    }
}
