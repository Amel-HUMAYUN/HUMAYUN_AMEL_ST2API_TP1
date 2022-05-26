using System;

namespace Exercice_2
{
    class Program
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
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
            Console.WriteLine(f0);
            Console.WriteLine(f1);
            for (int a = 2; a <= asknum; a++)
            {
                int next = f0 + f1;
                f0 = f1;
                f1 = next;
                Console.WriteLine(next);

            }

        }


        static void Factorial(int ask)
        {
            int factorial = 1;
            if (ask < 0)
                Console.WriteLine("Cannot find the factorial of a negative number");
            else if (ask == 1)
                Console.WriteLine(factorial);
            else
            {
                for (int counter = ask; counter >= 2; counter--)
                    factorial = factorial * counter;

                Console.WriteLine(factorial);
            }
        }
        static void Main(string[] args)
        {
            // exo 2
            var myParam = AskUserForParameter();
            Prime();

            Fibo(myParam);

            Factorial(myParam);
        }
    }
}
