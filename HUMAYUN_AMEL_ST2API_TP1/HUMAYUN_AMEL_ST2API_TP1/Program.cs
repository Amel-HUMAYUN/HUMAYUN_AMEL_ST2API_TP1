using System;

namespace HUMAYUN_AMEL_ST2API_TP1
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

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        static void Function()
        {
            
            for (int j = -3; j<=3; j++)
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



        



        static void Main(string[] args)
        {

            /* 
             Exo1 exo1_1 = new Exo1();
             exo1_1.Multiplication(AskUserForParameter());

             Exo1 exo1_2 = new Exo1();
             exo1_2.Multiplication(AskUserForParameter());

             Exo2 exo2_1 = new Exo2();
             exo2_1.Prime();

             Exo2 exo2_2 = new Exo2();
             exo2_2.Fibo(AskUserForParameter());

             Exo2 exo2_3 = new Exo2();
             exo2_3.Factorial(AskUserForParameter());

             Exo3 exo3 = new Exo3();
             exo3.Function(); 

            Exo4 exo4 = new Exo4();
            exo4.Square(AskUserForParameter(), AskUserForParameter());

            Exo5 exo5 = new Exo5();
            exo5.Christmas(AskUserForParameter());
            */
            // Display tittle as the C# console for TP1
            Console.WriteLine("Console TP1 in C# by HUMAYUN Amel");
            Console.WriteLine("---------------------------------");

            // Ask user to choose an exercice

            Console.WriteLine("Choose an exercise please :");
            Console.WriteLine("a - Exo_1_1_multiplication ");
            Console.WriteLine("b - Exo1_2_multiplication_odd ");
            Console.WriteLine("c - Exo1_2_multiplication_ask_user ");
            Console.WriteLine("d - Exo_2_1_prime ");
            Console.WriteLine("e - Exo2_2_fibonacci");
            Console.WriteLine("f - Exo2_3_factorial");
            Console.WriteLine("g - Exo3_divison_by_zero");
            Console.WriteLine("h - Exo_4_1_rectangle");
            Console.WriteLine("i - Exo_5_1_regularTree");
            Console.Write("Your option? ");


            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result for the exo_1_1: ");
                    Exo1 exo1_1 = new Exo1();
                    exo1_1.Multiplication();
                    break;
                case "b":
                    Console.WriteLine($"Your result to only print the odd resultat : ");
                    Exo1 exo1_2 = new Exo1();
                    exo1_2.MultiplicationOdd();
                    break;

                case "c":
                    Console.WriteLine($"Your result to only print the odd resultat : ");
                    Exo1 exo1_3 = new Exo1();
                    exo1_3.MultiplicationaskNumber(AskUserForParameter());
                    break;
                case "d":
                    Console.WriteLine($"Your result of all prime number between 1 and 1000: ");
                    Exo2 exo2_1 = new Exo2();
                    exo2_1.Prime();
                    break;

                case "e":
                    Console.WriteLine($"Your result for fibonacci : ");
                    Exo2 exo2_2 = new Exo2();
                    exo2_2.Fibo(AskUserForParameter());
                    break;

                case "f":
                    Console.WriteLine($"Your result for factorial: ");
                    Exo2 exo2_3 = new Exo2();
                    exo2_3.Factorial(AskUserForParameter());
                    break;

                case "g":
                    Console.WriteLine($"Your result for the divsion by zero : ");
                    Exo3 exo3 = new Exo3();
                    exo3.Function();
                    break;

                case "h":
                    Console.WriteLine($"Your result for the rectangle: ");
                    Exo4 exo4 = new Exo4();
                    exo4.Square(AskUserForParameter(), AskUserForParameter());
                    break;

                case "i":
                    Console.WriteLine($"Your result: ");
                    Exo5 exo5 = new Exo5();
                    exo5.Christmas(AskUserForParameter());
                    break;
            }





        }
    }
}
