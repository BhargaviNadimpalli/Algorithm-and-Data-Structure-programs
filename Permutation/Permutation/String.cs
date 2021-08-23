using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    public class String
    {
        public static void PermuteRecursive(string str, int startPosition, int endPosition)
        {
            if (startPosition == endPosition)
                Console.WriteLine(str);
            else
            {
                for (int i = startPosition; i <= endPosition; i++)
                {
                    str = Swap(str, 0, i);
                    PermuteRecursive(str, startPosition + 1, endPosition);
                    str = Swap(str, startPosition, i);
                }
            }
        }
        private static string Swap(string str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}

