using System;

namespace Exo_2
{
    class Program
    {
        static void Prime()
        {
          
            for (int num = 1; num <= 1000; num++)
            {
                int ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        static void Main(string[] args)
        {

            Prime();
            var myParam = AskUserForParameter();

        }
    }
}




/////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace ConsoleApp4
{
    class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        static void Multiplication(int i)
        {
            for (int j = 1; j < 10; j++)
            {
                int mul = i * j;
                Console.WriteLine(mul);
                if (mul % 2 != 0)
                {
                    Console.WriteLine(mul);
                }
                else
                {
                }
            }
        }

        static void Prime()
        {
            for (int num = 1; num <= 1000; num++)
            {
                int ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
        }

        static void Fibo(int asknum)
        {
            int f0 = 0;
            int f1 = 1;
            Console.WriteLine("La suite de Fibonacci est :");

            for (int a=2; a<= asknum; a ++)
            {
                int next = f0 + f1;
                f0 = f1;
                f1 = next;
                Console.WriteLine(next);
                
            }
            
        }

        static void Facto(int asknbr)
        {
            int fac = 1;
            for (int f = 1; f <= asknbr + 1; f++)
            {
                fac *= f;
            }
            Console.WriteLine(fac);
        }
    }

        static void Main(string[] args)
        {
            // exo 1
            var myParam = AskUserForParameter();
            //Multiplication(myParam);

            // exo 2
            //Prime();
            //Fibo(myParam);
            Facto(myParam);
        }
    }
}
