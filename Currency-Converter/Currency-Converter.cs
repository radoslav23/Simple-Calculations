using System;

class Program
{
static void Main(string[] args)
{

    //change double to var
double currencyAmount = double.Parse(Console.ReadLine());
var convertFrom = Console.ReadLine();
var convertTo = Console.ReadLine();

double bgn = 1.0;
double usd = 1.79549;
double eur = 1.95583;
double gbp = 2.53405;

switch (convertFrom)
{
    case "BGN":
        break;
    case "USD":
        currencyAmount = currencyAmount * usd;
        break;
    case "EUR":
        currencyAmount = currencyAmount * eur;
        break;
    case "GBP":
        currencyAmount = currencyAmount * gbp;
        break;
    default:
        break;
}
switch (convertTo)
{
    case "BGN":
        currencyAmount = currencyAmount / bgn;
        break;
    case "USD":
        currencyAmount = currencyAmount / usd;
        break;
    case "EUR":
        currencyAmount = currencyAmount / eur;
        break;
    case "GBP":
        currencyAmount = currencyAmount / gbp;
        break;
    default:
        break;
}
Console.WriteLine(Math.Round(currencyAmount, 2));
}
}

