using System;

namespace LinealSearch
{
public class LinearSearch
    {
        public static int Buscar (int[] arr)
        {
            Console.Write("Ingrese el número que desea buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Entrada inválida.");
                return - 1;
            }

            int result = LinearSearchAlgo(arr, x);
            Console.WriteLine(result >= 0 ? $"El número {x} está en la posición {result}." : $"El número {x} no está en el arreglo.");
            return result;
        }

        private static int LinearSearchAlgo(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x) return i;
            return -1;
        }
    }
}

