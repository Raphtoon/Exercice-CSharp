using System.Text.RegularExpressions;


Console.WriteLine("Saisissez une ADN comprenant 'a' 't' 'c' 'g' ");
string inputUser = Console.ReadLine()!.ToLower()!;

bool VerifAdn(string inputValid)
{
    if (inputValid == "")
        return false;
    foreach (char ch in inputValid)
        if (!"actg".Contains(ch))
        {
            return false;
        }
    return true;
}


string SaisieAdn(string input)
{
    if (VerifAdn(input))
        return input;
    else return "bad";
}

SaisieAdn(inputUser);

Console.WriteLine("Nombre d'occurence");
double proportion(string sequence = "aa", string chaine = "aaaa")
{
    int countSimilar = Regex.Matches(chaine, sequence).Count();
    double pourcentage = (chaine.Count() / countSimilar);
    return pourcentage;
}
Console.WriteLine(proportion());

