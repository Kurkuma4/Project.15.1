using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AttackBonus { get; set; }

        public override string ToString()
        {
            return $"{Name} | Атака +{AttackBonus} | {Price} золота";
        }
    }
}
