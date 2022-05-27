using System;

namespace HUMAYUN_AMEL_ST2API_TP1
{
    public class Exo2
    {
        //Prime number between 1 and 1000
        public void Prime()
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

        //Fibonacci 1 to a number that will ask to user
        public void Fibo(int asknum)
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

        // Factorial of a number that will ask to user
        public void Factorial(int ask)
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
    }
}

