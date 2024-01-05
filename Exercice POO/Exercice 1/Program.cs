
using Exercice_1.Classes;

Chaise chaise1 = new Chaise();
Chaise chaise2 = new Chaise(5, "métal", "orange");
chaise2.Materiaux = "Taule";
chaise2.ToString();

// Avec une liste
var listChaise = new List<Chaise> { chaise1, chaise2 };
foreach (Chaise chaise in listChaise)
{
    chaise.displaySet();
}

// Avec un tableau
Chaise[] chaises = // new Chaise[3]
{
    new Chaise(),
    new Chaise(3, "Métal", "Noire"),
    new Chaise(4, "Plastique", "Bleue")
};
chaises[0].displaySet();
foreach (Chaise chaise in chaises)
{
    chaise.displaySet();
}


