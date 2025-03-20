
class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int count = 0;
        for (int i = 0; i < ar.Count - 1; i++)
        {
            for (int j = i + 1; j < ar.Count; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

}
