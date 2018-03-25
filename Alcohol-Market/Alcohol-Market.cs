using System;

class Program
{
    static void Main(string[] args)
    {
        double whiskeyPrice = double.Parse(Console.ReadLine());
        double beerLitres = double.Parse(Console.ReadLine());
        double wineLitres = double.Parse(Console.ReadLine());
        double rakiaLitres = double.Parse(Console.ReadLine());
        double whiskeyLitres = double.Parse(Console.ReadLine());

        double rakiaPrice = whiskeyPrice / 2;
        double winePrice = (rakiaPrice - (0.4 * rakiaPrice));
        double beerPrice = (rakiaPrice - (0.8 * rakiaPrice));

        double rakiaSum = rakiaLitres * rakiaPrice;
        double wineSum = wineLitres * winePrice;
        double beerSum = beerLitres * beerPrice;
        double whiskeySum = whiskeyLitres * whiskeyPrice;

        double totalSum = rakiaSum + wineSum + beerSum + whiskeySum;
        Console.WriteLine(totalSum.ToString("0.00"));
    }
}

