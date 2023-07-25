using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public abstract class Pet
    {
        private int health;
        private int energy;
        private int happiness;
        private string name;
        private string ownerName;

        public Pet(string name, string ownerName)
        {
            Health = 100;
            Energy = 100;
            Happiness = 100; 
            this.Name = name;
            this.OwnerName = ownerName;
        }

        public int Health 
        { 
            get => health;
            set
            {
                if(value <= 10)
                {
                    health = 10; 
                }
                else if(health > 100)
                {
                    health = 100; 
                }
                else
                {
                    health = value; 
                }
            }
        }
        public int Energy 
        { 
            get => energy;
            set
            {
                if (value <= 10)
                {
                    energy = 10;
                }
                else if(value > 100)
                {
                    energy = 100;
                }
                else
                {
                    energy = value;
                }
            } 
        }
        public int Happiness 
        { 
            get => happiness;
            set
            {
                if (value <= 10)
                {
                    happiness = 10;
                }
                else if(value > 100)
                {
                    happiness = 100; 
                }
                else
                {
                    happiness = value;
                }
            }
        }
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
        public string OwnerName { get => ownerName; set => ownerName = value; }

        public abstract int Feed();

        public void ReduceStatusOvertime() //Berkurang 5 persen setiap detiknya
        {
            Health -= 5;
            Energy -= 5;
            Happiness -= 5;
        }

        public void CheckingStatus(out string health, out string energy, out string happiness) //Untuk mengecek status setiap peliharaan, apakah Game Over atau belum
        {
            health = "Very Good";
            energy = "Strong";
            happiness = "Happy";
            if(Happiness >= 10 && Happiness <= 25)
            {
                health = "Very Poor";
            }
            else if (Happiness >= 26 && Happiness <= 60)
            {
                health = "Poor";
            }
            else if (Happiness >= 61 && Happiness <= 80)
            {
                health = "Good";
            }
            else if (Happiness >= 80 && Happiness <= 100)
            {
                health = "Very Good";
            }
            if (Energy >= 10 && Energy <= 50)
            {
                energy = "Weak";
            }
            else if (Energy >= 51 && Energy <= 75)
            {
                energy = "Moderate";
            }
            else if (Energy >= 76 && Energy <= 100)
            {
                energy = "Strong";
            }
            if (Happiness >= 10 && Happiness <= 60)
            {
                happiness = "Unhappy";
            }
            else if (Happiness >= 61 && Happiness <= 100)
            {
                happiness = "Happy";
            }
        }
    }
}