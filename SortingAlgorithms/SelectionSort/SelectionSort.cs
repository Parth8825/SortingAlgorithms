using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class SelectionSort
    {
        // swaping mathod
        static void Swap(int[] a, int x, int y)
        {
            int temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }

        // location of smallest number
        static int LocOfSmallest(int[] a, int s, int e)
        {
            // s - starting point, e - ending point
            int i = s;
            int j = i;
            while (i <= e)
            {
                if (a[i] < a[j])
                {
                    j = i;
                }
                i = i + 1;
            }
            return j;
        }
        // selection sort method
        static void SelSort(int[] a, int size)
        {
            int i = 0;
            while (i < size - 1)
            {
                int j = LocOfSmallest(a, i, size - 1);
                Swap(a, i, j);
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
            // Selection Sort will find the sortest one and swap it first position and then second and so on
            // which makes LESS time to sort compared to Simple sorting.
            // Where Simple sort is comparing all the number one by one.
            // Selection sort will go Top to Bottom OR Left to Right
            int[] arr = { 123, 225, 92, 465, 56, 150, 506, 60 };
            int size = arr.Length;

            Console.WriteLine("SELECTION SORT");
            Console.WriteLine("----------------");
            Console.WriteLine("Unsorted Array");
            Display(arr, size);

            Console.WriteLine("\nSorted Array");
            SelSort(arr, size);
            Display(arr, size);

            Console.ReadLine();
        }
    }
}
