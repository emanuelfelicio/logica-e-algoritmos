using System.Numerics;

class Result
{
    public static void extraLongFactorials(int n)
    {
        BigInteger number = n;
        for (int i = n - 1; i >= 2; i--)
        {
            number *= i;
        }
        Console.WriteLine(number.ToString());
    }

}

