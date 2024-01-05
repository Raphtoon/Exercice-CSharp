using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.Classes
{
    internal class Citerne
    {
        public static decimal AllContains { get; set; } = 0;

        public decimal MinWeight = 10; // Poids a vide
        public decimal MaxWater { get; set; } = 10000; // niveau d'eau max

        public decimal _water; // niveau d'eau
        public decimal Water 
        {
            get => _water;
            set
            {
                AllContains -= _water;
                _water = value;
                AllContains += _water;
            }
        }



        public Citerne(decimal water, decimal maxWater, decimal minweight = 10)
        {
            Water = water;
            MaxWater = maxWater;
            MinWeight = minweight;

        }

        public decimal WeightActual()
        {
            return Water;
        }

        public void AddWater(decimal moreWater)
        {
            if (MaxWater < (Water + moreWater))
                Console.WriteLine($"Impossible d'ajouter plus d'eau que ce que la citerne peut contenir. Excédent : {(Water + moreWater) - MaxWater}");
            else
            {
                Water += moreWater;
            }
        }

        public void SubWater(decimal lessWater = 6000)
        {
            if (Water < lessWater)
            { 
                Console.WriteLine($"Impossible de soustraire plus d'eau que ce que la citerne contient. Excédent : {(Water + lessWater) - MaxWater}");
                Console.WriteLine();
            }
            else
            {
                Water -= lessWater;
            }
        }

        public static void QuantityAll()
        {
            Console.WriteLine($"Quantité totale dans les citernes : {AllContains}");
        }
    }
}
