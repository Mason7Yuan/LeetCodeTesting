using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTesting
{
    class Problem289
    {
        public void GameOfLife(int[][] board)
        {
            int[,] tempBoard = new int[board.Length, board[0].Length];

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    tempBoard[i, j] = board[i][j];
                }
            }
            
            if (board.Length == 1 && board[0].Length == 1)
                board[0][0] = 0;
            else if (board[0].Length == 1)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    if (i == 0)
                        board[i][0] = 0;
                    else if (i == board.Length - 1)
                        board[i][0] = 0;
                    else
                    {
                        if (tempBoard[i - 1, 0] + tempBoard[i + 1, 0] < 2)
                            board[i][0] = 0;
                    }
                }
            }
            else if (board.Length == 1)
            {
                for (int i = 0; i < board[0].Length; i++)
                {
                    if (i == 0)
                        board[0][i] = 0;
                    else if (i == board[0].Length - 1)
                        board[0][i] = 0;
                    else
                    {
                        if (tempBoard[0, i - 1] + tempBoard[0, i + 1] < 2)
                            board[0][i] = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[0].Length; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (i == 0 && j == board[0].Length - 1)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (i == board.Length - 1 && j == 0)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (i == board.Length - 1 && j == board[0].Length - 1)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (i == 0)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] + tempBoard[i, j + 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (i == board.Length - 1)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (j == 0)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i + 1, j + 1] + tempBoard[i + 1, j] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i + 1, j + 1] + tempBoard[i + 1, j] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i + 1, j + 1] + tempBoard[i + 1, j] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else if (j == board[0].Length - 1)
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i + 1, j] + tempBoard[i + 1, j - 1] + tempBoard[i, j - 1] + tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] == 3)
                                    board[i][j] = 1;
                            }
                        }
                        else
                        {
                            if (tempBoard[i, j] == 1)
                            {
                                if (tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] < 2)
                                    board[i][j] = 0;
                                else if (tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] > 3)
                                    board[i][j] = 0;
                            }
                            else
                            {
                                if (tempBoard[i - 1, j - 1] + tempBoard[i - 1, j] + tempBoard[i - 1, j + 1] + tempBoard[i, j + 1] + tempBoard[i, j - 1] + tempBoard[i + 1, j - 1] + tempBoard[i + 1, j] + tempBoard[i + 1, j + 1] == 3)
                                    board[i][j] = 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
