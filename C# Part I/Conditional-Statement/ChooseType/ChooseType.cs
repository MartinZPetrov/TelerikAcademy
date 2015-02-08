using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
class ChooseType
{
    static void Main()
    {
        Console.WriteLine("Choose a type");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1: 
                {
                    Console.WriteLine("Enter an int");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result " + number + 1);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Enter an double");
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result " + number + 1);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Enter an string");
                    string str = Console.ReadLine();
                    Console.WriteLine("Result " + str + "*");
                    break;
                }
            default:
                {
                    Console.WriteLine("Not valid input");
                    break;
                }
        }



    }
}

