using System;

namespace HUMAYUN_AMEL_ST2API_TP1
{
    public class Exo5
    {
        // Christmas tree not decorate
        public void Christmas(int num)
        {
            string str = "";
            for (int i= 0; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    str += " ";
                }
                for (int k=0; k< 2 *i -1;k++)
                {
                    str += "*";
                }
                str += "\n";
            }
            Console.WriteLine(str);
            // the trunk
            int widthTree = (num * 2) - 1;
            int center = widthTree / 2;

            for (int t = 1; t <= center; t++)
            {
                if (t == center)
                {
                    Console.Write("| |");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
 }
