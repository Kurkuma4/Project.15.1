using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Enemy
    {
        public string Name;

        public int Level;

        public int Attack;
        public int Defense;

        public int Health;
        public int MaxHealth;

        public bool IsBoss;

        public int RewardGold;
        public int RewardXP;

        public int BurnTurns = 0;
        public bool BurnStartsNextTurn = false;
        public void TakeDamage(int damage)
        {
            damage -= Defense / 2;

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