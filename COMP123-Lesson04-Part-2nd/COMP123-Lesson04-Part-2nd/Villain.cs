using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part_2nd
{
    class Villain : Hero
    {
        //PRIVATE PROPERTIES+++++++++++++++++++++++++++++++++++++++
        private string name;

        public Villain(string name, int health, int smarts, string gender)
            : base(health, smarts, gender)
        {
            this.name = name;

        }

        //PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++
        public void doesBadThings()
        {
            Console.WriteLine("Doing bad things...YEAH!");
        }
    }
}
