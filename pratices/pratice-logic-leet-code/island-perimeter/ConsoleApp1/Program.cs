class Solution
{
    public int islandPerimeter(int[][] grid)
    {
        int perimeter = 0;
        var rows = grid.Length;
        var columns = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (grid[i][j] == 1)
                {
                    perimeter += 4;

                    //check adjacent cells
                    //up if exists
                    if (i > 0 && grid[i - 1][j] == 1)
                    {
                        perimeter--;
                    }
                    //down if exists
                    if (i < rows - 1 && grid[i + 1][j] == 1)
                    {
                        perimeter--;
                    }
                    //left if exists
                    if (j > 0 && grid[i][j - 1] == 1)
                    {
                        perimeter--;
                    }
                    //right if exists
                    if (j < columns - 1 && grid[i][j + 1] == 1)
                    {
                        perimeter--;
                    }
                }
            }
        }

        return perimeter;
    }
}