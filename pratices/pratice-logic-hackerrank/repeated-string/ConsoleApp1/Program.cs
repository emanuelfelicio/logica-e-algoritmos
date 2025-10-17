class Result
{
    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        long countAInS = 0;


        foreach (char c in s)
        {
            if (c == 'a') countAInS++;
        }

        long fullRepeats = n / s.Length;
        long remainder = n % s.Length;
        long totalA = fullRepeats * countAInS;


        for (int i = 0; i < remainder; i++)
        {
            if (s[i] == 'a') totalA++;
        }

        return totalA;
    }
}
