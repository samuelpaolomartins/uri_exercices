using System;
using System.Globalization;
namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            {

        int horas, velocidade;
        double tempoGasto;

        horas = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());
       
        tempoGasto = (double)(horas * velocidade) / 12;
              
        Console.WriteLine(tempoGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
}