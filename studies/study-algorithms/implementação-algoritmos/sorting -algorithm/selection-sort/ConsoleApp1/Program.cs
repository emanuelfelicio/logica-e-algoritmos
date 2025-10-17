int[] arr = [64, 15, 7, 3, 90, 3];

for (int i = 0; i < arr.Length - 1; i++)
{
    int current = arr[i];

    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] < current)
        {
            int auxiliar = arr[i];
            arr[i] = arr[j];
            arr[j] = auxiliar;
        }
    }
}

foreach (var i in arr)
{
    Console.WriteLine(i);
}