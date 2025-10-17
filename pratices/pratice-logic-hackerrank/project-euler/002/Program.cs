class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            FibbonaciEvenSum(n);
        }
    }

    private static void FibbonaciEvenSum(long n)
    {
        long sum = 0;
        long first = 1;
        long last = 2;
        while (last <= n)
        {
            if (last % 2 == 0)
            {
                sum += last;
            }

            long temp = last;
            last += first;
            first = temp;
        }
        Console.WriteLine(sum);
    }


}