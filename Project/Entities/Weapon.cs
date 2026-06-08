using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Weapon
    {
        public string Name;
        public int Price;
        public int AttackBonus;

        public override string ToString()
        {
            return $"{Name} | Атака +{AttackBonus} | {Price} золота";
        }
    }
}
