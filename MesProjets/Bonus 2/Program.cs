Console.WriteLine("Table de multiplication");
bool enter = (int.TryParse(Console.ReadLine(), out int enterUser) && enterUser > 0 || enterUser < 21);
Console.Write(string.Concat(Enumerable.Repeat("======", enterUser)));
Console.WriteLine();

for (int i = 1; i < enterUser + 1; i++)
{
    for (int j = 1; j < enterUser + 1; j++)
    {
        Console.Write($"| {i * j,4}");
    }
    Console.Write('|');
    Console.WriteLine();
    if (i > 1)
    {
        Console.Write(string.Concat(Enumerable.Repeat("+-----", enterUser)));
        Console.WriteLine();
    }
    else
    {
        Console.Write(string.Concat(Enumerable.Repeat("======", enterUser)));
        Console.WriteLine();
    }
}