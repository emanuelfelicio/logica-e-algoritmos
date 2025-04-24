
class Result
{

    /*
     * Complete the 'utopianTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int utopianTree(int n)
    {
        int altura = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                altura++;
            }
            if (i % 2 == 1)
            {
                altura *= 2;
            }
        }
        return altura;
    }




}


