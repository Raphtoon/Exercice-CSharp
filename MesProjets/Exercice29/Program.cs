int first = 0;
int last = 0;
double sum = 0;
int choiceUser = 0;
int nbNote = 1;

Console.WriteLine("Gestion des notes !");
Console.WriteLine("Veuillez saisir les notes ! (999 pour calculer)");

while (choiceUser != 999)
{
    Console.Write($"- Merci de saisir la note {nbNote} (sur / 20) : ");
    bool enter = (int.TryParse(Console.ReadLine(), out choiceUser) && choiceUser > 0 && choiceUser < 21);

    if (enter)
    {
        sum += choiceUser;

        if (choiceUser > first)
        {
            first = choiceUser;
        }
        if (choiceUser < last)
        {
            last = choiceUser;
        }

        nbNote++;
    }
    else
    {
        Console.WriteLine("Le nombre doit être compris entre 0 et 20");
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est {first}/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {last}/20");
Console.ResetColor();
Console.WriteLine($"La moyenne des notes est {sum / nbNote}/20");