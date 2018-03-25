using System;

class Charity
{
static void Main(string[] args)
{
    int days = int.Parse(Console.ReadLine());
    int cookers = int.Parse(Console.ReadLine());
    int cakes = int.Parse(Console.ReadLine());
    int waffles = int.Parse(Console.ReadLine());
    int pancakes = int.Parse(Console.ReadLine());

    double daySumCakes = cakes * 45;
    double daySumWaffles = waffles * 5.80;
    double daySumPancakes = pancakes * 3.20;
        
    double daySumAll = ((daySumCakes + daySumWaffles + daySumPancakes) * cookers);

    double sumAllCampaign = daySumAll * days;

    double sumAfterExpences = (sumAllCampaign - (sumAllCampaign / 8));
    Console.WriteLine(sumAfterExpences.ToString("0.00"));
}
}

