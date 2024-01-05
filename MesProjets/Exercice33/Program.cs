int[] numbers = new int[26];
int space = 1;
int index = 0;
int start = 65;
//66 a 90
// Ajout des entrées a chaque index + verification entrée
foreach (int i in numbers)
{
    numbers[index] = start;
    index++;
    start++;
}// Fin des ajouts

Console.WriteLine("Affichage des valeures du tableau :");
foreach (int num in numbers)
{
    //Console.WriteLine(char.ConvertFromUtf32(num));
    Console.WriteLine((char)num);
    Console.Write(string.Concat(Enumerable.Repeat(" ", space)));
    space += 2;
}


