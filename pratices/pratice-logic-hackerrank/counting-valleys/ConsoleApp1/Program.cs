class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int valleyCounter = 0;
        int value = 0;


        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'U')
            {
                value++;
            }
            if (path[i] == 'D')
            {
                value--;
            }
            if (i + 1 < path.Length)
            {
                if (value == -1 && path[i + 1] == 'U')
                {
                    valleyCounter++;
                }
            }
        }
        return valleyCounter;
    }

}