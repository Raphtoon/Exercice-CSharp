Console.WriteLine("--------------- Calcul de la longueur de l'hypothénuse ---------------");
Console.Write("Entrez la longueur du premier côté (en cm) : ");
double nbOne = double.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du deuxième côté (en cm) : ");
double nbTwo = double.Parse(Console.ReadLine());
Console.WriteLine($"La longueur de l'hypothénuse est : {Math.Sqrt(Math.Pow(nbOne, 2) + Math.Pow(nbTwo, 2))}cm");
