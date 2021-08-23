using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort Problem");
            int[] arr = { 21, 37, 15, 54, 52, 24, 76 };
            Bubblesort sort = new Bubblesort();
            sort.Sort(arr);
            sort.Display(arr);

        }
    }
}
