int nbNote = 1;
int first = 0;
int last = 0;
int choiceUserTwo = 0;
double sum = 0;
char choiceUser;

Console.WriteLine("Gestion des notes !");
Console.WriteLine("1----Saisir les notes");
Console.WriteLine("2----La plus grande note");
Console.WriteLine("3----La plus petite note");
Console.WriteLine("4----La moyenne des notes");
Console.WriteLine("0----Quitter");

while (true)
{
    Console.Write("Faites votre choix : ");
    string userInput = Console.ReadLine()!;

    // Extraire le premier caractère de la chaîne (choix de l'utilisateur)
    bool valideEnter = char.TryParse(userInput.ToString(), out choiceUser);
    Console.Clear();

    switch (choiceUser)
    {
        case '0':
            Environment.Exit(0);
            break;
        case '1':
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saisir les notes");
            Console.WriteLine("(999 pour stopper la saisie)");
            Console.ResetColor();
            while (choiceUserTwo != 999)
            {
                Console.Write($"- Merci de saisir la note {nbNote} (sur / 20) : ");
                bool enter = (int.TryParse(Console.ReadLine(), out choiceUserTwo) && choiceUserTwo > 0 && choiceUserTwo < 21);

                if (enter)
                {
                    sum += choiceUserTwo;

                    if (choiceUserTwo > first)
                    {
                        first = choiceUserTwo;
                    }
                    if (choiceUserTwo < last || last == 0)
                    {
                        last = choiceUserTwo;
                    }

                    nbNote++;
                }
                else if (choiceUserTwo == 999)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie, la note est sur 20");
                    Console.ResetColor();
                }
            }
            break;
        case '2':
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La meilleure note est {first}");
            Console.ResetColor();
            break;
        case '3':
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La moins bonne note est {last}");
            Console.ResetColor();
            break;
        case '4':
            Console.ResetColor();
            Console.WriteLine($"La moyenne des notes est {sum / (nbNote - 1)}");
            break;
        default:
            Console.WriteLine("Erreur de saisie, recommencer");
            break;
    }
}