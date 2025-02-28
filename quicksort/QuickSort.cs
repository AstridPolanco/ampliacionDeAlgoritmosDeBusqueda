using System;

namespace QuickSorte{
    public static class QuickSort
    {
        // Método público para ordenar el arreglo
        public static void QuickSortAlgo(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Obtener el índice de partición
                int pi = Particionar(arr, low, high);
                Console.WriteLine($"Pivote seleccionado: {arr[pi]} en la posición {pi}");
                Console.WriteLine("Estado del array después de la partición:");
                PrintArray(arr);

                // Ordenar recursivamente los elementos antes y después de la partición
                QuickSortAlgo(arr, low, pi - 1);
                QuickSortAlgo(arr, pi + 1, high);
            }
        }

        // Método privado para particionar el arreglo
        public static int Particionar(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Seleccionar el último elemento como pivote
             Console.WriteLine($"\nIniciando partición con pivote {pivot} en la posición {high}");
            int i = (low - 1); // Índice del elemento más pequeño

            for (int j = low; j < high; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (arr[j] <= pivot)
                {
                    i++; // Incrementar el índice del elemento más pequeño
                    Intercambiar(arr, i, j); // Intercambiar arr[i] y arr[j]
                     Console.WriteLine($"Intercambio: {arr[i]} <-> {arr[j]}");
                    PrintArray(arr);
                }
            }

            // Intercambiar el pivote con el elemento en la posición correcta
            Intercambiar(arr, i + 1, high);
            Console.WriteLine($"Colocando pivote {arr[i + 1]} en su posición final:");
            PrintArray(arr);
            return i + 1; // Retornar el índice de partición
        }

        // Método para intercambiar dos elementos en el arreglo
        public static void Intercambiar(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // Método para imprimir el arreglo (opcional)
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
