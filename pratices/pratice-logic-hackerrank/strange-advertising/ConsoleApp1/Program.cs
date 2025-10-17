class Result
{

    /*
     * Complete the 'viralAdvertising' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int viralAdvertising(int n)
    {

        int liked = 0;
        int shared = 5;

        for (int i = 1; i <= n; i++)
        {

            liked += shared / 2;
            shared = shared / 2 * 3;

        }
        return liked;
    }

}