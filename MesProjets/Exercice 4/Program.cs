Console.Write("Veuillez saisir votre nom : ");
string lastname = Console.ReadLine();
Console.Write("Veuillez saisir votre prénom : ");
string firstname = Console.ReadLine();
Console.Write("Veuillez saisir votre âge : ");
int age = int.Parse(Console.ReadLine());
Console.Write($"Bonjour {firstname} {lastname} vous avez {age} ans");