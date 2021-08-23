using System;
using static HashingFunction.Hashing;

namespace HashingFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashingSlots<string> hashtable = new HashingSlots<string>();
           hashtable.CheckNumber();
        }
    }
}
