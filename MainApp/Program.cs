using System;
using System.Linq;
using LinealSearch;    // Para acceder a Búsqueda Lineal y Búsqueda Binaria
using QuickSorte;    // Para acceder a QuickSort y BubbleSort

class Program
{
    static void Main()
    {
        int[] arr = null; // Arreglo que permanecerá en memoria
        bool salir = false;

        while (!salir)
        {
            Console.Clear();

            // Mostrar el arreglo actual siempre que esté definido
            if (arr != null && arr.Length > 0)
            {
                MostrarArreglo(arr);
            }
            else
            {
                Console.WriteLine("Aún no se ha ingresado un arreglo.");
            }


            Console.WriteLine("===== MENÚ DE ALGORITMOS DE ORDENAMIENTO Y BÚSQUEDA =====");
            Console.WriteLine("1. Ingresar o cambiar arreglo");
            Console.WriteLine("2. Búsqueda Lineal");
            Console.WriteLine("3. Búsqueda Binaria");
            Console.WriteLine("4. Ordenamiento por Bubble Sort");
            Console.WriteLine("5. Ordenamiento por Quick Sort");
            Console.WriteLine("6. Mostrar arreglo actual");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 0 || opcion > 6)
            {
                Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 0:
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                case 1:
                    arr = LeerArregloDesdeConsola();
                    Console.WriteLine("Arreglo guardado exitosamente");
                    break;

                case 2:
                    if (ValidarArreglo(arr))
                    {
                        Console.WriteLine("Has seleccionado Búsqueda Lineal.");
                        EjecutarBusquedaLineal(arr);
                    }
                    break;

                case 3:
                    if (ValidarArreglo(arr))
                    {
                        Console.WriteLine("Has seleccionado Búsqueda Binaria.");
                        EjecutarBusquedaBinaria(arr);
                    }
                    break;

                case 4:
                    if (ValidarArreglo(arr))
                    {
                        Console.WriteLine("Has seleccionado Bubble Sort.");
                        EjecutarBubbleSort(arr);
                    }
                    break;

                case 5:
                    if (ValidarArreglo(arr))
                    {
                        Console.WriteLine("Has seleccionado Quick Sort.");
                        EjecutarQuickSort(arr, 0, arr.Length - 1);
                    }
                    break;

                case 6:
                    if (ValidarArreglo(arr))
                    {
                        MostrarArreglo(arr);
                    }
                    break;
            }

            if (!salir)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    // Método para leer el arreglo desde la consola
    static int[] LeerArregloDesdeConsola()
{
    while (true)
    {
        Console.Write("Ingrese los elementos del arreglo separados por espacios: ");
        string? input = Console.ReadLine();
        
        // Dividir la entrada en elementos individuales
        string[] inputs = (input ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        // Validar que todos los elementos sean números
        bool valid = true;
        foreach (string item in inputs)
        {
            if (!int.TryParse(item, out _))
            {
                valid = false;
                break;
            }
        }
        
        // Si hay algún valor no numérico, mostrar mensaje de error
        if (!valid)
        {
            Console.WriteLine("Error: Todos los elementos deben ser números enteros. Intente de nuevo.");
            continue; // Volver a pedir la entrada
        }

        // Convertir la entrada válida en un arreglo de enteros
        return inputs.Select(int.Parse).ToArray();
    }
}

    // Método para validar si el arreglo está listo para usarse
    static bool ValidarArreglo(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Error: Primero debe ingresar un arreglo (Opción 1).");
            return false;
        }
        return true;
    }

    // Método para mostrar el arreglo actual
    static void MostrarArreglo(int[] arr)
    {
        Console.WriteLine("Arreglo actual: " + string.Join(" ", arr));
    }

    // Métodos para ejecutar los algoritmos
    static void EjecutarBusquedaLineal(int[] arr)
    {
        int result = LinearSearch.Buscar(arr);
    }

    static void EjecutarBusquedaBinaria(int[] arr)
    {
        int result = BinarySearch.Buscar(arr);
    }

    static void EjecutarBubbleSort(int[] arr)
    {
        int[] copia = (int[])arr.Clone(); // Clonar para no modificar el original
        BubbleSort.Ordenar(copia);
        Console.WriteLine("Array ordenado con Bubble Sort: " + string.Join(" ", copia));
    }

    static void EjecutarQuickSort(int[] arr, int low, int high)
    {
        int[] copia = (int[])arr.Clone(); // Clonar para no modificar el original
        QuickSort.QuickSortAlgo(copia, low, high);
        Console.WriteLine("Array ordenado con Quick Sort: " + string.Join(" ", copia));
    }
}


