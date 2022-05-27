using System;

namespace HUMAYUN_AMEL_ST2API_TP1
{
    public class Exo1
    {
        # table of multiplication 
        public void Multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j <= 10 - 1)
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    else
                        Console.Write("{0}x{1} = {2}", i, j, i * j);
                }
                Console.Write("\n");
            }
        }
        
        # table of multiplication and it will only print odd number
        public void MultiplicationOdd()
        {
            for (int i = 1; i< 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int mul = i * j;
                    //Console.WriteLine( mul);

                    if (mul % 2 != 0)
                    {
                        Console.WriteLine("{0}x{1} = {2}", i, j,mul);
                    }
                }
            }
        }

        # table of multiplication and ask a number to user
        public void MultiplicationaskNumber(int n)
        {
                for (int j = 1; j <= 10; j++)
                {
                    if (j <= 10 - 1)
                        Console.Write("{0}x{1} = {2}, ", j, n, n * j);
                    else
                        Console.Write("{0}x{1} = {2}", n, j, n * j);
                }
                Console.Write("\n");
            
        }
    }
}

