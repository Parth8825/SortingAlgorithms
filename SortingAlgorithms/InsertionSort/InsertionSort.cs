using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class InsertionSort
    {
        // insert Ith process method
        static void InsertIth(int[] a, int i)
        {
            int key = a[i];
            int j = i - 1;
            while(j>=0 && a[j] > key)
            {
                a[j+1] = a[j];
                j--;
            }

            a[j+1] = key;
        }

        // insertion sort method
        static void InsSort(int[] a, int size)
        {
            int i = 1;
            while(i < size)
            {
                InsertIth(a, i);
                i++; 
            }
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
            // Insertion sort uses the Key for sorting
            int[] arr = { 123, 225, 92, 465, 56, 150, 506, 60 };
            int size = arr.Length;

            Console.WriteLine("INSERTION SORT");
            Console.WriteLine("----------------");
            Console.WriteLine("Unsorted Array");
            Display(arr, size);

            Console.WriteLine("\nSorted Array");
            InsSort(arr, size);
            Display(arr, size);

            Console.ReadLine();
        }
    }
}
