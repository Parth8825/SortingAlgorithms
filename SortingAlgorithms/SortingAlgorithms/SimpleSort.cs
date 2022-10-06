using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSort
{
    internal class SimpleSort
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[100];

            Console.Write("Enter the number N: ");
            n = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(1, 10);
            }

            // unsorted output
            Console.WriteLine("Unsorted Array");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // sorting an array
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // ascending order
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // sorted output
            Console.WriteLine("\nSorted Array (Ascending)");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // sorting an array
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // descending order
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            // sorted output
            Console.WriteLine("\nSorted Array (Descending)");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
