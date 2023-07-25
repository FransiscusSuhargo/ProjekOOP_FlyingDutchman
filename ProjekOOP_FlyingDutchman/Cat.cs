using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public class Cat : Pet
    {
        bool vaccinated;

        public bool Vaccinated { get => vaccinated; set => vaccinated = value; }

        public Cat(string name, string ownerName) : base(name, ownerName)
        {
            Vaccinated = false; 
        }
        public override int Feed()
        {
            int prevHealth = Health;
            int prevEnergy = Energy; 
            Health += 30;
            Energy += 50;
            int coin = (Health - prevHealth) + (Energy - prevEnergy) * 50;
            return coin;
        }
        public int Play(Toy toy)
        {
            int prevHappiness = Happiness;
            int prevEnergy = Energy;
            Happiness += toy.HappinessGiven;
            Energy -= 30;
            int coin = (Happiness - prevHappiness) * 50;
            return coin;
        }

        public int Sleep()
        {
            int prevHealth = Health;
            int prevEnergy = Energy;
            Health += 20;
            Energy += 70;
            int coin = (Health - prevHealth) + (Energy - prevEnergy) * 50;
            return coin;
        }

        public int Bath()
        {
            int prevHealth = Health;
            Health += 30;
            int coin = (Health - prevHealth) * 50;
            return coin;
        }

        public int Vaccinate()
        {
            int prevHealth = Health;
            Health += 40;
            int coin = (Health - prevHealth) * 50;
            Vaccinated = true;
            return coin;
        }
    }
}