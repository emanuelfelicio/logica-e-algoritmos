class Result
{

    /*
     * Complete the 'reverseArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static List<int> reverseArray(List<int> a)
    {
        for (int i = 0; i < a.Count / 2; i++)
        {
            (a[i], a[a.Count - 1 - i]) = (a[a.Count - 1 - i], a[i]);
        }

        return a;
    }

}