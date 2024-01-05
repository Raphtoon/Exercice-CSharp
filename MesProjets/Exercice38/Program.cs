Console.WriteLine("Où est passé mon numéro ?");
Console.WriteLine("Affectation des valeurs");
int[] storageNbr = new int[10];
string tab = "";

for (int i = 0; i < storageNbr.Length; i++)
{
    Random rnd = new Random();
    storageNbr[i] = rnd.Next(1, 51);
}

int pos = storageNbr[0];
Console.WriteLine("Affichage avant triage");
foreach (int i in storageNbr)
{
    Console.Write(tab);
    Console.WriteLine(i);
    tab += "\t";
}

tab = "";
Console.WriteLine("Après triage : ");
Array.Sort(storageNbr);

foreach (int i in storageNbr)
{
    Console.Write(tab);
    Console.WriteLine(i);
    tab += "\t";


}

Console.WriteLine($"Le nombre {pos} était en 1ere position");
Console.WriteLine($"Il se retrouve en {Array.IndexOf(storageNbr, pos)+1}ème position, après triage");



