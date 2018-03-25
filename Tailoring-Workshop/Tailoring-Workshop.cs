using System;

class Program
{
    static void Main(string[] args)
    {
        int tablesCount = int.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double areaCovers = ((tablesCount * (length + (2 * 0.30)) * (width + (2 * 0.30))));
        //Console.WriteLine("{0:f2}",(areaCovers));

        double areaSquares = (tablesCount * ((length / 2) * (length / 2)));
        //Console.WriteLine(areaSquares);

        double priceUSD = ((areaCovers * 7) + (areaSquares * 9));
        Console.WriteLine(priceUSD.ToString("0.00") + " USD");

        double priceBGN = priceUSD * 1.85;
        Console.WriteLine(priceBGN.ToString("0.00") + " BGN");
    }
}

