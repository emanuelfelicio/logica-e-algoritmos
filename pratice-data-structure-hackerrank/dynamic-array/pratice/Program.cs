class Result
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new(n);
        for (int i = 0; i < n; i++)
        {
            arr.Add([]);
        }
        List<int> answers = new();
        int lastAnswer = 0;
        foreach (var querie in queries)
        {

            int type = querie[0];
            int x = querie[1];
            int y = querie[2];
            int idx = (x ^ lastAnswer) % n;
            if (type == 1)
            {
                arr[idx].Add(y);
            }
            else
            {

                int size = arr[idx].Count;
                lastAnswer = arr[idx][y % size];
                answers.Add(lastAnswer);
            }
        }
        return answers;

    }

}
