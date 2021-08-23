using System;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;

            a = (Console.ReadLine());
            b = (Console.ReadLine());
            c = (Console.ReadLine());

            if(a.Equals("vertebrado") && b.Equals("ave") && c.Equals("carnivoro")){
                
                Console.WriteLine("aguia");
            
            }else if(a.Equals("vertebrado") && b.Equals("ave") && c.Equals("onivoro")){
                
                Console.WriteLine("pomba");
            
            }else if(a.Equals("vertebrado") && b.Equals("mamifero") && c.Equals("onivoro")){
                
                Console.WriteLine("homem");
            
            }else if(a.Equals("vertebrado") && b.Equals("mamifero") && c.Equals("herbivoro")){
                
                Console.WriteLine("vaca");
            
            }else if(a.Equals("invertebrado") && b.Equals("inseto") && c.Equals("hematofago")){
                
                Console.WriteLine("pulga");
            
            }else if(a.Equals("invertebrado") && b.Equals("inseto") && c.Equals("herbivoro")){
                
                Console.WriteLine("lagarta");
            
            }else if(a.Equals("invertebrado") && b.Equals("anelideo") && c.Equals("hematofago")){
                
                Console.WriteLine("sanguessuga");
            
            }else if(a.Equals("invertebrado") && b.Equals("anelideo") && c.Equals("onivoro")){
                
                Console.WriteLine("minhoca");
            
            }
        }
    }
}
