
class Result
{
    public static int formingMagicSquare(List<List<int>> s)
    {
        // Lista de todos os quadrados mágicos possíveis (8 soluções)
        int[][][] magicSquares = new int[][][]
        {
        new int[][]
        {
            new int[] { 8, 1, 6 },
            new int[] { 3, 5, 7 },
            new int[] { 4, 9, 2 }
        },
        new int[][]
        {
            new int[] { 6, 1, 8 },
            new int[] { 7, 5, 3 },
            new int[] { 2, 9, 4 }
        },
        new int[][]
        {
            new int[] { 4, 9, 2 },
            new int[] { 3, 5, 7 },
            new int[] { 8, 1, 6 }
        },
        new int[][]
        {
            new int[] { 2, 9, 4 },
            new int[] { 7, 5, 3 },
            new int[] { 6, 1, 8 }
        },
        new int[][]
        {
            new int[] { 8, 3, 4 },
            new int[] { 1, 5, 9 },
            new int[] { 6, 7, 2 }
        },
        new int[][]
        {
            new int[] { 4, 3, 8 },
            new int[] { 9, 5, 1 },
            new int[] { 2, 7, 6 }
        },
        new int[][]
        {
            new int[] { 6, 7, 2 },
            new int[] { 1, 5, 9 },
            new int[] { 8, 3, 4 }
        },
        new int[][]
        {
            new int[] { 2, 7, 6 },
            new int[] { 9, 5, 1 },
            new int[] { 4, 3, 8 }
        }
        };

        int minCost = int.MaxValue;

        // Para cada quadrado mágico possível, calcula o custo
        foreach (var magicSquare in magicSquares)
        {
            int cost = 0;

            // Calcula o custo para transformar o quadrado dado em um dos quadrados mágicos
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(s[i][j] - magicSquare[i][j]);
                }
            }

            // Atualiza o custo mínimo
            minCost = Math.Min(minCost, cost);
        }

        return minCost;
    }

}
