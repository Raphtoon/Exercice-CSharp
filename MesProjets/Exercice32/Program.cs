int[] numbers = new int[10];
int index = 0;
int space = 0;

// Ajout des entrées a chaque index + verification entrée
foreach (int i in numbers)
{
    Console.Write($"Saisir la valeur {index + 1} : ");

    if (int.TryParse(Console.ReadLine(), out int inputNumber))
    {
        numbers[index] = inputNumber;
        index++;
    }
    else
    {
        Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier.");
    }
    if (index == numbers.Length)
    {
        break;
    }
}// Fin des ajouts

Console.WriteLine("Affichage des valeures du tableau :");
foreach (int num in numbers)
{
    Console.Write(string.Concat(Enumerable.Repeat(" ", space)));
    Console.WriteLine(num);
    space += 10;
}



//int[] numbers = new int[10];
//int index = 0;
//int space = 0;

//static void AddToArray(int index, int[] input)
//{
//    if (int.TryParse(Console.ReadLine(), out int inputNumber))
//    {
//        numbers[index] = inputNumber;
//        index++;
//    }
//    else
//    {
//        Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier.");
//    }
//}

//// Ajout des entrées a chaque index + verification entrée
//foreach (int i in numbers)
//{
//    Console.Write($"Saisir la valeur {index + 1} : ");

//    if (int.TryParse(Console.ReadLine(), out int inputNumber))
//    {
//        numbers[index] = inputNumber;
//        index++;
//    }
//    else
//    {
//        Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier.");
//    }
//    if (index == numbers.Length)
//    {
//        break;
//    }
//}// Fin des ajouts

//Console.WriteLine("Affichage des valeures du tableau :");
//foreach (int num in numbers)
//{
//    Console.Write(string.Concat(Enumerable.Repeat(" ", space)));
//    Console.WriteLine(num);
//    space += 10;
//}

