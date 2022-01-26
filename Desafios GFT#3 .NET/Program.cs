using System;

namespace Desafios_GFT_3_.NET
{
    class Program
    {

        static void Desafio1()
        {
            int a = 1;
            int b = 9;
            int c = 4;
            int d = 3;
            int total = 0;

            //Console.WriteLine("Digite o numero A:");
            a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero B:");
            b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero C:");
            c = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero D:");
            d = int.Parse(Console.ReadLine());
            total = (a*b)-(c*d);
            Console.WriteLine($"DIFERENCA = {total}"); 
        }

        static void Desafio2()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            
             
            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
              }
            else {
                Console.WriteLine("Nao sao Multiplos");
              }
        }

        static void Desafio2()
        {
            string[] input;
            string[] input1;

            input = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(input[0]);
            int n1 = int.Parse(input[1]);
            decimal valor1 = decimal.Parse(input[2]);
            input1 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(input1[0]);
            int n2  = int.Parse(input1[1]);
            decimal valor2 = decimal.Parse(input1[2]);

            decimal total = (n1*valor1) + (n2*valor2);
            Console.WriteLine("VALOR A PAGAR: R$ "+total.ToString());
        }
        static void Main(string[] args)
        {
            
        }
    }
}
