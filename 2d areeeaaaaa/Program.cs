using System;


class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        double sideA = 0;
        if (a < c)
        {
            sideA = c - a;
        }
        else
        {
            sideA = a - c;
        }

        double sideB = d - b;
        if (b < d)
        {
            sideB = d - b;
        }
        else
        {
            sideB = b - d;
        }

        double area = sideA * sideB;
        double perimeter = 2 * (sideA + sideB);

        //Console.WriteLine(sideA);
        //Console.WriteLine(sideB);
        //Console.WriteLine("side a {0} side b {1}",sideA, sideB);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}

