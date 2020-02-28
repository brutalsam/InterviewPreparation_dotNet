using System;
namespace InterviewPreparation
{
    // Given a 2d grid map of '1's (land) and '0's (water), count 
    // the number of islands. An island is surrounded by water and is
    // formed by connecting adjacent lands horizontally or vertically. 
    // You may assume all four edges of the grid are all surrounded 
    // by water.
    public class NumberOfIslands
    {
        public static int NumIslands(char[][] grid) 
        {
            int[][] islands = new int[grid.Length][];
            for (var i = 0; i < grid.Length; i++)
            {
                islands[i] = new int[grid[i].Length];
            }

            var islandsIdx = 1;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (revealIsland(i, j, grid, islands, islandsIdx))
                        islandsIdx++;
                }
            }  

            return islandsIdx-1;
        }

        private static Boolean revealIsland(int i, int j, char[][] grid, int[][] islands, int islandIdx)
        {
            if (grid[i][j] != '1')
                return false;
            if (islands[i][j] != 0)
                return false;
            islands[i][j] = islandIdx;
            if (i - 1 >= 0)
                revealIsland(i - 1, j, grid, islands, islandIdx);

            if (i + 1 < grid.Length)
                revealIsland(i + 1, j, grid, islands, islandIdx);

            if (j - 1 >= 0)
                revealIsland(i, j - 1, grid, islands, islandIdx);

            if (j + 1 < grid[i].Length)
                revealIsland(i, j + 1, grid, islands, islandIdx);
            
            return true;
        }

        public static void ExecuteSolution()
        {
            char[][] jaggedArray1 = 
            {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' }, 
                new char[] { '0', '0', '0', '0', '0' }, 
            };
            char[][] jaggedArray2 = 
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' }, 
                new char[] { '0', '0', '0', '1', '1' }, 
            };

            char[][] jaggedArray3 = 
            {
                new char[] { '1', '1', '1' },
                new char[] { '0', '1', '0' },
                new char[] { '1', '1', '1' }
            };
            var len = NumberOfIslands.NumIslands(jaggedArray3);
        }
    }
}