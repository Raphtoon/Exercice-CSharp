Console.WriteLine("Quelle boisson souhaitez-vous?\n");

Console.WriteLine("Liste des boissons disponibles\n \t 1) Eau plate\n \t 2) Eau gazeuse\n \t 3) Coca-Cola\n  \t 3) Coca-Cola\n \t 4) Fanta\n \t 5) Sprite\n \t 6) Orangina\n \t 7) 7up\n");
Console.Write("Faîtes votre choix (1 à 7): ");

string strChoice = Console.ReadLine();
switch (strChoice)
{
    case "1":
        Console.WriteLine($"Votre Eau plate est servi...");
        break;
    case "2":
        Console.WriteLine($"Votre Eau gazeuse est servi...");
        break;
    case "3":
        Console.WriteLine($"Votre Coca-Cola est servi...");
        break;
    case "4":
        Console.WriteLine($"Votre Fanta est servi...");
        break;
    case "5":
        Console.WriteLine($"Votre Sprite est servi...");
        break;
    case "6":
        Console.WriteLine($"Votre Orangina est servi...");
        break;
    case "7":
        Console.WriteLine($"Votre 7Up est servi...");
        break;
    default:
        Console.WriteLine("Choix incompris, assurez-vous de choisir une boisson existante entre 1 et 7.");
        break;
}

//if(!string.IsNullOrEmpty(strChoice))
//    Console.WriteLine("Votre "{ boisson }" est servie");
//   ||  Console.WriteLine("Votre {0} est servie", boisson); 0 correspond  a l'argument passé après la chaine de caractère
