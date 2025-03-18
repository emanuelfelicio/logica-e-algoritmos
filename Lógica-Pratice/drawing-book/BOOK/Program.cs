

Result.pageCount(6, 2);
class Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {

        double comeco = Math.Ceiling((p - 1) / 2.0);
        double fim = n % 2 != 0 ? Math.Floor((n - p) / 2.0) : Math.Ceiling((n - p) / 2.0);

        if (comeco <= fim)
        {
            return (int)comeco;
        }
        else
        {
            return (int)fim;
        }

    }

}