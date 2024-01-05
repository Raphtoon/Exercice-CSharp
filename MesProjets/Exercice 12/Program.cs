Console.Write("Entrez l'âge de votre enfant");

int age1 = int.Parse(Console.ReadLine());


if (age1 < 3)
{
Console.WriteLine("Votre enfant est trop jeune.");
    return;
}
else if (age1 >= 13)
{
    Console.WriteLine("Votre enfant est dans la catégorie \"Cadet\".");
}
else if (age1 >= 11)
{
    Console.WriteLine("Votre enfant est dans la catégorie \"Minime\".");
}
else if (age1 >= 9)
{
    Console.WriteLine("Votre enfant est dans la catégorie \"Pupille\".");
}
else if (age1 >= 7)
{
    Console.WriteLine("Votre enfant est dans la catégorie \"Poussin\".");
}
else
{
    Console.WriteLine("Votre enfant est dans la catégorie \"Baby\".");
}
