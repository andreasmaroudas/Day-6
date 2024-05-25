using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Wizard : Hero
    {
        public Wizard() : base("Wizard")
        {
        }
        public Wizard(string name) : base(name)
        {
        }

        

        public void Heal()
        {
            if (Mana >= 15)
            {
                Console.WriteLine($"{Name} casts a healing spell.");
                Health += 20; 
                Mana -= 15; 
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough mana to heal.");
            }
        }
        public void CastSpell(string spell)
        {
            if (Mana >= 10)
            {
                Console.WriteLine($"{Name} casts {spell}!");
                Mana -= 10; 
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough mana to cast {spell}.");
            }
        }


        
    }
}
