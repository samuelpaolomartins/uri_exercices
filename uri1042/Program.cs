using System;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if(a > b && a > c && b > c){
                
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            
            }else if(a > b && a > c && c > b){
                
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);

            }else if(b > a && b > c && a > c){
                
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);

            }else if(b > a && b > c && c > a){

                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);

            }else if(c > a && c > b && a > b){

                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);

            }else if(c > a && c > b && b > a){

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
