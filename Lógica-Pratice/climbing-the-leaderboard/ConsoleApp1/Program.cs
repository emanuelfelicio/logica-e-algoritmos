
Result.climbingLeaderboard([100, 90, 90, 80, 75, 60], [50, 65, 77, 90, 102]);
class Result
{

    /*
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {

        // 1. Remover duplicatas do leaderboard
        var uniqueScores = new List<int>();
        foreach (var score in ranked)
        {
            if (!uniqueScores.Contains(score))
            {
                uniqueScores.Add(score);
            }
        }

        // 2. Ordenar o leaderboard em ordem decrescente
        uniqueScores.Sort((a, b) => b.CompareTo(a));

        // 3. Função para encontrar o rank de uma pontuação usando busca binária
        int FindRank(int score)
        {
            int left = 0;
            int right = uniqueScores.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (uniqueScores[mid] == score)
                {
                    return mid + 1; // Rank começa em 1
                }
                else if (uniqueScores[mid] > score)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left + 1; // Se não encontrou, retorna a posição onde deveria estar
        }

        // 4. Calcular os ranks para todas as pontuações do jogador
        var ranks = new List<int>();
        foreach (var p in player)
        {
            ranks.Add(FindRank(p));
        }

        return ranks;
    }

}