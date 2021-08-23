using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 66, 81, 93, 75, 36 };
            Insertionsort obj = new Insertionsort();
            obj.sort(arr);
            obj.printArray(arr);
        }
    }
}
