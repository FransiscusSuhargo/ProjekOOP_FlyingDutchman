using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    public abstract class Pet
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
        public string Name 
        { 
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name field must not empty.");
                }
            }
        }
        public int Age { get => age; set => age = value; }
        public int OwnerName { get => ownerName; set => ownerName = value; }

        public abstract void Feed();

        public void ReduceStatusOvertime() //Berkurang 5 persen setiap detiknya
        {
            Health -= 5;
            Energy -= 5;
            Happiness -= 5;
        }

        public void CheckingStatus() //Untuk mengecek status setiap peliharaan, apakah Game Over atau belum
        {
            if (Health < 25 && Energy < 50 && Happiness < 60)
            {
                Application.Exit();
            }
        }
    }
}