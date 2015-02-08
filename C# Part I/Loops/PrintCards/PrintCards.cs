//WriteLine a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class PrintCards
{
    static void Main()
    {

        for (int i = 1; i <= 4; i++)
        {
            switch (i)
            {
          
                    case 1:
                        {
                            for (int k = 2; k < 15; k++)
                            {
                                switch (k)
                                {
                                    case 2: Console.WriteLine("2 of Clubs "); break;
                                    case 3: Console.WriteLine("3 of Clubs "); break;
                                    case 4: Console.WriteLine("4 of Clubs "); break;
                                    case 5: Console.WriteLine("5 of Clubs "); break;
                                    case 6: Console.WriteLine("6 of Clubs "); break;
                                    case 7: Console.WriteLine("7 of Clubs "); break;
                                    case 8: Console.WriteLine("8 of Clubs "); break;
                                    case 9: Console.WriteLine("9 of Clubs "); break;
                                    case 10: Console.WriteLine("10 of Clubs "); break;
                                    case 11: Console.WriteLine("Jack of Clubs "); break;
                                    case 12: Console.WriteLine("Queen of Clubs "); break;
                                    case 13: Console.WriteLine("King of Clubs "); break;
                                    case 14: Console.WriteLine("Ace of Clubs "); break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------");
                            for (int k = 2; k < 15; k++)
                            {
                                switch (k)
                                {
                                    case 2: Console.WriteLine("2 of Diamonds "); break;
                                    case 3: Console.WriteLine("3 of Diamonds "); break;
                                    case 4: Console.WriteLine("4 of Diamonds "); break;
                                    case 5: Console.WriteLine("5 of Diamonds "); break;
                                    case 6: Console.WriteLine("6 of Diamonds "); break;
                                    case 7: Console.WriteLine("7 of Diamonds "); break;
                                    case 8: Console.WriteLine("8 of Diamonds "); break;
                                    case 9: Console.WriteLine("9 of Diamonds "); break;
                                    case 10: Console.WriteLine("10 of Diamonds "); break;
                                    case 11: Console.WriteLine("Jack of Diamonds "); break;
                                    case 12: Console.WriteLine("Queen of Diamonds "); break;
                                    case 13: Console.WriteLine("King of Diamonds "); break;
                                    case 14: Console.WriteLine("Ace of Diamonds "); break;

                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("----------------------");
                            for (int k = 2; k < 15; k++)
                            {
                                switch (k)
                                {
                                    case 2: Console.WriteLine("2 of Hearts "); break;
                                    case 3: Console.WriteLine("3 of Hearts "); break;
                                    case 4: Console.WriteLine("4 of Hearts "); break;
                                    case 5: Console.WriteLine("5 of Hearts "); break;
                                    case 6: Console.WriteLine("6 of Hearts "); break;
                                    case 7: Console.WriteLine("7 of Hearts "); break;
                                    case 8: Console.WriteLine("8 of Hearts "); break;
                                    case 9: Console.WriteLine("9 of Hearts "); break;
                                    case 10: Console.WriteLine("10 of Hearts "); break;
                                    case 11: Console.WriteLine("Jack of Hearts "); break;
                                    case 12: Console.WriteLine("Queen of Hearts "); break;
                                    case 13: Console.WriteLine("King of Hearts "); break;
                                    case 14: Console.WriteLine("Ace of Hearts "); break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("----------------------");
                            for (int k = 2; k < 15; k++)
                            {
                                switch (k)
                                {
                                    case 2: Console.WriteLine("2 of Spades "); break;
                                    case 3: Console.WriteLine("3 of Spades "); break;
                                    case 4: Console.WriteLine("4 of Spades "); break;
                                    case 5: Console.WriteLine("5 of Spades "); break;
                                    case 6: Console.WriteLine("6 of Spades "); break;
                                    case 7: Console.WriteLine("7 of Spades "); break;
                                    case 8: Console.WriteLine("8 of Spades "); break;
                                    case 9: Console.WriteLine("9 of Spades "); break;
                                    case 10: Console.WriteLine("10 of Spades "); break;
                                    case 11: Console.WriteLine("Jack of Spades "); break;
                                    case 12: Console.WriteLine("Queen of Spades "); break;
                                    case 13: Console.WriteLine("King of Spades "); break;
                                    case 14: Console.WriteLine("Ace of Spades "); break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        }
                    default:
                        break;
                }
        }  
 
    }
}

