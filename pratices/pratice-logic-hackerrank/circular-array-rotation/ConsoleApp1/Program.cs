
using System.Security.Cryptography.X509Certificates;

Console.WriteLine(3%5);
class Result
{

    /*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {

        int n = a.Count;
        int[] result = new int [n];


        if (k > n)
        {
            int resto = k % n;
            if (resto == 0)
            {
                k = n;
            }
            else
            {
                k = resto;
            }
        }

        for (int i = 0; i < a.Count; i++)
        {
            if (i + k >= n)
            {
                int posicao = i + k - n ;
                result[posicao] = a[i];
            }
            else
            {
                result[i+k] = a[i];
            }
        }

        for (int i = 0; i < queries.Count; i++)
        {
            queries[i] = result [queries[i]];
        }

        return queries;


    }

}