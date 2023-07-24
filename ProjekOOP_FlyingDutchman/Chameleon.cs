using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class Chameleon : Pet
    {
        public Chameleon(int health, int energy, int happiness, string name, int age, int ownerName) : base(health, energy, happiness, name, age, ownerName)
        {

        }
        public override void Feed()
        {
            Health += 30;
            Energy += 50;
        }
        public void Sleep()
        {
            Health += 60;
            Energy += 60;
        }

        public void ChangeColor()
        {
            throw new System.NotImplementedException();
        }
    }
}