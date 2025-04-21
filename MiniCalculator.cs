using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool userExited = false;
                while (!userExited) {
                    Console.Write("Please Enter the first number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please Enter the second number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the operation symbol you want to perform(+,-,*,/) or enter e to exit: ");
                    char operation = Convert.ToChar(Console.ReadLine());
                    bool wrongOperationChar = false;
                    
                    while(!wrongOperationChar) {
                        switch (operation)
                        {
                            case '+':
                                Console.WriteLine($"Sum of the 2 numbers: {Add(num1, num2)}");
                                wrongOperationChar = true;
                                break;
                            case '-':
                                Console.WriteLine($"Difference of the 2 numbers: {Subtract(num1, num2)}");
                                wrongOperationChar = true;
                                break;
                            case '*':
                                Console.WriteLine($"Multiplication of the 2 numbers: {Multiply(num1, num2)}");
                                wrongOperationChar = true;
                                break;
                            case '/':
                                Console.WriteLine($"Division of the 2 numbers: {Divide(num1, num2)}");
                                wrongOperationChar = true;
                                break;
                            case 'e':
                                userExited = true;
                                wrongOperationChar = true;
                                break;
                            default:
                                Console.WriteLine("Invalid key entered,please try again!");
                                wrongOperationChar = false;
                                Console.Write("Please enter the correct operation symbol you want to perform(+,-,*,/) or enter e to exit: ");
                                operation = Convert.ToChar(Console.ReadLine());
                                break;
                        }

                    }
                }
            }
            catch(Exception e) {
                Console.WriteLine("Something went wrong");
            }
        }

        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
