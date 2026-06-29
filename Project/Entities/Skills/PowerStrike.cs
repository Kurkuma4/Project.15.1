using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project.Entities.Skills
{
    public class PowerStrike : BaseSkill
    {
        public PowerStrike(Player plr) : base("Потужний удар", 20, plr)
        {
        }
        public override ResultUseSkill use(Enemy enemy)
        {
            if (!checkCost())
                return new ResultUseSkill(false, 0, "Недостатньо мани!", Color.Orange);

            int damage = this.plr.CalculateAttackPower() * 2;
            if (plr.HasBerserkBuff)
            {
                damage = (int)(damage * 1.2);
                plr.HasBerserkBuff = false;
            }
            enemy.TakeDamage(damage);

            return new ResultUseSkill(true, damage, $"{plr.Name} використовує СИЛЬНУ АТАКУ і наносить {damage} шкоди!", Color.DarkRed);
        }
    }
}
