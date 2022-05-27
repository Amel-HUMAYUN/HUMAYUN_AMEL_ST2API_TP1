using System;

namespace HUMAYUN_AMEL_ST2API_TP1
{
    public class Exo3
    {
        // function that will catch a division by zero
        public void Function()
        {
            for (int j = -3; j <= 3; j++)
            {
                try
                {
                    Console.WriteLine(10 / ((int)(Math.Pow(j, 2)) - 4));
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

