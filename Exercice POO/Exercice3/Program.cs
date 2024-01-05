using Exercice3.Classes;

int index = 1;


Citerne[] citernes = new Citerne[]
{
new Citerne(5000, 15000,30),
new Citerne(70, 2000,30),
};

foreach (Citerne citerne in citernes)
{
    Console.WriteLine($"Poids total dans la citerne {index}: {citerne.WeightActual()}");
    index++;
}

Citerne.QuantityAll();
citernes[0].AddWater(500);
Console.WriteLine($"Poids de la citerneOne après ajout d'eau : {citernes[0].WeightActual()}");
Console.WriteLine($"Poids a vide {citernes[0].MinWeight}");
citernes[0].SubWater(30);
Console.WriteLine($"Poids de la citerneOne après soustraction d'eau : {citernes[0].WeightActual()}");

Citerne.QuantityAll();
