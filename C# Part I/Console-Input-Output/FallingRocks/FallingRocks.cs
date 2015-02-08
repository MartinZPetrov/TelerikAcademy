/** Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and
 *right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
 *
 * 
 */

// Знам че не работи правилно, но поне се опитах ^_^ , ако имах време най-вероятно шях да я направя.

using System;
using System.Threading;

class FallingRocks
{
    static int score = 0;
    static int playerColumnPosition;
    static int playerRowPosition;

    static int playerDirection;
    static int left = -1;
    static int right = 1;
 
              
    static int rockOneRow = 0;
    static int rockTwoRow = 0;
    static int rockThreeRow = 0;
    static int rockFourRow = 0;
    static int rockFiveRow = 0;

    
  
    static void Main()
    {
        SetGameField();
        int randRockOneCol;
        int randRockTwoCol;
        int randRocThreeCol;
        int randRocFourCol;
        int randRocFiveCol;

        randRocThreeCol = GetRandomNumber(101);
        randRocFourCol = GetRandomNumber(101);
        randRocFiveCol = GetRandomNumber(101);
        while (true)
        {

            randRockOneCol = GetRandomNumber(33);
            randRockTwoCol = GetRandomNumber(33);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                SetDwarfDirection (key);
            }
            MoveDwarf();
            DrawDwarf(playerColumnPosition, playerRowPosition, "(0)", ConsoleColor.Red);

            DrawRock(33, rockOneRow, "@", ConsoleColor.Blue, 1);
            DrawRock(55, rockTwoRow, "+", ConsoleColor.Red, 2);
            DrawRock(23, rockThreeRow, "$", ConsoleColor.Green,3);
            DrawRock(77, rockFourRow, "^", ConsoleColor.Magenta,4);
            DrawRock(99, rockFiveRow, "&", ConsoleColor.Cyan,5);

            EndGame(playerColumnPosition);
            Thread.Sleep(150);
        }
    }

   static void SetGameField()
    {

        Console.WindowHeight = 30;
        Console.BufferHeight = 30;
        
        Console.WindowWidth = 102;
        Console.BufferWidth = 103;
       
        playerColumnPosition = Console.WindowWidth / 2;
        playerRowPosition = Console.WindowHeight - 1;
    }

    static void SetDwarfDirection(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.LeftArrow)
        {
            playerDirection = left;
        }

        if (key.Key == ConsoleKey.RightArrow)
        {
            playerDirection = right;
        }
    }
    static void EndGame(int col)
    {
        if (col == 0 || col == 99)
        {
            Console.SetCursorPosition(50,15);
            Console.Write("You Loose");
            Environment.Exit(1);
        }
    }

    static void MoveDwarf()
    {
        if (playerDirection == right)
        {
            playerColumnPosition += 3;
        }

        if (playerDirection == left)
        {
            playerColumnPosition -= 3;
        }
    }

    static void DrawDwarf(int col, int row, string str, ConsoleColor Color)
    {

        Console.ForegroundColor = Color;
        if (playerDirection == left)
        {
            for (int i = 1; i <=6; i++)
            {
                Console.SetCursorPosition(col + i , row);
                Console.Write(" "); 
            }
           
        }
        if (playerDirection == right)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.SetCursorPosition(col - i, row);
                Console.Write(" "); 
            }            
        }
        Console.SetCursorPosition(col, row);
        Console.Write(str);
    
    }

    static void DrawRock(int col,int row ,string rock, ConsoleColor color, int rockNumber)
    {
        Console.ForegroundColor = color;
        if (rockNumber == 1)
        {
            if (rockOneRow > 0 )
            {
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
            }
        }
        else if (rockNumber == 2)
        {
            if (rockTwoRow > 0)
            {
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
            }
        }
        else if (rockNumber == 3)
        {
            if (rockThreeRow > 0)
            {
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
            }
        }
        else if (rockNumber == 4)
        {
            if (rockFourRow > 0)
            {
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
            }
        }
        else  if (rockNumber == 4)
            {
                if (rockFourRow > 0)
                {
                    Console.SetCursorPosition(col, row - 1);
                    Console.Write(" ");
                }
            }
        else  if (rockFiveRow > 0)
            {
                Console.SetCursorPosition(col, row - 1);
                Console.Write(" ");
            }


        Console.SetCursorPosition(col, row);
        switch (rockNumber)
        {
            case 1: rockOneRow++; break;
            case 2: rockTwoRow ++; break;
            case 3: rockThreeRow++; break;
            case 4: rockFiveRow++; break;
            case 5: rockFourRow++; break;
        
        }

        Console.Write(rock);

        if (row  == 29)
        {
            Console.SetCursorPosition(col, 29);
            Console.Write(" ");
            if (rockNumber == 1)
            {
                rockOneRow = 0;
            }
            else if (rockNumber == 2)
            {
                rockTwoRow = 0;
            }

            else if (rockNumber == 3)
            {
                rockThreeRow = 0;
            }
            else if (rockNumber == 4)
            {
                rockFourRow = 0;
            }
            else if (rockNumber == 5)
            {
                rockFiveRow = 0;
            }
        }
    }

    static string GetRock()
    {
        int randomRock = GetRandomNumber(5);
        string[] array = { "@", "#", "$", "%","^", "*", "+" };
        string rock = array[randomRock];
        return rock;
    }

    static int GetRandomNumber(int max)
    {
        Random rand = new Random();
        int random = rand.Next(1, max);
        return random;
    }

}

