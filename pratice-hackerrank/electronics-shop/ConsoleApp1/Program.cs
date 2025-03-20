class Solution
{

    static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int result = -1; // se não um preço for válido este será o valor de retorno -1
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                if (keyboards[i] + drives[j] <= b) // verifica se preço é valido
                {
                    int preco = keyboards[i] + drives[j];

                    if (preco > result) // escolhe maior preço
                    {
                        result = preco;
                    }
                }
            }
        }

        return result;
    }
}
