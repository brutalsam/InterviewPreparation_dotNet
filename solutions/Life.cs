using System;
using System.Collections.Generic;
namespace InterviewPreparation
{
// According to the Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
// Given a board with m by n cells, each cell has an initial state live (1) or dead (0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):
// Any live cell with fewer than two live neighbors dies, as if caused by under-population.
// Any live cell with two or three live neighbors lives on to the next generation.
// Any live cell with more than three live neighbors dies, as if by over-population..
// Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
// Write a function to compute the next state (after one update) of the board given its current state. The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously.
    public class Life
    {
        public static void GameOfLife(int[][] board) 
        {
            var ylen = board.Length;
            var arrayCopy = new int[ylen][];
            if (ylen < 1)
                return;
            var xlen = board[0].Length;
            for (var y = 0; y < ylen; y++)
            {
                arrayCopy[y] = new int[xlen];
                for (int x = 0; x < xlen; x++)
                {
                    arrayCopy[y][x] = board[y][x];
                }
            }

            for (int x = 0; x < xlen; x++)
            {
                for (int y = 0; y < ylen; y++)
                {
                    var liveNeighbors = getNeighbor(arrayCopy, x-1, y-1) +
                        getNeighbor(arrayCopy, x, y-1) +
                        getNeighbor(arrayCopy, x + 1, y-1) +
                        getNeighbor(arrayCopy, x-1, y) +
                        getNeighbor(arrayCopy, x + 1, y) +
                        getNeighbor(arrayCopy, x-1, y + 1) +
                        getNeighbor(arrayCopy, x, y + 1) +
                        getNeighbor(arrayCopy, x + 1, y + 1);

                    if(arrayCopy[y][x] == 1)
                    {
                        if (liveNeighbors > 3 || liveNeighbors < 2)
                            board[y][x] = 0; 
                    }
                    else    
                    {
                        if (liveNeighbors == 3)
                            board[y][x] = 1;
                    }
                }
            }
        }

        private static int getNeighbor(int[][] board, int x, int y)
        {
            if (x < 0 || y < 0)
                return 0;
            var ylen = board.Length;
            var xlen = board[0].Length;
            if (x >= xlen || y >= ylen)
                return 0;

            return board[y][x];
        }

        public static void TestSolution()
        {
            int[][] inArr = { new int[] {0,1,0},
                                new int[]{0,0,1},
                                new int[]{1,1,1},
                                new int[]{0,0,0}
            };
            GameOfLife(inArr);
        }
    }
}