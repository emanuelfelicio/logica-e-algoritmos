

int t = Convert.ToInt32(Console.ReadLine());
long[] primePrefixSum = BuildPrimePrefixSum(2000000);
for (int a0 = 0; a0 < t; a0++)
{

    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(primePrefixSum[n]);
}

static long[] BuildPrimePrefixSum(int limit)
{
    bool[] isPrime = new bool[limit + 1];
    for (int i = 2; i <= limit; i++) isPrime[i] = true;

    for (int i = 2; i * i <= limit; i++)
    {
        if (isPrime[i])
        {
            for (int j = i * i; j <= limit; j += i)
            {
                isPrime[j] = false;
            }
        }
    }

    long[] prefixSum = new long[limit + 1];
    long sum = 0;
    for (int i = 2; i <= limit; i++)
    {
        if (isPrime[i]) sum += i;
        prefixSum[i] = sum;
    }

    return prefixSum;
}
