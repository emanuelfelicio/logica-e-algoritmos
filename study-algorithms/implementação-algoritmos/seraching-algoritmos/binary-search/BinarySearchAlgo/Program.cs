
int[] array = new int[40];
Random random = new();

for (int i = 1; i < array.Length; i++)
{
    array[i] = random.Next(1, 200);
}

//adicionando valor a ser procurado
array[0] = 55;


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}\t{i}");
}

Console.WriteLine($" este é o index do valor:\t{BinarySearch(array, 55)}");



// retornar posição do valor no array
int BinarySearch(int[] arr, int value)
{
    Array.Sort(array);
    int baixo = 0;
    int alto = array.Length - 1;

    while (baixo <= alto)
    {
        int meio = (baixo + alto) / 2;
        int chute = arr[meio];

        if (chute == value)
        {
            return meio;
        }
        else if (chute < value)
        {
            baixo = meio + 1;
        }
        else
        {
            alto = meio - 1;
        }
    }
    return -1;
}

