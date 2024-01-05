Console.WriteLine("--------------- Calcul des intérêts ---------------");
Console.Write("Entrez le capitale de départ en Euros : ");
double startAmmount = double.Parse(Console.ReadLine());
Console.Write("Entrez le taux d'intérêt (en %) : ");
double rate = double.Parse(Console.ReadLine());
Console.Write("Entrez la durée de l'épargne (en années) ");
byte years = byte.Parse(Console.ReadLine());

double interet = startAmmount * Math.Pow(1 + rate / 100, years) - startAmmount;
Console.WriteLine($"Le taux d'intérêt sera de {interet} euros après {years} an(s)");
double ttl = startAmmount + interet;
Console.WriteLine($"Le capital final sera de {ttl:F2} ");