using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Armor
    {
        public string Name;
        public int Price;
        public int DefenseBonus;

        public override string ToString()
        {
            return $"{Name} | Захист +{DefenseBonus} | {Price} золота";
        }
    }

}
