Console.WriteLine("Le nombre est-il divisible par .... ?");
Console.Write("Entrez un chiffre / nombre entier : ");
int entreeUtilisateur = int.Parse(Console.ReadLine()!);
Console.Write("Entrez un chiffre / nombre entier : ");
int nbrModulo = int.Parse(Console.ReadLine()!);

if (entreeUtilisateur % nbrModulo == 0)
{
    Console.WriteLine($"Le chiffre est bien divisible par {nbrModulo}");
}
else
{
    Console.WriteLine($"Le chiffre n'est pas divisible par {nbrModulo}");
}



//------------------------------------------------------------------------------------

string resultat = (entreeUtilisateur % nbrModulo == 0) ? $"Le chiffre est bien divisible par {nbrModulo}" : $"Le chiffre n'est pas divisible par {nbrModulo}";
Console.WriteLine(resultat);