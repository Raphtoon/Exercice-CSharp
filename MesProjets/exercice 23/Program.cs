
Console.WriteLine();
for (int i = 1; i < 11; i++)
{
    Console.WriteLine("Table de " + i);
    for (int j = 1; j < 11; j++)
        Console.WriteLine($" \t- {i} x {j} = {i * j}");
}