class Result
{
    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        // Cria um HashSet para armazenar os obstáculos em formato de tuplas (linha, coluna)
        // Isso permite verificar rapidamente se uma posição tem obstáculo (em O(1))
        var obstacleSet = new HashSet<(int, int)>();
        foreach (var obs in obstacles)
        {
            obstacleSet.Add((obs[0], obs[1])); // Converte cada lista [linha, coluna] em tupla (linha, coluna)
        }

        // Define as 8 direções possíveis em que a rainha pode se mover
        (int dr, int dc)[] directions = new (int, int)[]
        {
        (0, 1),   // Direita →
        (0, -1),  // Esquerda ←
        (1, 0),   // Cima ↑
        (-1, 0),  // Baixo ↓
        (1, 1),   // Diagonal ↗
        (1, -1),  // Diagonal ↖
        (-1, 1),  // Diagonal ↘
        (-1, -1)  // Diagonal ↙
        };

        int attackableSquares = 0; // Contador de casas que a rainha pode atacar

        // Para cada direção, simula o movimento da rainha
        foreach (var (dr, dc) in directions)
        {
            int r = r_q + dr; // Próxima linha na direção
            int c = c_q + dc; // Próxima coluna na direção

            // Continua enquanto estiver dentro do tabuleiro
            while (r >= 1 && r <= n && c >= 1 && c <= n)
            {
                if (obstacleSet.Contains((r, c)))
                    break; // Interrompe se encontrar obstáculo

                attackableSquares++; // Casa válida para ataque
                r += dr; // Avança na mesma direção
                c += dc;
            }
        }

        return attackableSquares; // Total de casas atacáveis
    }


}
