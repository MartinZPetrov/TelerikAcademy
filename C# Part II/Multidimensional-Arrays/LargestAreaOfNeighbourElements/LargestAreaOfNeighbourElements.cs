//* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. Example:
/*1 3 2 2 2 4 
 *3 3 3 2 4 4  
 *4 3 3 2 4 4
 *4 3 1 2 3 3 ----> 13   
 *4 3 1 3 3 1
 *4 3 3 3 1 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestAreaOfNeighbourElements
{
    static bool[,] visited = new bool[1000, 1000];
    static int[] dx = { -1, 1, 0, 0 };
    static int[] dy = { 0, 0, -1, 1 };
    static int newX;
    static int newY;

    static void Main(string[] args)
    {
        int[,] matrix = {{1, 3, 2, 2, 2, 4},
                         {3, 3, 3, 2, 4, 4},
                         {4, 3, 1, 2, 3, 3},
                         {4, 3, 1, 3, 3, 1},
                         {4, 3, 3, 3, 1, 1}};

        //traverse the matrix in search for largest area
        int current = 0;
        int max = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (visited[rows, cols] == false)
                {
                    current =  dfs(matrix, rows, cols, matrix[rows, cols]);
                    if (current > max)
                    {
                        max = current;
                    }
                }
            }
        }
        Console.WriteLine(max);
    }


    static int dfs(int[,] matrix, int x, int y, int value)
    {
        if (visited[x, y])
        {
            return 0;
        }
        else
        {
            visited[x, y] = true;
            int best = 0;
            int bestX = x, bestY = y;
            for (int i = 0; i < 4; i++)
            {

                int modx = dx[i] + x;
                int mody = dy[i] + y;

                //if we are outside of our matrix
                if (modx == -1 || modx >= matrix.GetLength(0) ||
                    mody == -1 || mody >= matrix.GetLength(1))
                {
                    continue;
                }

                //if neighbour value is the same, "DFS" it
                if (matrix[modx, mody] == value)
                {
                    int v = dfs(matrix, modx, mody, value);
                    best += v;
                }
                newX = bestX;
                newY = bestY;
            }
            return best + 1;
        }
    }
}

