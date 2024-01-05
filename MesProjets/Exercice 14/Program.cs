// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quelle taille dois-je prendre ?");

Console.Write("Entrez votre taille en cm");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Entrez votre poids en kg");
int weight = int.Parse(Console.ReadLine()!);

if ((size < 145 || size > 183) || (weight < 43 || weight > 77))
{
    Console.WriteLine("On n'a pas ta taille");
    return;
}
// Taille 2
else if (((size >= 169 && size <= 178 && weight >= 48 && weight <= 53)) || ((size >= 166 && size <= 175 && weight >= 54 && weight <= 59)) || ((size >= 163 && size <= 172 && weight >= 60 && weight <= 65)) || (size >= 160 && size <= 169 && weight >= 65 && weight <= 71))
{
    Console.WriteLine("Prenez la taille 2");
}
// Taille 3
else if (((size >= 178 && size <= 183 && weight >= 54 && weight < 59)) || (size >= 175 && size <= 183 && weight >= 60 && weight < 65) || ((size >= 172 && size <= 183 && weight >= 66 && weight < 71)) || (size >= 163 && size <= 183 && weight >= 72 && weight < 77))
{
    Console.WriteLine("Prenez la taille 3");
}
// Après avoir vérifié si on a la taille correspondante au critère du client 
else
{
    Console.WriteLine("Prenez la taille 1");
}