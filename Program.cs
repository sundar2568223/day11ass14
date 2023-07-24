using System;
using System.Diagnostics;

namespace Assignment14
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Bubblesort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static int[] generateArray(int count)
        {
            Random random = new Random();
            int[] values = new int[count];

            for (int i = 0; i < count; ++i)
                values[i] = random.Next(1, 1000);

            return values;
        }
        static void Main(string[] args)
        {
            int[] arr = generateArray(10);
            int[] arr1 = generateArray(10);
            Console.WriteLine("Array of elements before Bubble sort");
            Stopwatch sw = new Stopwatch();
            Print(arr);
            sw.Start();
            Bubblesort(arr);
            sw.Stop();
            Console.WriteLine("Array of elements After Bubble sort");
            Print(arr);
            Console.WriteLine($"Arraysize {arr.Length} Time taken {sw.Elapsed.TotalMilliseconds} milli seconds(For bubble sort)");

            //Insertion Sort

            Console.WriteLine("Array of elements before Insertion sort");
            Stopwatch sw1 = new Stopwatch();
            Print(arr1);
            sw1.Start();
            InsertionSort(arr1);
            sw1.Stop();
            Console.WriteLine("Array of elements After Insertion sort");
            Print(arr1);
            Console.WriteLine($"Arraysize {arr1.Length} Time taken {sw1.Elapsed.TotalMilliseconds} milli seconds(for Insertion Sort)");
            Console.ReadKey();
        }
    }
}
