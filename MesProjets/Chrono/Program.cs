using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Appuyez sur une touche pour commencer le clignotement.");
        Console.ReadKey();
        Thread blinkThread = new Thread(Blink);
        blinkThread.Start();
        Console.WriteLine("Le programme continue à s'exécuter.");
        blinkThread.Join();
        Console.WriteLine("Appuyez sur une touche pour quitter.");
        Console.ReadKey();
    }
    static void Blink()
    {
        while (true)
        {
            Console.Clear(); // Efface la console
            Console.Write("Contenu clignotant");
            Thread.Sleep(300); // Temps d'attente (en millisecondes)
            Console.Clear(); // Efface la console
            Thread.Sleep(300); // Temps d'attente (en millisecondes)
        }
    }
}