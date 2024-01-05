// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quelle est la nature du triangle ABC ?");

Console.Write("Entrez la longueur du segment AB ?");
string ab = Console.ReadLine();
Console.Write("Entrez la longueur du segment BC ?");
string bc = Console.ReadLine();
Console.Write("Entrez la longueur du segment CA ?");
string ca = Console.ReadLine();


if (ab != bc && bc != ca && ca != ab)
{
    Console.WriteLine("le triangle est quelconque");
}
else if (ab == bc && bc == ca && ca == ab)
{
    Console.WriteLine("Le triangle est équilatéral");
}
else if (ab == bc)
{
    Console.WriteLine("Le triangle est isocèle en B!");
}
else if (bc == ca)
{
    Console.WriteLine("Le triangle est isocèles en C!");
}
else
{
    Console.WriteLine("Le triangle est isocèle en A!");
}
