int[] array = new int[40];
Random random = new();

for (int i = 1; i < array.Length; i++)
{
    array[i] = random.Next(1, 50);
}


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}\t{i}");
}

Console.WriteLine($" este é o index do valor:\t{LinearSearch(array, 20)}");

//busca linear
static int LinearSearch(int[] arr, int item)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == item)
        {
            return i;
        }
    }
    return -1;
}