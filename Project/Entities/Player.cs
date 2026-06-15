using Project.Entities.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Player
    {
        public string Name = "";

        public int Level = 0;
        public int Experience = 0;

        public int Strength = 0;
        public int Endurance = 0;
        public int Agility = 0;
        public int Intelligence = 0;
        public int Mana = 0;

        public int Gold = 0;

        public Weapon Weapon = null;
        public Armor Armor = null;
        public int MaxHealth => Endurance * 10;
        public int Health = 0;

        public int MaxMana => Intelligence * 5;

        public List<BaseSkill> skills;

        public Player()
        {
            skills = new List<BaseSkill>();

            skills.Add(new Strike(this));
            skills.Add(new PowerStrike(this));
            skills.Add(new Heal(this));
            skills.Add(new Rest(this));
        }

        public void ResetStats()
        {
            Health = MaxHealth;
            Mana = MaxMana;
        }
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
        public void TakeDamage(int damage)
        {
            damage -= CalculateDefense() / 2;

            if (damage < 1)
                damage = 1;

            Health -= damage;

            if (Health < 0)
                Health = 0;
        }

        public void Heal(int value)
        {
            Health += value;

            if (Health > MaxHealth)
                Health = MaxHealth;
        }
    }
}
