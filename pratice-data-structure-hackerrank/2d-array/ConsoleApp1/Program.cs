
List<List<int>> matriz = new List<List<int>>
        {
            new List<int> { 12, 45, 78, 23, 56, 89 },
            new List<int> { 34, 67, 90, 12, 43, 76 },
            new List<int> { 98, 21, 65, 87, 33, 49 },
            new List<int> { 15, 26, 37, 48, 59, 60 },
            new List<int> { 70, 81, 92, 13, 24, 35 },
            new List<int> { 46, 57, 68, 79, 80, 91 }
        };

Result.hourglassSum(matriz);
class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        int higherSum = -9 * 7;

        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                if (sum > higherSum)
                {
                    higherSum = sum;
                }
            }
        }

        return higherSum;
    }

}