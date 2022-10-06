using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class MergeSort
    {
        // method that combines sorted divided array 
        static void Combine(int[] a, int s, int m, int e)
        {
            // s - start value, e - end value, m - mid point
            int[] buffer = new int[e + 1]; // for the total size of the merged array

            int key = s;
            while(key <= e)
            {
                buffer[key] = a[key];
                key++;
            }

            int i = s;
            int j = m + 1;
            key = s;

            while(i <= m && j <= e)
            {
                if(buffer[i] <= buffer[j])
                {
                    a[key] = buffer[i];
                    i++;
                }
                else
                {
                    a[key] = buffer[j];
                    j++;
                }
                key++;
            }

            while(i <= m)
            {
                a[key] = buffer[i];
                i++;
                key++;
            }
            while(j <= e)
            {
                a[key] = buffer[j];
                j++;
                key++;
            }
            Array.Clear(buffer, 0, buffer.Length); // delete buffer
        }

        // auxiliary method (helper method) || Overloading Method
        static void MrgSort(int[] a, int s, int e)
        {
            // s - start value, e - end value, m - mid point
            if (s >= e)
            {
                return;
            }

            int m = (s + e) / 2;
            MrgSort(a, s, m);
            MrgSort(a, m+1, e);
            Combine(a, s, m, e);
        }

        // This is a wrapper method
        static void MrgSort(int[] a, int size)
        {
            MrgSort(a, 0, size - 1);
        }

        // display method
        static void Display(int[] a, int size)
        {
            int i = 0;
            while (i < size)
            {
                Console.Write(a[i] + " ");
                i++;
            }
        }

        static void Main(string[] args)
        {
            // Merge sort divides an array equally and sort it.
            // Merge sort is the fastest algorithm than any other sorting algorithm
            // Its doing time complexity as o(nlog(n))
            int[] arr = { 123, 225, 92, 465, 56, 150, 506, 60 };
            int size = arr.Length;

            Console.WriteLine("MERGE SORT");
            Console.WriteLine("----------------");
            Console.WriteLine("Unsorted Array");
            Display(arr, size);

            Console.WriteLine("\nSorted Array");
            MrgSort(arr, size);
            Display(arr, size);

            Console.ReadLine();
        }
    }
}
