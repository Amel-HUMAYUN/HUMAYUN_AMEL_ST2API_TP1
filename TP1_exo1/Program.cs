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
            for (int j = 1; j < 11; j++)
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



        static void Main(string[] args)
        {
            var myParam = AskUserForParameter();
            Multiplication(myParam);


        }
    }
}
