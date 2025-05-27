Console.WriteLine(Solution.MySqrt(15));

public static class Solution
{
    public static int MySqrt(int x)
    {
        if (x < 2)
            return x;

        int left = 1, right = x / 2;
        while (left <= right)
        {
            // poderia-se calculcar da seguinte maneira : (left + right)/2
            // mas left + (right - left) / 2  : reduz a chance de estouro do inteiro.
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            if (square == x)
                return mid;
            if (square < x)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return right;
    }
}