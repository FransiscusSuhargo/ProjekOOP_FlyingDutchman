using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class Cat : Pet
    {
        public Cat(int health, int energy, int happiness, string name, int age, int ownerName) : base(health, energy, happiness, name, age, ownerName)
        {

        }
        public void Play()
        {
            Happiness += 50;
            Energy -= 30;
        }

        public void Sleep()
        {
            Health += 20;
            Energy += 70;
        }

        public void Bath()
        {
            Health += 30;
        }

        public void Vaccinate()
        {
            Health += 40;
            //Coins -= 1000;
        }
    }
}