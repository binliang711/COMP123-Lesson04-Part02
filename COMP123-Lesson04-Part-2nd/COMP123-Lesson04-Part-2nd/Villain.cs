using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part_2nd
{
    class Villain : Character
    {
        //PRIVATE PROPERTIES+++++++++++++++++++++++++++++++++++++++
        private bool greed = true;

        public Villain(string name, int health, int smarts, string gender) :
            base(name, health, smarts, gender)
        {
            this.showProfile();
        }

        //PUBLIC METHODS++++++++++++++++++++++++++++++++++++++++++++++
        public void doesBadThings()
        {
            Console.WriteLine("Doing bad things...YEAH!");
        }

    }
}
