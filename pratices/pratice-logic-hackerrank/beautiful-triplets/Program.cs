class Result
{

    /*
     * Complete the 'beautifulTriplets' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static int beautifulTriplets(int d, List<int> arr)
    {

        // brute force O(n^3)

        // int count = 0;
        // for (int i = 0; i < arr.Count - 2; i++)
        // {
        //     for (int j = i + 1; j < arr.Count - 1; j++)
        //     {
        //         if (arr[j] - arr[i] == d)
        //         {
        //             for (int k = j + 1; k < arr.Count; k++)
        //             {
        //                 if (arr[k] - arr[j] == d)
        //                 {
        //                     count++;
        //                     break;
        //                 }
        //             }
        //         }
        //     }
        // }

        //O(N) usando HashSet
        int count = 0;
        HashSet<int> values = [.. arr];

        foreach (int num in arr)
        {
            if (values.Contains(num + d) && values.Contains(num + 2 * d))
            {
                count++;
            }
        }



        return count;
    }

}