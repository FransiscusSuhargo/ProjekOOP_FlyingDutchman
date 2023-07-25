using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public class User
    {
        private string name;
        private int coin;
        private Pet pet;
        private List<Toy> listOfToys; 

        public User(string name, Pet pet)
        {
            this.Name = name;
            Coin = 100; 
            this.Pet = pet;
            ListOfToys = new List<Toy>();
        }

        public string Name { get => name; set => name = value; }
        public int Coin { get => coin; set => coin = value; }
        public Pet Pet { get => pet; set => pet = value; }
        public List<Toy> ListOfToys { get => listOfToys; set => listOfToys = value; }

        public void AddCoins(int coins)
        {
            Coin += coins; 
        }
        public void DeductCoins(int coins)
        {
            Coin -= coins;
        }
    }
}