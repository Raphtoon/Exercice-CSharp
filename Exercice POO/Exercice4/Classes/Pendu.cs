using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4.Classes
{
    internal class Pendu
    {
        // Attributs
        private string _masque;
        private int _nbrEssais = 0;
        private string _motMagique = "zartaeaz";

        public string Masque { get => _masque; set => _masque = value; }
        public int NbrEssais { get => _nbrEssais; set => _nbrEssais = value; }
        public string MotMagique { get => _motMagique; set => _motMagique = value; }


        public bool TestChar(char c)
        {

                for (int i = 0; i < MotMagique.Length; i++)
                MotMagique[i] = '*';
        }
        public bool TestWin()
        {
            if (!Masque.Contains("*"))
                return false;
            else
                return true;
        }
    }
}
// if char = i { replace char dans ta masque par i masque 