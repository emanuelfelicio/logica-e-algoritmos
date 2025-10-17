Result.rotateLeft(2, [1, 2, 3, 4]);
class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {

        int n = arr.Count;
        d %= n;

        List<int> result = [.. arr];

        for (int i = 0; i < n - d; i++)
        {
            result[i] = arr[i + d];
        }

        for (int i = 0; i < d; i++)
        {
            result[n - d + i] = arr[i];
        }

        return result;

    }

}
