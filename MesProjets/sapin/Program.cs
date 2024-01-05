int nbStar = 1;
Console.Write("Entrez le nombre d'étage : ");
int nbSpace = int.Parse(Console.ReadLine()!) ;

for (int j = 0; j < nbSpace; j++)
{
    Console.WriteLine($"{ string.Concat(Enumerable.Repeat(' ', nbSpace)) + string.Concat(Enumerable.Repeat('*', nbStar))}");
    nbSpace--;
    nbStar += 2;
}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat(' ', nbStar - 1)) + "*");
}