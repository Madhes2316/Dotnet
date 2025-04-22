using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Check if a number is odd or even.
            //Console.Write("Enter a number to check if its a even or odd: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //if(userInput % 2 == 0)
            //{
            //    Console.WriteLine("Is an even number");
            //}
            //else
            //{
            //    Console.WriteLine("Is an odd number");
            //}

            //2.Find the greatest of three numbers.
            //Console.Write("Enter the first number : ");
            //int userInput1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second number : ");
            //int userInput2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third number : ");
            //int userInput3 = Convert.ToInt32(Console.ReadLine());

            //if(userInput1 > userInput2 && userInput1 > userInput3)
            //{
            //    Console.WriteLine("First number is the greatest");
            //}
            //else if (userInput2 > userInput1 && userInput2 > userInput3)
            //{
            //    Console.WriteLine("second number is the greatest");
            //}
            //else if (userInput3 > userInput1 && userInput3 > userInput2)
            //{
            //    Console.WriteLine("third number is the greatest");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are equal");
            //}

            //3.Swap two numbers using a method
            //int a = 5;
            //int b = 10;

            //Console.WriteLine($"Before Swapping a:{a},b:{b}");

            //int c = a + b;
            //b = c - b;
            //a = c - b;

            //Console.WriteLine($"After Swapping a:{a},b:{b}");

            //4.Find the power of a number (e.g., 2^5 = 32).
            //Console.Write("Enter a number: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the power of the number: ");
            //int userInput1 = Convert.ToInt32(Console.ReadLine());
            //int numToThePower = 1;

            //for (int i = 1; i <= userInput1; i++)
            //{
            //    numToThePower = numToThePower * userInput;
            //}
            //Console.WriteLine(numToThePower);

            //5.Check if the year is leap year or not
            Console.Write("Enter the power of the number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput % 4 == 0)
            {

                if (userInput % 100 == 0)
                {
                    Console.WriteLine(userInput % 400 == 0 ? "Is a leap year" : "Not a leap year");
                }
                else
                {
                    Console.WriteLine("Is a leap year");
                }
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }

        }
    }
}
