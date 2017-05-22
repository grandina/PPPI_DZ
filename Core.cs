using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_2048
{
    class Core
    {
        public int GameStatus(int[,] grid)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (i != 3 && j != 3)
                        if (grid[i, j] == grid[i + 1, j] || grid[i, j] == grid[i, j + 1]) return 1;
                    if (i == 3 && j == 3)
                        if (grid[i, j] == grid[i - 1, j] || grid[i, j] == grid[i, j - 1]) return 1;
                    if (i == 3 && j != 3)
                        if (grid[i, j] == grid[i, j + 1]) return 1;
                    if (i != 3 && j == 3)
                        if (grid[i, j] == grid[i + 1, j]) return 1;


                    if (grid[i, j] == 0) return 1;
                    if (grid[i, j] == 2048) return 2;
                }
            return 0;
        }
    }
}
