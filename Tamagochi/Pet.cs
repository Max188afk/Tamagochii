using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public abstract class pet
    {
        //public int Hunger { get; private set; } = 50;
        private int hunger = 50;
        public int Hunger
        {
            get
            { 
                 return hunger;
            }
            set
            {
                hunger = value;
            }
         }
        public int Boredom { get; private set; } = 50;
        public void Feed()
        {
            Hunger -= -15;
            Boredom += 15;
            Console.WriteLine("Feeding");
        }
        public void Play()
        {
            Hunger += 30;
            Boredom -= 15;
            Console.WriteLine("Playing");
        }
        public bool isAlive()
        {
            if(Hunger>100 || Hunger<0)
            {
                return false;
            }
            return true;
        }  
             
        public virtual string Whoami()
        {
            return "pet"; 
        }
    }
}
