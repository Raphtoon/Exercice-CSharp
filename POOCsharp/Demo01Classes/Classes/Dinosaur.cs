using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes.Classes
{
    internal class Dinosaur
    {
        // Attributs
        private int _age = 5;
        private string _espece;
        private int _nbPattes;
        private double _poids;
        private bool _peutVoler = true;

        // prop+tab autocompletion =  public int MyProperty { get; set; }

        // Encapsulation dans les propriétés.
        public int Age { get => _age; set => _age = value; }
        public string Espece { get => _espece; set => _espece = value; }
        public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
        //public double Poids { get => _poids; set => _poids = value; }

        public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }
        public Dinosaur()
        {
            
        }
    }


}
