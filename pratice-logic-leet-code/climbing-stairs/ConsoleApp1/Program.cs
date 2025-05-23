
Console.WriteLine(Solution.ClimbStairs(40));

public static class Solution
{
    public static int ClimbStairs(int n)
    {
        return Fibbonacci(n);
    }

    private static int Fibbonacci(int n, Dictionary<int, int> dict = null)
    {
        dict ??= new Dictionary<int, int>();

        if (n <= 1)
        {
            return 1;
        }
        if (dict.TryGetValue(n, out int value))
        {
            return value;
        }
        dict[n] = Fibbonacci(n - 1, dict) + Fibbonacci(n - 2, dict);
        return dict[n];
    }
}