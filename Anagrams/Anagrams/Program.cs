using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramWord word = new AnagramWord();
            word.Anagram("angel", "gelan");
        }
    }
}
