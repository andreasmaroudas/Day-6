using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Necromancer : Hero
    {
        public bool Imune { get; set; }
        public Necromancer() : base("Necromancer")
        {
        }
        public Necromancer(string name) : base(name)
        {
        }
        public override void TakeDamage(int incomingDamage)
        {
            int n = Random.Shared.Next(0, 100);
            if (n <= 50 || Imune)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int n = Random.Shared.Next(0, 100);
            if (n <= 10)
            {
                baseAttack = Strength * 4;
            }
            return baseAttack;
        }
    }
}
