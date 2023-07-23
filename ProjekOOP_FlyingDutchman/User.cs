using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjekOOP_FlyingDutchman
{
    public class User
    {
        private string name;
        private int coin;
        private List<Pet> listOfPets = new List<Pet>();

        public string Name { get => name; set => name = value; }
        public int Coin { get => coin; set => coin = value; }
        public List<Pet> ListOfPets { get => listOfPets; set => listOfPets = value; }

        public void AddNewPet()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayPreviousPets()
        {
            throw new System.NotImplementedException();
        }
    }
}