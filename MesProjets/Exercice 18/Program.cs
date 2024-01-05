Console.WriteLine("Quelle boisson souhaitez vous? \n");

Console.Write("Entrez l'âge de l'enfant : ");
bool realConvert = int.TryParse(Console.ReadLine(), out int intChoice);

if (realConvert)
{
    switch (intChoice)
    {
        case >= 13:
            Console.WriteLine($"Votre enfant est dans la  \"Cadet\"");
            break;
        case >= 11:
            Console.WriteLine($"Votre enfant est dans la  \"Minime\"");
            break;
        case >= 9:
            Console.WriteLine($"Votre enfant est dans la  \"Pupille\"");
            break;
        case >= 7:
            Console.WriteLine($"Votre enfant est dans la  \"Poussin\"");
            break;
        case >= 3:
            Console.WriteLine($"Votre enfant est dans la  \"Baby\"");
            break;
        default:
            Console.WriteLine($"Votre enfant est trop jeune ou l'âge n'est pas dans nos ");
            break;
    }
}
else
{
    Console.WriteLine("Entrez un âge comportant des chiffres");
}

