using System;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int p = 0;

            for(int i=0; i<6; i++){

                numero = double.Parse(Console.ReadLine());

                if(numero > 0){
                    p++;
                }
            }

            Console.WriteLine(p + " valores positivos");
        }
    }
}
