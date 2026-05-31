using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Player
    {
        public string Name;

        public int Level;
        public int Experience;

        public int Strength;
        public int Endurance;
        public int Agility;
        public int Intelligence;
        public int Mana;

        public int Gold;

        public Weapon Weapon;
        public Armor Armor;
        public int MaxHealth => Endurance * 10;
        public int Health => MaxHealth;

        public int MaxMana => Intelligence * 5;

        public int CalculateAttackPower()
        {
            int weaponBonus = Weapon != null ? Weapon.AttackBonus : 0;
            return Strength + weaponBonus;
        }

        public int CalculateDefense()
        {
            int armorBonus = Armor != null ? Armor.DefenseBonus : 0;
            return Agility + armorBonus;
        }
    }
}
