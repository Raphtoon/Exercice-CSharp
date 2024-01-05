Console.WriteLine("--------------- Calcul du périmètre et de l'aire d'un carré! ---------------");
Console.Write("Entrez la longueur d'un côté du carré (en cm) : ");
float nbOne = float.Parse(Console.ReadLine());
float perimetre = nbOne * 4;
double aire = Math.Pow(nbOne, 2);
Console.WriteLine($"Le périmètre du carré est  : {perimetre} cm");
Console.WriteLine($"Le'aire du carré est  : {aire} cm²");


Console.WriteLine("--------------- Calcul du périmètre et de l'aire d'un rectangle! ---------------");
Console.Write("Entrez la longueur du rectangle (en cm) : ");
float longueur = float.Parse(Console.ReadLine());
Console.Write("Entrez la largeur du rectangle (en cm) : ");
float largeur = float.Parse(Console.ReadLine());
float perimetreRect = (largeur + longueur) * 2;
float aireRect = longueur * largeur;
Console.WriteLine($"Le périmètre du rectangle est  : {perimetreRect}");
Console.WriteLine($"L'aire du rectangle est  : {aireRect} cm²");
