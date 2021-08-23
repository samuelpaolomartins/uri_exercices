using System;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, mi, hf, mf;

            string[] valor = Console.ReadLine().Split(' ');

            hi = int.Parse(valor[0]);
            mi = int.Parse(valor[1]);
            hf = int.Parse(valor[2]);
            mf = int.Parse(valor[3]);

            int instanteInicial = hi * 60 + mi;
            int instanteFinal = hf * 60 + mf;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}