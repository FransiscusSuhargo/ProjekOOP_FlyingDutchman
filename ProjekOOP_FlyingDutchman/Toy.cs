using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjekOOP_FlyingDutchman
{
    [Serializable]
    public class Toy
    {
        private string name;
        private int happinessGiven;

        public Toy(string name, int happinessGiven)
        {
            this.Name = name;
            this.HappinessGiven = happinessGiven;
        }

        public string Name { get => name; set => name = value; }
        public int HappinessGiven { get => happinessGiven; set => happinessGiven = value; }
    }
}
