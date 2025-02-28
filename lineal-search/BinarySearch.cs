using System;

namespace LinealSearch;

     public class BinarySearch
    {
        public static int Buscar(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Arreglo ordenado: " + string.Join(" ", arr));

            Console.Write("Ingrese el número que desea buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Entrada inválida.");
                return - 1;
            }

            int result = BinarySearchAlgo(arr, x);
            Console.WriteLine(result >= 0 ? $"El número {x} está en la posición {result}." : $"El número {x} no está en el arreglo.");
            return result;
        }

        private static int BinarySearchAlgo(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == x) return mid;
                if (arr[mid] < x) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }
    }


