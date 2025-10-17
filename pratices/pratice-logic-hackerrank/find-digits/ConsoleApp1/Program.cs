class Result
{

    /*
     * Complete the 'findDigits' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int findDigits(int n)
    {
        int num = n;
        int count = 0;
        while (num > 0)
        {
            int digit = num % 10;
            if (digit > 0)
            {
                if (n % digit == 0)
                {
                    count++;
                }
                
            }
            num /= 10;
        }
        return count;
    }

}