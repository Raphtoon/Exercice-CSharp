
Console.WriteLine("--- Est pair… ? Est impair ? ---");
Console.Write("Combien de nombre contiendra le tableau ? : ");

int inputNumber;
while (!int.TryParse(Console.ReadLine(), out inputNumber))
{
    Console.WriteLine("Veuillez saisir un nombre valide.");
}

int[] numbersRandom = new int[inputNumber];
int index = 0;

foreach (int i in numbersRandom)
{
    Random rnd = new Random();
    int num = rnd.Next(1, inputNumber * 2);
    numbersRandom[index] = num;
    index++;
}// Fin des ajouts
foreach (int i in numbersRandom)
{
    Console.WriteLine("Vérification des valeurs du tableau");
    bool estPaire = (i % 2 == 0) ? true : false;
    Console.WriteLine($"\t Le nombre {i} {(estPaire ? "est pair" : "est impair")}");

}

