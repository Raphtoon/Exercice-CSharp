Console.WriteLine("===== Tableaux des notes =====");
Console.Write("Combien de note(s) comportera le tableau ? : ");
int inputUser;
int index = 0;
double sum = 0;

while (!int.TryParse(Console.ReadLine(), out inputUser))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Erreur de saisie, merci de saisir un chiffre/nombre : ");
    Console.ResetColor();
}

double[] nbNote = new double[inputUser];

Console.WriteLine($"Merci de saisir les {nbNote.Length} notes");
for (int i = 0; i < nbNote.Length; i++)

{
    double validInput;
    Console.Write($"Saisie de la note{i+1}: ");
    while (!double.TryParse(Console.ReadLine(), out validInput) || validInput < 0 || validInput > 20)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Erreur de saisie, merci de saisir un chiffre/nombre : ");
        Console.ResetColor();
    }
    sum += validInput;
    nbNote[i] = validInput;

}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("--- Liste des notes ---");
Console.ResetColor();

foreach (int note in nbNote)
{
    Console.WriteLine($"La note {index + 1} est de {nbNote[index]}/20");
    index++;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La note max est : {nbNote.Max()}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La note la plus basse est : {nbNote.Min()}/20");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"La note moyenne est de : {Math.Round(nbNote.Average(),2)}/20");
Console.ResetColor();
