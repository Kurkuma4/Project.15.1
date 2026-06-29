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
                return new ResultUseSkill(false, 0, "Недостатньо мани!", Color.Orange);

            Random random = new Random();

            int damage = this.plr.CalculateAttackPower();

            if (plr.HasBerserkBuff)
            {
                damage = (int)(damage * 1.2);
                plr.HasBerserkBuff = false;
            }

            if (random.Next(100) < 20)
            {
                damage *= 2;
                enemy.TakeDamage(damage);

                return new ResultUseSkill(
                    true,
                    damage,
                    $"💥 КРИТИЧНИЙ УДАР!\n{plr.Name} наносить {damage} шкоди!",
                    Color.Red);
            }

            enemy.TakeDamage(damage);

            return new ResultUseSkill(
                true,
                damage,
                $"{plr.Name} атакує і наносить {damage} шкоди!",
                Color.Blue);
        }
    }
}
