Console.WriteLine("---- Question à choix multiples ----");


Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ?");

char askUser;
Console.WriteLine("\ta) quit");
Console.WriteLine("\tb) continue");
Console.WriteLine("\tc) break");
Console.WriteLine("\td) exit");

do
{
    Console.Write("\nEntrez votre réponse : ");
    bool validEnter = char.TryParse(Console.ReadLine(), out askUser);
    askUser = Char.ToLower(askUser);
    if (askUser != 'c')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect");
        Console.ResetColor();
        Console.WriteLine("Un nouvel essai ? ");
        string choiceUser = Console.ReadLine();
        if (choiceUser != "oui")
        {
            Console.WriteLine("Fin du programme");
            break;
        }
    }
} while (askUser != 'c');

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bravo !!! C'est la bonne réponse");
Console.ForegroundColor = ConsoleColor.Gray;
