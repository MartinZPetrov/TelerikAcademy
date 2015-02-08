//Write an expression that checks for given point (x, y) if it is within the
//circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
using System;

class CheckPoint
{
    static void Main()
    {
        int yK = 1;
        int xK = 1;
        float rK = 1.5f;

        int xRec = -1;
        int yRec = 1;
        int widDthRec = 6;
        int heightRec = 2;

        int x, y;
        bool isX, isY;

        Console.Write("X coordinate: ");
        isX = Int32.TryParse(Console.ReadLine(), out x);
        Console.Write("Y coordinate: ");
        isY = Int32.TryParse(Console.ReadLine(), out y);
        bool pointInCricle = (Math.Pow((x-xK),2) + Math.Pow((y-yK),2) < Math.Pow(rK,2));
        bool outOfRec =  ((x < xRec) || (x > xRec + widDthRec) || (y> yRec) || (y > yRec+heightRec));
        Console.WriteLine("Point is in circle -> {0} and outside of rectangle -> {1}", pointInCricle, outOfRec);


    }
}

