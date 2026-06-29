using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Armor
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int DefenseBonus { get; set; }

        public override string ToString()
        {
            return $"{Name} | Захист +{DefenseBonus} | {Price} золота";
        }
    }

}
