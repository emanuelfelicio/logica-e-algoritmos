/*
    recebo uma lista com tamanho = 5
    devo retornar a maior soma de 4 valores e a menor soma de 4 valores
    1°) ordernar a lista
    2°) somar os 4 primeiro e atribuir a variavel min
    3°) somar os 4 ultimos e atribus a variavel max
    4°) retorna os valores.
*/


static void miniMaxSum(List<int> arr)
{
    arr.Sort();
    long max = 0;
    long min = 0;
    int n = arr.Count;
    for (int i = 0; i < 4; i++)
    {
        min += arr[i];
    }

    for (int i = n - 1; i >= n - 4; i--)
    {
        max += arr[i];
    }
    Console.WriteLine($"{min} {max}");
}