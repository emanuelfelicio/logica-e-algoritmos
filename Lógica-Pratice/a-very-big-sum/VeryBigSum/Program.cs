 // retornar soma dos valores de uma lista

 static long aVeryBigSum(List<long> ar)
{
    long sum = 0;
    for (int i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }
    
    return sum;
}