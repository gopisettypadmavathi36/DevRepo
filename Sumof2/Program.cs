using System;

namespace Sumof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;

            Console.WriteLine("pass loop numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i<=10; i++)
            {
                b = a * i;
                Console.WriteLine("Div of three numbers{0}*{1}={2}", a, i, b);
            }
                       
            Console.ReadLine();
        }
    }
}

