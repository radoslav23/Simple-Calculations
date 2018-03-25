using System;
using System.Globalization;


class Program
{
static void Main()
{
    string birthday = Console.ReadLine();
    string format = "dd-MM-yyyy";

    DateTime userDate = DateTime.ParseExact(birthday, format, 
        CultureInfo.InvariantCulture);
    userDate = userDate.AddDays(999);
    Console.WriteLine(userDate.ToString(format));
}
}