Result.sockMerchant(5,[0,1,2,1,2]);

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> pairs = new();
        int pairNumbers = 0;
        for (int i = 0; i < n; i++)
        {
            if (pairs.TryGetValue(ar[i], out int value))
            {
                value++;
                pairs[ar[i]] = value;
            }
            else
            {
                pairs.Add(ar[i], 1);
            }
        }

        foreach (var item in pairs)
        {
            pairNumbers += item.Value / 2;
        }

        return pairNumbers;
    }

}