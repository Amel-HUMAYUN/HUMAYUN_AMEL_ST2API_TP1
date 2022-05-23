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
            Console.Write("\n");

        }
        static void Main(string[] args)
        {

            Prime();
        }
    }
}
