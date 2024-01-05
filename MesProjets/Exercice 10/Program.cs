Console.WriteLine("La lettre est-elle une voyelle ?");

string entreeUtilisateur = Console.ReadLine();
string saisie = "aeiouy";


if (entreeUtilisateur.Length > 2)
{
    Console.WriteLine("Entrez seulement un caractère.!");
}
else if (saisie.Contains(entreeUtilisateur))
{
    Console.WriteLine("Voyellllleeeeeesssssssssss!");
}
else
{
    Console.WriteLine("consonne ! :(");
}