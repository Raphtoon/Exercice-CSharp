
Console.WriteLine("Les suites chaînées de nombres!");
Console.Write("Merci de saisir un nombre : ");

if (int.TryParse(Console.ReadLine(), out int nbrValidate))
{
    Console.WriteLine($"Les chaînes possibles sont :");

    for (int i = 1; i <= nbrValidate; i++)
    {
        int sum = 0;
        string strFinish = "";

        for (int j = i; j <= nbrValidate - 1; j++)
        {
            sum += j;
            strFinish += $"{j}+";
            if (sum == nbrValidate)
            {
                Console.WriteLine($"{nbrValidate} = {strFinish.Trim('+')}");
                break;
            }
            else if (sum > nbrValidate)
            {
                break;
            }
        }
    }
}
else
{
    Console.WriteLine("Entrez un nombre valide");
}



Console.WriteLine("Les suites chaînées de nombres!");
Console.Write("Merci de saisir un nombre : ");

if (int.TryParse(Console.ReadLine(), out int nbrUser))
{
    Console.WriteLine($"Les chaînes possibles sont :");

    int i = 1;

    while (i <= nbrUser)
    {
        int sum = 0;
        string strFinish = "";
        int j = i;

        while (j <= nbrUser - 1)
        {
            sum += j;
            strFinish += $"{j}+";

            if (sum == nbrUser)
            {
                Console.WriteLine($"{nbrUser} = {strFinish.Trim('+')}");
                break;
            }
            else if (sum > nbrUser)
            {
                break;
            }

            j++;
        }

        i++;
    }
}
else
{
    Console.WriteLine("Entrez un nombre valide");
}