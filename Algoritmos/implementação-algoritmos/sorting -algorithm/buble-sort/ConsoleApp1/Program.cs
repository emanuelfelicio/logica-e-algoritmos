using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool trocou;

        for (int i = 0; i < n - 1; i++)
        {
            trocou = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Troca os elementos
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    trocou = true;
                }
            }
            // Se não houve trocas, a lista já está ordenada
            if (!trocou) break;
        }
    }

    static void Main()
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        Console.WriteLine("Array antes do Bubble Sort: " + string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("Array depois do Bubble Sort: " + string.Join(", ", arr));
    }
}
