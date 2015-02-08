//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:
/*s  qq s
 *pp pp s -->> s s s 
 *pp qq s    
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestSequence
{
    static void Main(string[] args)
    {

        string[,] matrix =  {                   //First Test 
                            {"a", "qq","b"},
                            {"pp", "q","c"},
                            {"z", "g","w"},
                            };
   
        //string[,] matrix =  {
        //                    {"ho", "hw", "ha", "hw"},
        //                    {"so", "ho", "hi", "xx"},
        //                    {"so", "hi", "ho", "ss"},
        //                    };

        int rowsCount = matrix.GetLength(0);
        int colsCount = matrix.GetLength(1);
        int longest = 1;
        int bestLongest = 1;
       
        List<string> items = new List<string>(); // Polulate with longest sequence 
        int direction = 0; // 1 - right, 2 right diagonl, 3 down, 4 left diagonal 


        for (int rows = 0; rows < rowsCount; rows++)
        {
            for (int j = 0; j < colsCount; j++)
            {
                longest = 1;
                direction = 0;
                for (int tempColom = j + 1; tempColom < colsCount; tempColom++)
                {
                    if (matrix[rows, tempColom - 1] != matrix[rows, tempColom]) // search horizontally
                    {
                        break;
                    }
                    else
                    {
                        longest++;
                    }
                }

                if (longest > bestLongest)
                {
                    direction = 1;
                    bestLongest = longest;
                    items.Clear();
                }

                longest = 1;

                for (int tempRow = rows + 1; tempRow < rowsCount; tempRow++)
                {

                    if (matrix[tempRow - 1, j] != matrix[tempRow, j]) // search vertically 
                    {
                        break;
                    }
                    else
	                {
                        longest++;
	                }
                }
            
                if (longest > bestLongest)
                {
                    direction = 3;
                    bestLongest = longest;
                    items.Clear();
                }
                longest = 1;

                if (j < matrix.GetLength(1) - 1 )
                {
                    int ínnerColom = j;
                    for (int tempRow = rows + 1; tempRow < rowsCount; tempRow++)
                    {

                        ínnerColom++;
                        if (matrix[tempRow - 1, ínnerColom - 1] != matrix[tempRow, ínnerColom]) // search right diagonal  
                        {
                            break;
                        }
                        else
                        {
                            longest++;
                        }
                    }
                }

                if (longest > bestLongest)
                {
                    direction = 2;
                    bestLongest = longest;
                    items.Clear();
                }

                if (j > 0)
                {
                    int innerColom = j;
                    for (int tempRow = rows + 1; tempRow < rowsCount; tempRow++)
                    {
                        if (innerColom != 0 )
                        {
                            innerColom--;
                        }
                        if (matrix[tempRow - 1, innerColom + 1] != matrix[tempRow, innerColom]) // search left  diagonal 
                        {
                            break;
                        }
                        else
                        {
                            longest++;
                        }
                    }
                }

                if (longest > bestLongest)
                {
                    direction = 4;
                    bestLongest = longest;
                    items.Clear();
                }

                int colsforSwitch = j;
                int rowsForSwitch = rows;
                for (int k = 0; k < bestLongest; k++) // add horizontal values to list
                {
                    switch (direction)
                    {
                        case 1:
                            {
                                items.Add(matrix[rows, colsforSwitch]);
                                colsforSwitch++;
                                break;
                            }
                        case 2:
                            {
                                items.Add(matrix[rowsForSwitch, colsforSwitch]);
                                colsforSwitch++;
                                rowsForSwitch++;
                                break;
                            }
                        case 3:
                            {
                                items.Add(matrix[rowsForSwitch, j]);
                                rowsForSwitch++;
                                break;
                            }
                        case 4:
                            {
                                items.Add(matrix[rowsForSwitch, colsforSwitch]);
                                colsforSwitch--;
                                rowsForSwitch++;
                                break;
                            }
                    }
                }
            }
        }
        if (bestLongest > 1)
        {
            for (int i = 0; i < bestLongest; i++)
            {
                if (i == bestLongest - 1)
                {
                    Console.Write(items[i] + " ");
                }
                else
                {
                    Console.Write(items[i] + ", ");
                }
            }
        }
        else
        {
            Console.WriteLine("No sequence found");
        }
    }

}
