using System;

namespace BankingCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Banking<string> banking = new Banking<string>();
            banking.CashCounter();
        }
    }
}
