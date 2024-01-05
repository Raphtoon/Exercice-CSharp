Console.WriteLine("Hello, World!");
string[] months = { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
string tab = "";
foreach (string month in months)
{
    Console.Write(tab);
    Console.WriteLine(month);
    tab += "\t";
}
