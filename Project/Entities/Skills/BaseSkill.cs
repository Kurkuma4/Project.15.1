using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Skills
{
    public abstract class BaseSkill
    {
        int id;
        protected string name;
        protected int cost;
        protected Player plr;

        public int Id { get => id; }
        public string Name { get => name; }
        public int Cost { get => cost; }

        public BaseSkill(string name, int cost, Player plr)
        {
            this.name = name;
            this.cost = cost;
            this.plr = plr;
        }

        protected bool checkCost()
        {
            if (this.plr.Mana >= cost)
            {
                this.plr.Mana -= cost;
                return true;
            }

            return false;
        }

        public abstract ResultUseSkill use(Enemy enemy);
    }
}
