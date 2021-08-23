using System;

namespace uri1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if(a == 61){
                Console.WriteLine("Brasilia");
            }else if(a == 71){
                Console.WriteLine("Salvador");
            }else if(a == 11){
                Console.WriteLine("Sao Paulo");
            }else if(a == 21){
                Console.WriteLine("Rio de Janeiro");
            }else if(a == 32){
                Console.WriteLine("Juiz de Fora");
            }else if(a == 19){
                Console.WriteLine("Campinas");
            }else if(a == 27){
                Console.WriteLine("Vitoria");
            }else if(a == 31){
                Console.WriteLine("Belo Horizaonte");
            }else{
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
