using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public class Chameleon : Pet
    {
        public Chameleon(string name, string ownerName) : base(name, ownerName)
        {

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
        public int Sleep()
        {
            int prevHealth = Health;
            int prevEnergy = Energy;
            Health += 60;
            Energy += 60;
            int coin = (Health - prevHealth) + (Energy - prevEnergy) * 50;
            return coin;
        }

        public void ChangeColor()
        {
            throw new System.NotImplementedException();
        }
    }
}