using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class Range
    {
        public void PrimeNumbers()
        {
            for (int i = 0; i <= 1000; i++)
            {
              for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                     break;
                    }
                    else
                    {
                        Console.Write("The prime numbers are : "+ i +"\n");
                        break;
                    }
                    
                }
            }
        }
    }
}

