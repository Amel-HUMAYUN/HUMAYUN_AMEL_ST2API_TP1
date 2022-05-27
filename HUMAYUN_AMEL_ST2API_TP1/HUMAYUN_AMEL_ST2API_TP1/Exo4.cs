using System;

namespace HUMAYUN_AMEL_ST2API_TP1
{
    public class Exo4
    {
        public void Square(int n, int m)
        {
            for (int i=1; i<= n; i++)
            {
                for(int j = 1; j <= m; j++)
                {
                    if ((i == 1 && i == j) || (i==1 && j ==m) || (i==n && j==1) || (i==n && j==m))
                        Console.Write("0");
                    else if ( j == 1 || j == m )
                        Console.Write("|");
                    else if (i == 1 ||i==n )
                        Console.Write("-");
                    else
                    {
                        Console.Write(" ");
                    }
                        

                }
                Console.WriteLine(" ");
            }
        }
       


    }
}

