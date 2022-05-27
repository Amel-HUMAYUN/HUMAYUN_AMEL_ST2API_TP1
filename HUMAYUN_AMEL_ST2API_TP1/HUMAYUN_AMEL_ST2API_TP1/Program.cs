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
        
        static void Main(string[] args)
        {    
            // Display tittle as the C# console for TP1
            Console.WriteLine("Hello FONTANA Julien !!!! Here is the TP1 in C# by HUMAYUN Amel");
            Console.WriteLine("-----------------------------------------------------------");

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
