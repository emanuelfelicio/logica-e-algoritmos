class Result
{

    /*
     * Complete the 'nonDivisibleSubset' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY s
     */

    public static int nonDivisibleSubset(int k, List<int> s)
    {

        int[] restoContagem = new int[k];

        foreach (int numero in s)
        {
            int resto = numero % k;
            restoContagem[resto]++;
        }

        int tamanhoSubconjunto = 0;


        if (restoContagem[0] > 0)
        {
            tamanhoSubconjunto += 1;
        }


        for (int i = 1; i < k; i++)
        {
            int oposto = k - i;


            if (i > oposto)
            {

                continue;
            }


            if (i == oposto)
            {
                if (restoContagem[i] > 0)
                {
                    tamanhoSubconjunto += 1;
                }
            }
            else
            {

                int maisNumeroso = Math.Max(restoContagem[i], restoContagem[oposto]);
                tamanhoSubconjunto += maisNumeroso;
            }
        }

        return tamanhoSubconjunto;


    }

}