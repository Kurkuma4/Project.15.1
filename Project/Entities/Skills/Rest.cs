using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project.Entities.Skills
{
    public class Rest : BaseSkill
    {
        public Rest(Player plr) : base("Відпочинок", 0, plr)
        {
        }

        public override ResultUseSkill use(Enemy enemy)
        {
            this.plr.Mana += 20;

            if (this.plr.Mana > this.plr.MaxMana)
                this.plr.Mana = this.plr.MaxMana;

            return new ResultUseSkill(true, 20, $"{plr.Name} відпочиває і відновлює ману!", Color.Blue);
        }
    }
}
