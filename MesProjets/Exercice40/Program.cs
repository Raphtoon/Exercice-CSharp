
// 1

void displayFunc(string firstname, string lastname)
{
    Console.WriteLine($"{firstname} {lastname}");
}

displayFunc("raphael", "oliazadeh");

// 2

double displayLess(double firstNbr, double lastNbr)
{
    return firstNbr - lastNbr;
}
Console.WriteLine(displayLess(3, 2));

// 3

void whatHoursVoid(string hours = "12h00")
{
    Console.WriteLine($"il est {hours}");
}
whatHoursVoid();

string whatHours(string hours = "12h00")
{
    return $"il est {hours}";
}
Console.WriteLine(whatHours("14h00"));

// 4
int howMuchChar(string longStr = "C'est le b-a baaaaaa")
{
    int howMuchCharIn = 0;
    foreach (char ch in longStr)
    {
        if (ch == 'a')
        {
            howMuchCharIn++;
        }
    }
    return howMuchCharIn;
}
Console.WriteLine(howMuchChar());




