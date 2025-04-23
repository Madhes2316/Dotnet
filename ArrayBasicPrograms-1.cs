using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = {"Tesla", "Audi","BMW"};

            //for(int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //1.Create array of 5 numbers
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i}.{numbers[i]}");
            //}

            //2.track a max variable.
            //int[] numbers = { 3, 7, 2, 9, 4,10,21,1,10,5,16,6 };
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if(numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);

            //3.Array : BubbleSort 

            int[] arr = { 9, 1, 4, 6, 8, 3, 5, 7, 2 };

            int[] sortedArray = BubbleSort(arr);

            for(int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }


        }

        public static int[] BubbleSort(int[] arr)
        {
           
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
