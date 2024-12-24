using System;
using System.Diagnostics.CodeAnalysis;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                i++;
            }
            int a = 1;
            while (a != 20)
            {
                Console.WriteLine($" sayı: {a}");
                a++;
            }

            int even = 0;
            while( even != 19)
            {
                even++;
                int remainder = even % 2;
        
                if (remainder == 0)
                    Console.WriteLine($"sayı: {even}");
            }

            int b = 50;
            int sum = 0;

            while (b <=150)
            {
                sum += b;
                b++;
                
            }
            Console.WriteLine($"50 den 150'ye kadar olan sayıların toplamı: {sum}");


            int evenSum = 0;
            int oddSum = 0;
            int c = 1;
            while (c < 120)

            {
                int remainder2= c% 2;

                if (remainder2== 0)
                {
                    evenSum += c;
                    c++;
                }
                else if (remainder2== 1)
                {
                    oddSum += c;
                    c++;
                }
            }

            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");



        }
    }
}