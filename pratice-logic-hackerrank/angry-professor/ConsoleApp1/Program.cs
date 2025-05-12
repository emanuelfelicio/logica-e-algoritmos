


class Result
{

    /*
     * Complete the 'angryProfessor' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY a
     */

    public static string angryProfessor(int k, List<int> a)
    {
        int count = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] <= 0)
            {
                count++;
            }
        }
        if (count < k)
        {
            return "YES";
        }
        return "NO";


    }

}