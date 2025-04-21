using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x; //declaration
            //x = 10; //initialization
            //Console.WriteLine(x);

            //int y = 20; //declare + initialize
            //Console.WriteLine(y);

            //int z = x + y;
            //Console.WriteLine("Your age is : "+z);

            //double a = 3.14;
            //Console.WriteLine(a);

            //bool b = true;
            //Console.WriteLine(b);

            //char symbol = ')';
            //Console.WriteLine(symbol);

            //string name = "Madhes";
            //Console.WriteLine(name);


            ////Type Conversion
            ////1.Implicit
            //int num = 10;
            //char ch = 'A';
            //int add = num + ch;
            //Console.WriteLine(add);

            ////Casting
            ////Implicit
            //int myNum = 5;
            //float myFloat = myNum;
            //Console.WriteLine(myFloat);

            ////Explicit
            //int myNum1 = (int)3.4f;
            //Console.WriteLine(myNum1);

            ////NonExisted Conversion
            //string data = "1000";
            ////int numData = data;
            ////int Stringnum = (int)data;

            ////Convert
            //int convertedNum = Convert.ToInt32("1000");
            //Console.WriteLine(convertedNum);

            ////Parse
            //int number = int.Parse("aaa");
            //Console.WriteLine(number);

            string name = "Madhes";
            int pin = 1234;
            bool Cont = true;
            int initialBalance = 50000;
            Console.WriteLine($"Welcome {name}");
            int pinAttempt = 0;

            while (Cont)
            {
                try
                {
                    Console.WriteLine("Please enter your 4 digit PIN number");
                    int userPINValue = Convert.ToInt32(Console.ReadLine());
                    bool isUserExited = false;
                    if (pin == userPINValue && pinAttempt <= 3)
                    {
                        while (!isUserExited)
                        {
                            Console.WriteLine("Menu: ");
                            Console.WriteLine($"1.Check balance");
                            Console.WriteLine($"2.Deposit money");
                            Console.WriteLine($"3.Withdraw money");
                            Console.WriteLine($"4.Exit");
                            int userMenuChoice = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (userMenuChoice == 1)
                                {
                                    Console.WriteLine($"Amount available in your account: {initialBalance}");
                                }
                                else if (userMenuChoice == 2)
                                {
                                    Console.WriteLine("Enter the money you want to deposit: ");
                                    int depoMoney = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Total balance after deposit {initialBalance + depoMoney}");
                                    initialBalance = initialBalance + depoMoney;
                                }
                                else if (userMenuChoice == 3)
                                {
                                    const int tooLow = 3000;
                                    Console.WriteLine("Enter the money you want to withdraw: ");
                                    int withDrawMoney = Convert.ToInt32(Console.ReadLine());
                                    if (withDrawMoney <= initialBalance && (initialBalance - withDrawMoney) > tooLow)
                                    {
                                        Console.WriteLine($"Total balance after withdrawing {initialBalance - withDrawMoney}");
                                        initialBalance = initialBalance - withDrawMoney;
                                    }
                                    else if((initialBalance - withDrawMoney) <= tooLow)
                                    {
                                        Console.WriteLine("You should keep some minimum balance");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Withdraw money cannot be greater than Balance money");
                                    }
                                }
                                else if (userMenuChoice == 4)
                                {
                                    Cont = false;
                                    isUserExited = true;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid menu option");
                                }
                            }
                            catch (Exception ex) {
                                Console.WriteLine("Something went wrong");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong Pin,Please enter the correct PIN");
                        pinAttempt++;
                        if (pinAttempt == 3)
                        {
                            throw new Exception("Three failed attempts,Please retry after sometime");
                        }
                    }
                }
                catch(Exception ex) {
                    Console.WriteLine("Please enter a valid PIN number");
                    Console.WriteLine("------------------------------------");
                    if (pinAttempt == 3)
                    {
                        throw new Exception("Three failed attempts,Please retry after sometime");
                    }
                }
            }

  
        }
    }
}
