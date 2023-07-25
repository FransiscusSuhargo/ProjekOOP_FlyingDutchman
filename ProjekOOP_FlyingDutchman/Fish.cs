using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public class Fish : Pet
    {
        public Fish(string name, string ownerName) : base(name, ownerName)
        {

        }
        public override int Feed()
        {
            int prevHealth = Health;
            int prevEnergy = Energy; 
            Health += 20;
            Energy += 40;
            int coin = (Health - prevHealth) + (Energy - prevEnergy) * 50;
            return coin;
        }
        public void Clean()
        {
            Health += 60;
            Energy += 50;
            //Coins -= 500;
        }
    }
}