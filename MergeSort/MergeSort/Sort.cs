using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class Sort
    {
        static public void DoMerge(string[] numbers, int left, int mid, int right)
        {
            string[] temp = new string[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) < 0)
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort(string[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
