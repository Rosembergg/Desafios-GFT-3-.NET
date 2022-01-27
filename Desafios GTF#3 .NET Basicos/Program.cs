using System;

namespace Desafios_GTF_3_.NET_Basicos
{
    class Program
    {
        
        static void Desafio1()
        {
            string str;
            while((str=Console.ReadLine())!= null)
            {
                if (str == null )
                {
                      Console.WriteLine("vai ter copa!"); 
                }
                else          //Escreva o seu código nos espaços em branco
                { 
                    int x = int.Parse(str);
                    if (x == 0)
                    {
                    Console.WriteLine("vai ter copa!"); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!");
                    }
                }
            }
        }

        static void Desafio2()
        {
            string [] selections = Console.ReadLine().Split(' ');
            int a = int.Parse(selections[0]);
            int b = int.Parse(selections[1]);
            int c = int.Parse(selections[2]);
            int d = int.Parse(selections[3]);

        // Implemente a condição abaixo para ter o resultado esperado
            if ((b > c) &&  (d > a) && ((c + d) > (a + b)) && (c > 0 && d > 0) && (a % 2 == 0))
	    	{
                Console.WriteLine("Valores aceitos");
            } 
        else 
            {
                Console.WriteLine("Valores nao aceitos");
            }                
        }
        
        static void Desafio3()
        {
            double a, b, c, d,avg;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            avg = (((a*2)+(b*3)+(c*4)+(d*1))/10);
            Console.WriteLine("Media: " +avg.ToString("0.0"));
            if (avg>7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
           else if (avg<5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (avg < 6.9 && avg>= 5)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.Write("Nota do exame: " + e.ToString("0.0")+"\n");
                avg = (avg + e) / 2.0;
                if (avg>=5)
                {
                    Console.WriteLine("Aluno aprovado.\n");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado\n");
                    
                }
                Console.WriteLine("Media final: " + avg.ToString("0.0"));
            }         
        }
        static void Main(string[] args)
        {
            
            
        }
    }
}
