
Result.saveThePrisoner(7, 19, 2);
class Result
{

    /*
     * Complete the 'saveThePrisoner' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     *  3. INTEGER s
     */

    public static int saveThePrisoner(int n, int m, int s)
    {
        return (m + s - 2) % n + 1;
    }

}