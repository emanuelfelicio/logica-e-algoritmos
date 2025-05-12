
class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m

     segmento deve ser consecutivo
     tamanho do meu segmento == m
     somas dos valores do meu segmento == d
     */
    public static int Birthday(List<int> s, int d, int m)
    {
        int possibilidade = 0;
        for (int i = 0; i <= s.Count - m; i++)
        {
            int count = 0;
            int test = 0;
            while (count < m)
            {
                test += s[i + count];
                count++;
            }
            if (test == d)
            {
                possibilidade++;
            }
        }
        return possibilidade;


    }

    public static int Birthday2(List<int> s, int d, int m)
    {
        int count = 0;

        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;

            for (int j = 0; j < m; j++)
            {
                sum += s[i + j];
            }

            if (sum == d)
            {
                count++;
            }
        }
        return count;
    }
}

