using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class Fish : Pet
    {
        public Fish(int health, int energy, int happiness, string name, int age, int ownerName) : base(health, energy, happiness, name, age, ownerName)
        {

        }

        public void Clean()
        {
            Health += 60;
            Energy += 50;
            //Coins -= 500;
        }
    }
}