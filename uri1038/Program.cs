using System;
using System.Globalization;
namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade, codigo;
            string[] valores = Console.ReadLine().Split(' ');

            codigo = int.Parse(valores[0]);
            quantidade = int.Parse(valores[1]);

            double total;
            if(codigo == 1){
                total = 4.00 * quantidade;
            }else if(codigo == 2){
                total = 4.50 * quantidade;
            }else if(codigo == 3){
                total = 5.00 * quantidade;
            }else if(codigo == 4){
                total = 2.00 * quantidade;
            }else{
                total = 1.00 * quantidade;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
