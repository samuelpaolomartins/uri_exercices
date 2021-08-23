using System;

namespace uri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] valor = Console.ReadLine().Split(' ');

            A = int.Parse(valor[0]);
            B = int.Parse(valor[1]);

            if(A % B == 0 || B % A == 0){
                Console.WriteLine("Sao Multiplos");
            }else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
