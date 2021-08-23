using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "arun", "bhargavi", "chandra", "durga", "esha", "ganesh", "harika", "preethi", "manideep" };
            int len = 9;

            Console.WriteLine("MergeSort By Recursive Method");
            Sort.MergeSort(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);
        }
    }
}
