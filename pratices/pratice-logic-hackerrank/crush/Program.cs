
Result.arrayManipulation(5, [[1, 2, 100], [2, 5, 100], [3, 4, 100]]);
static class Result
{

    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<int>> queries)
    {

        long[] result = new long[n + 1];

        foreach (var list in queries)
        {
            int startIndex = list[0] - 1;
            int endIndex = list[1] - 1;
            int valueToAdd = list[2];

            result[startIndex] += valueToAdd;
            result[endIndex + 1] -= valueToAdd;
        }
        long maxValue = 0;
        long current = 0;

        for (int i = 0; i < result.Length; i++)
        {
            current += result[i];

            if (current > maxValue) maxValue = current;
        }

        return maxValue;
    }

}