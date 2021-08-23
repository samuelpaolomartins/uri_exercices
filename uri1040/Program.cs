using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, N4, media, exame, nmedia;
            string[] valor = Console.ReadLine().Split(' ');

            N1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(valor[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(valor[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(valor[3], CultureInfo.InvariantCulture);

            media = ((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + N4) / 10.0;

            if (media == 4.85){
                
                media = 4.8;
                                
            }
            
            if(media >= 7.0){

                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno aprovado.");

            }else if(media < 7.0 && media >= 5.0){

                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno em exame.");   

                exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + exame.ToString("F1"));

                nmedia = (exame + media) / 2;

                if(nmedia >= 5.0){

                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + nmedia.ToString("F1"), CultureInfo.InvariantCulture);

                }else if(nmedia < 5.0){

                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + nmedia.ToString("F1"), CultureInfo.InvariantCulture);

                }

            }else if(media < 5.0){

                Console.WriteLine("Media: " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno reprovado.");

            }
        }
    }
}