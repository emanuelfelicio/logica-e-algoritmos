using System;

class QuickSort
{
    public static void Sort(int[] array)
    {
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    private static void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortRecursive(array, low, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        // Escolha do pivô usando a Mediana de Três (reduz chance de pior caso)
        int pivot = MedianOfThree(array, low, high);
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        // Coloca o pivô na posição correta
        Swap(array, i + 1, high);
        return i + 1;
    }

    private static int MedianOfThree(int[] array, int low, int high)
    {
        int mid = low + (high - low) / 2;

        if (array[mid] < array[low]) Swap(array, mid, low);
        if (array[high] < array[low]) Swap(array, high, low);
        if (array[mid] < array[high]) Swap(array, mid, high);

        return array[high]; // Pivô escolhido é movido para o final
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    public static void Main()
    {
        int[] data = { 10, 7, 8, 9, 1, 5 };
        Console.WriteLine("Array original:");
        PrintArray(data);

        Sort(data);

        Console.WriteLine("Array ordenado:");
        PrintArray(data);
    }
}
