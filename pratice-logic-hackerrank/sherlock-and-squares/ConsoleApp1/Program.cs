class Result
{

    /*
     * Complete the 'squares' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER a
     *  2. INTEGER b
     */

    public static int squares(int a, int b)
    {
        int sqrtA = (int)Math.Ceiling(Math.Sqrt(a));
        int sqrtB = (int)Math.Floor(Math.Sqrt(b));
        return sqrtB - sqrtA + 1;

    }

}
