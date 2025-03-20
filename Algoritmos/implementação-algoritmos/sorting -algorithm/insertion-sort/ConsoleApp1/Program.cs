using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int chave = arr[i];
            int j = i - 1;

            // Move os elementos maiores que a chave uma posição à frente
            while (j >= 0 && arr[j] > chave)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = chave;
        }
    }

    static void Main()
    {
        int[] numeros = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Array antes da ordenação: " + string.Join(", ", numeros));

        InsertionSort(numeros);

        Console.WriteLine("Array após a ordenação: " + string.Join(", ", numeros));
    }
}
