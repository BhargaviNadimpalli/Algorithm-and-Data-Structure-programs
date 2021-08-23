using System;
using System.Collections.Generic;

namespace RefactorPrimeAnagramUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Anagram.StringAnagram();
            List<int> list = PrimeRange.FindPrime();
            PrimeRange.Print(list);
            AnagramPrimePalindrome anagramAndPalindrome = new AnagramPrimePalindrome();
            anagramAndPalindrome.CheckPrimeAnagramAndPalindrome();
        }
    }
}
