using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
           int hi, hf, duracao;
           string[] valor = Console.ReadLine().Split(' ');

           hi = int.Parse(valor[0]);
           hf = int.Parse(valor[1]);

           if(hi < hf){
               duracao = hf - hi;
           }else{
               duracao = 24 - hi + hf;
           }

           Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
