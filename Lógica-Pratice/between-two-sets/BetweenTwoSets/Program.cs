class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int ans = 0;

        int maxNum = a.Max();
        int minNum = b.Min();

        for (int i = maxNum; i <= minNum; i++)
        {
            int count1 = 0;
            int count2 = 0;

            foreach (int j in a)
            {
                if (i % j == 0)
                {
                    count1++;
                }
            }

            foreach (int k in b)
            {
                if (k % i == 0)
                {
                    count2++;
                }
            }

            if (count1 == a.Count && count2 == b.Count)
            {
                ans++;
            }
        }

        return ans;
    }

}