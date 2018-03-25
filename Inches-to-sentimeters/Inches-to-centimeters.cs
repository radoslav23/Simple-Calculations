using System;

class Program
{
static void Main(string[] args)
{
    //double inches = double.Parse(Console.ReadLine());
    //Console.WriteLine(inches * 2.54);

    Console.Write("Inches = ");
    double inches = double.Parse(Console.ReadLine());
    var centimeters = inches * 2.54;
    Console.Write("Centimeters = ");
    Console.WriteLine(centimeters);
}
}

