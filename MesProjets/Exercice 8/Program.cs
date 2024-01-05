Console.WriteLine("--------------- Calcul de la TVA ---------------");
Console.Write("Entrez le prix HT en €");
float price = float.Parse(Console.ReadLine());
Console.Write("Entrez le taux de TVA en % ");
float rate = float.Parse(Console.ReadLine());

float tva = (price * rate) / 100;
Console.WriteLine($"Le taux de tva s'élève à {tva} euros");
float ttl = price + tva;
Console.WriteLine($"Le prix TTC est de {ttl} euros ");