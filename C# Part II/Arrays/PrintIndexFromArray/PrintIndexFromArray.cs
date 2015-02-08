/*Write a program that creates an array containing all 
 * letters from the alphabet (A-Z). Read a word from the 
 * console and print the index of each of its letters in the array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintIndexFromArray
{
    static void Main(string[] args)
    {

        char[] array = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToUpper();


        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if(word[i] == array[j])
                {
                    Console.WriteLine("The index for the word[{0}] is {1}",i, j);
                }
            }
            
        }


    }
}

