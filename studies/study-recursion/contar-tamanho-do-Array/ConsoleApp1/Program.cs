int[] numeros = [1,2,3,4,5,6,7,8,9,10];

Console.WriteLine(ContarArray(numeros));

static int ContarArray(int[] numeros, int index = 0)
{
    if (index == numeros.Length)
    {
        return 0;
    }

    int count = 1;

    return count + ContarArray(numeros, index + 1);
}