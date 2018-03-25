using System;

class Program
{
    static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double side = double.Parse(Console.ReadLine());

        double hallInCentimeters = ((length * 100) * (width * 100));
        //Console.WriteLine(hallInCentimeters);

        //double wardrobeSize = sideInCentimeters * sideInCentimeters;
        double wardrobeSize = ((side * 100) * (side * 100));
        //Console.WriteLine(wardrobeSize);

        double benchSize = hallInCentimeters / 10;
        //Console.WriteLine(benchSize);

        double freeSpace = hallInCentimeters - wardrobeSize - benchSize;
        //Console.WriteLine(freeSpace);

        double dancers = (freeSpace / (40 + 7000));
        Console.WriteLine(Math.Floor(dancers));
    }
}

