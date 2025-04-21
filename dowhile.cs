using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            do
            {
                Console.Write("Please enter a number: ");
                int userNum = Convert.ToInt32(Console.ReadLine());
                if(userNum > 0)
                {
                    sum = sum + userNum;
                }
                number++;
                Console.WriteLine("Sum of nums till now:" + sum);
            }
            while (number > 0);
        }
    }
}
