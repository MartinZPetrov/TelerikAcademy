//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	90
//20	
//60	
//10	
//5 	6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1 	1

using System;

class EnterNumberAndSum
{
    static void Main()
    {
        int number, lenght;
        double sum;
        sum = 0;
        Console.Write("Enter lenght: ");
        lenght = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter value :");
            number = Int32.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}

