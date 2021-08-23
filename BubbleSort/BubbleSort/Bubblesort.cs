using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class Bubblesort
    { 
        public void Sort(int[] Array)
            {
                int number;
                for (int i = 1; i < Array.Length; i++)
                {
                    number = Array[i];
                    int j = i - 1;
                    while (j >= 0 && Array[j].CompareTo(number) > 0)
                    {
                        Array[j + 1] = Array[j];
                        j--;
                    }
                    Array[j + 1] = number;
                }
            }
            public void Display(int[] Array)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }
    }
