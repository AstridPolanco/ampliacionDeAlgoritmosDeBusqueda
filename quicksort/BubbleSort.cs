using System;

namespace QuickSorte
{
    public class BubbleSort
    {
        public static void Ordenar(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Intercambio
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //Console.WriteLine("Array ordenado usando Bubble Sort:");
            //Console.WriteLine(string.Join(" ", arr));
        }
    }
}

