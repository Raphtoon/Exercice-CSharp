using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice_1.Classes
{

    internal class Chaise
    {
        // Attributs
        private int _nbrPied = 4;
        private string _materiaux;
        private string _couleur;

        //Propriété
        public int NbrPied { get => _nbrPied; set => _nbrPied = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        public Chaise() //constructeur par défaut
        {
            NbrPied = 2;
            Materiaux = "Plastique";
            Couleur = "Bleu";
        }

        public Chaise(int nbrPied, string materiaux, string couleur)
        {
            _nbrPied = nbrPied;
            _materiaux = materiaux;
            _couleur = couleur;
        }

        //auto property
        //public int NbrPied { get; set; } = 4;
        //public string Materiaux { get; set; } = "Bois";
        //public string Couleur { get; set; } = "Noir";

        // Méthode
        public void displaySet()
        {
            //Console.WriteLine($"La chaise à {NbrPied} pied(s), elle à été fabriqué avec du {Materiaux} et est de couleur {Couleur}");
            Console.WriteLine(ToString());
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"La chaise à {NbrPied} pied, elle à été fabriqué avec du {Materiaux} et est de couleur {Couleur}";
        }
    }
}
