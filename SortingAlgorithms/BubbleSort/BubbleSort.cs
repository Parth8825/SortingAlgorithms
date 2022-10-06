using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class BubbleSort
    {
        // swaping mathod
        static void Swap(int[] a, int x, int y)
        {
            int temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }

        // bubble process method
        static void Bubble(int[] a, int size)
        {
            int i = size - 1;
            while(i > 0)
            {
                if (a[i] < a[i - 1])
                {
                    Swap(a, i, i-1);
                }
                i--;
            }
        }

        // bubble sort method
        static void BBLSort(int[] a, int size)
        {
            int i = 0;  
            while(i < size - 1)
            {
                Bubble(a, size);
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
            // Bubble sort is similar to the Selection sort but it will go Bottom to Top OR Right to Left
            int[] arr = { 123, 225, 92, 465, 56, 150, 506, 60 };
            int size = arr.Length;

            Console.WriteLine("BUBBLE SORT");
            Console.WriteLine("----------------");
            Console.WriteLine("Unsorted Array");
            Display(arr, size);

            Console.WriteLine("\nSorted Array");
            BBLSort(arr, size);
            Display(arr, size);

            Console.ReadLine();
        }
    }
}
