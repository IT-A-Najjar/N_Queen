using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N_QuanHau
{
    class Queens
    {
        public int N;
        public int[,] Board;

        public Queens(int n)
        {
            N = n;
            Board = new int[N, N];
            
        }
        public bool isSafe(int r,int c)
        {
            int i, j;
            for (i = 0; i < c; i++)
                if (Board[r, i] == 1)
                    return false;
            for (i = r, j = c; i >= 0 && j >= 0; i--, j--)
                if (Board[i, j] == 1)
                    return false;
            for (i = r, j = c; i < N && j >= 0; i++, j--)
                if (Board[i, j] == 1)
                    return false;

            return true;
        }

        public bool Solve(int c)
        {
            if (c>= N)
                return true;
            for(int i=0;i < N; i++)
            {
                if (isSafe(i, c))
                {
                    Board[i, c] = 1;
                    if (Solve(c +1))
                        return true;
                    Board[i, c] = 0;
                }
            }
            return false;
        }
        public void Display()
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (Board[i, j] == 1)
                        Console.Write("Q");
                    else
                        Console.Write("*");
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
