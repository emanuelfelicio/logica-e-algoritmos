
using System.Diagnostics;

Console.WriteLine(Fibonacci.LoopFibonacci(3));

static class Fibonacci
{
    public static long RecursionFibonacci(uint n, Dictionary<uint, long> memo = null)
    {
        memo ??= [];

        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }

        if (memo.TryGetValue(n, out var value))
        {
            return value;
        }

        return memo[n] = RecursionFibonacci(n - 1, memo) + RecursionFibonacci(n - 2, memo);

    }

    public static long LoopFibonacci(uint n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        long prev = 0;
        long curr = 1;

        for (uint i = 2; i <= n; i++)
        {
            long next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr;
    }

}