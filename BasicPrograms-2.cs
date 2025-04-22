using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.First n even numbers

            //Console.Write("Number of even numbers you want? ");
            //int evenCount = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= evenCount; i++)
            //{
            //    Console.WriteLine(i * 2);
            //}

            //2.Fatorial
            //Console.Write("Enter a number to get factorial? ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;

            //for (int i = 1; i <= userInput; i++)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine(factorial);

            //3.Reverse a number
            //Console.Write("Enter a number to be reversed? ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int reversedNumber = 0;

            //while(userInput != 0)
            //{
            //    int lastDigit = userInput % 10; //4
            //    reversedNumber = (reversedNumber * 10) + lastDigit; //0 x 10 + 4 = 4
            //    userInput = userInput / 10; //1234/10 = 123
            //}
            //Console.WriteLine(reversedNumber);

            //4.Simple Pattern
            //Console.Write("Enter a number of star pattern you want? ");
            //int userInputRow = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= userInputRow; i++) {

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            //5. Use while to print 1 to 10
            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //6. Use do-while to print 10 to 1
            //int i = 10;

            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i >= 1);

            //7. Print all even numbers from 1 to 100
            //Console.Write("Number of even numbers you want? ");
            //int evenCount = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= evenCount; i++)
            //{
            //    Console.WriteLine(i * 2);
            //}

            //8. Check if a number is prime
            //Console.Write("Enter a number to check if its a prime number or not: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //bool isPrime = false;
            //bool initialCheck = false;


            //if (userInput <= 1 || userInput % 2 == 0) {
            //    initialCheck = true;
            //    Console.WriteLine("Not a prime");
            //}

            //if (!initialCheck)
            //{
            //    for (int i = 2; i <= Math.Sqrt(userInput); i++)
            //    {
            //        if (userInput % i == 0)
            //        {
            //            //Console.WriteLine("Not a prime");
            //        }
            //        else
            //        {
            //            isPrime = true;
            //        }
            //    }
            //}

            //if (isPrime) {
            //    Console.WriteLine("Is a prime number");
            //}

            //9. Sum of digits (e.g., 123 → 1+2+3 = 6)
            //Console.Write("Enter a number to check if its a sum: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //int sumOfNumbers = 0;

            //while(userInput >= 1)
            //{
            //    int lastDigit = userInput % 10;
            //    sumOfNumbers = sumOfNumbers + lastDigit;
            //    userInput = userInput / 10;
            //}
            //Console.WriteLine(sumOfNumbers);

            //10. Multiplication table (user input: 5 → 5×1 … 5×10)
            //Console.Write("Enter a number to check if its a sum: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{userInput} * {i} = {userInput * i}");
            //}

            //11.Nested Loops – Patterns
            //   *
            //  **
            // ***
            //****
            //More Practise needed

            //12. Write a method to check if a string is a palindrome
            Console.Write("Enter a string to check if is a palindrome: ");
            string userInput = Console.ReadLine();

            bool checkPalindrome = IsPalindrome(userInput);
            Console.WriteLine(checkPalindrome ? "Is a palindrome" : "is not a palindrome");


        }

        public static bool IsPalindrome(string str)
        {
            string reversedString = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + str.ElementAt(i);
            }

            Console.WriteLine($"Reversed String is : {reversedString}");

            if(str == reversedString)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
