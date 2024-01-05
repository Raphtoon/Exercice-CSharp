int nbrMystere;
int nbrUser = 0;
int nbrTry = 0;

Console.WriteLine("Entrez un chiffre mystère > 0 ou < à 50:  ");

while (!int.TryParse(Console.ReadLine(), out nbrMystere) || nbrMystere < 0 || nbrMystere > 50)
{
    Console.WriteLine("Saisie invalide ! Réessayez :");
}

Console.WriteLine("Devinez le nombre mystère :");

while (nbrUser != nbrMystere)
{

    if (!int.TryParse(Console.ReadLine(), out nbrUser))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Saisie invalide ! Réessayez :");
    }
    if (nbrUser > nbrMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit");
    }
    else if (nbrUser < nbrMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus grand");

    }
    nbrTry++;
    Console.ForegroundColor = ConsoleColor.Gray;

}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bravo, vous avez trouvé le nombre mystère !");
Console.WriteLine($"Vous avez trouvé en {nbrTry} coups");
Console.ForegroundColor = ConsoleColor.Gray;
