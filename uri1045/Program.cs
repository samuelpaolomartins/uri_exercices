using System;
using System.Globalization;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, aux;

            string[] valor = Console.ReadLine().Split(' ');

            a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            if (a > b && a > c && c > b) {
                aux = b;
                b = c;
                c = aux;
            }
            
            if (b > a && b > c) {
                aux = a;
                a = b;
                b = aux;
                
                if (c > b) {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            
            if (c > a && c > b) {
                aux = a;
                a = c;
                c = aux;
                
                if (c > b) {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            
            if(a >= b+ c){

                Console.WriteLine("NAO FORMA TRIANGULO");
            
            }else{

                if((a * a) == (b * b) + (c * c)){

                    Console.WriteLine("TRIANGULO RETANGULO");

                }else if((a * a) > (b * b) + (c * c)){

                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                }else{

                    Console.WriteLine("TRIANGULO ACUTANGULO");

                }if(a == b && b == c){

                    Console.WriteLine("TRIANGULO EQUILATERO");

                }else if((a == b && a != c) || (b == c && b != a) || (c == a && c != b)){

                    Console.WriteLine("TRIANGULO ISOSCELES");

                }

            }
        }
    }
}
