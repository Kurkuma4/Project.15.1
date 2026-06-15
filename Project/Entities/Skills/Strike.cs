using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project.Entities.Skills
{
    public class Strike : BaseSkill
    {
        public Strike(Player plr) : base("Удар", 10, plr)
        {
        }

        public override ResultUseSkill use(Enemy enemy)
        {
            if (!checkCost())
                return new ResultUseSkill(false, 0, "", Color.Black);
            int damage = this.plr.CalculateAttackPower();
            enemy.TakeDamage(damage);

            return new ResultUseSkill(true, damage, $"{plr.Name} атакує і наносить {damage} шкоди!", Color.Blue);
        }
    }
}
