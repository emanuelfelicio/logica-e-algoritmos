class Result
{

    /*
     * Complete the 'organizingContainers' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts 2D_INTEGER_ARRAY container as parameter.
     */

    public static string organizingContainers(List<List<int>> container)
    {
        int n = container.Count;
        long[] containerCapacity = new long[n];
        long[] typeCount = new long[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                containerCapacity[i] += container[i][j]; // soma da linha
                typeCount[j] += container[i][j];         // soma da coluna
            }
        }

        Array.Sort(containerCapacity);
        Array.Sort(typeCount);

        for (int i = 0; i < n; i++)
        {
            if (containerCapacity[i] != typeCount[i])
            {
                return "Impossible";
            }
        }

        return "Possible";
    }
}

