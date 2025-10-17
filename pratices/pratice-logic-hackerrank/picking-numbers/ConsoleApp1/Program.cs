
List<int> a = [4, 6, 5, 3, 3, 1];
Result.pickingNumbers(a);

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */



    public static int pickingNumbers(List<int> a)
    {
        var frequency = new Dictionary<int, int>();

        // Preenche o dicionário com a frequência de cada número
        foreach (var num in a)
        {
            if (frequency.TryGetValue(num, out int value))
                frequency[num] = ++value;
            else
                frequency[num] = 1;
        }

        int maxSubsetSize = 0;

        // Para cada número no dicionário, verifica a soma da frequência do número e do número + 1
        foreach (var key in frequency.Keys)
        {
            // Subconjunto com números 'key' e 'key + 1'
            int subsetSize = frequency[key];

            if (frequency.ContainsKey(key + 1))
            {
                subsetSize += frequency[key + 1];
            }

            // Atualiza o tamanho do maior subconjunto
            maxSubsetSize = Math.Max(maxSubsetSize, subsetSize);
        }

        return maxSubsetSize;
    }

}