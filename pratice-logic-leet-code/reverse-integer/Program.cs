Solution solution = new();
solution.Reverse(-1534236469);
public class Solution
{
    public int Reverse(int x)
    {
        var result = 0;

        while (x != 0)
        {
            if (result > int.MaxValue / 10 || result < int.MinValue / 10)
            {
                return 0;
            }

            var remainder = x % 10;
            result = result * 10 + remainder;
            x /= 10;
        }

        return result;
    }
}