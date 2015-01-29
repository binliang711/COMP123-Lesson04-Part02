using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part_2nd
{
    //HERO SUBCLASS OR CHARACER SUPER CLASS
    class Hero : Character
    {
        //PRIVATE PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool courage = true;

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name, int health, int smarts, string gender) :
            base(name, health, smarts, gender)
        {
            this.showProfile();
        }
        //PUBLIC METHODS
        public void doesGoodThings()
        {
            Console.WriteLine("Doing good things...YEAH!");
        }
    }
}
