using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class Pet
    {
        private int health;
        private int energy;
        private int happiness;
        private string name;
        private int age;
        private int ownerName;

        public Pet(int health, int energy, int happiness, string name, int age, int ownerName)
        {
            this.Health = health;
            this.Energy = energy;
            this.Happiness = happiness;
            this.Name = name;
            this.Age = age;
            this.OwnerName = ownerName;
        }

        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int OwnerName { get => ownerName; set => ownerName = value; }

        public void Feed()
        {
            throw new System.NotImplementedException();
        }
    }
}