using System.Numerics;

Result.workbook(5, 3, [4, 2, 6, 1, 10]);

static class Result
{

    /*
     * Complete the 'workbook' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY arr
     */

    public static int workbook(int n, int k, List<int> arr)
    {
        int currentPage = 1;
        int magicNumber = 0;

        for (int i = 0; i < n; i++)
        {

            int problems = arr[i];
            for (int startIndex = 1; startIndex <= problems; startIndex += k)
            {
                int endIndex = Math.Min(startIndex + k - 1, problems);

                if (currentPage >= startIndex && currentPage <= endIndex)
                {
                    magicNumber++;
                }

                currentPage++;
            }



        }
        return magicNumber;

    }
}