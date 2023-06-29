using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class Toy
    {
        private string name;
        private int price;
        private string suitablePet;
        private int energySpent;
        private int happinessGiven;

        public Pet Pet
        {
            get => default;
            set
            {
            }
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string SuitablePet { get => suitablePet; set => suitablePet = value; }
        public int EnergySpent { get => energySpent; set => energySpent = value; }
        public int HappinessGiven { get => happinessGiven; set => happinessGiven = value; }
    }
}