class Result
{

    /*
     * Complete the 'hurdleRace' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY height
     */

    public static int hurdleRace(int k, List<int> height)
    {
        int maxValue = 0;
        for (int i = 0; i < height.Count; i++)
        {
            if (maxValue < height[i])
            {
                maxValue = height[i];
            }
        }
        //
        if (k >= maxValue)
        {
            return 0;
        }
        else
        {
            return maxValue - k;
        }
    }

}