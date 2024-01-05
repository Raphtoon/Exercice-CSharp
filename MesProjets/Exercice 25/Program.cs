int nbNote = 5;
int first = 0;
int last = 20;
double sum = 0;

Console.WriteLine("Gestion des notes !");
Console.WriteLine("Veuillez saisir 5 notes !");

for (int i = 1; i < nbNote+1; i++)
{
    Console.Write($"- Merci de saisir la note {i} (sur / 20) : ");
    bool enter = (int.TryParse(Console.ReadLine(), out int enterUser) && enterUser > 0 || enterUser < 21);
    Console.WriteLine("Saisir age:");
    //int age;
    //while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 21)
    //    Console.WriteLine("Saisie invalide ! Réésayer :");

    if (enter)
    {
        sum += enterUser;
        if (enterUser >= first)
        {
            first = enterUser;
        }
        if (enterUser <= last)
        {
            last = enterUser;
        }
        else
        {
            Console.WriteLine("Le nombre doit être compris entre 0 et 20");
            break;
        }
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleur note est {first}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {last}");
Console.ResetColor();
Console.WriteLine($"La moyenne des notes est {sum / nbNote}");
