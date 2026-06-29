using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project.Entities.Skills
{
    public class Heal : BaseSkill
    {
        public Heal(Player plr) : base("Лікування", 15, plr)
        {
        }
        public override ResultUseSkill use(Enemy enemy)
        {
            if (!checkCost())
                return new ResultUseSkill(false, 0, "Недостатньо мани!", Color.Orange);

            int healAmount = this.plr.Intelligence * 5;

            this.plr.Heal(healAmount);

            return new ResultUseSkill(true, healAmount, $"{plr.Name} лікується і відновлює HP {healAmount}!", Color.Green);
        }
    }
}
