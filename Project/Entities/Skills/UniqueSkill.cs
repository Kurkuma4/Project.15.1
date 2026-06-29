using System;
using System.Drawing;

namespace Project.Entities.Skills
{
    public class UniqueSkill : BaseSkill
    {
        public UniqueSkill(Player plr) : base("Berserk Strike", 20, plr)
        {
        }

        public override ResultUseSkill use(Enemy enemy)
        {

            if (plr.Name == "Barbarian")
            {
                cost = 20;
                cooldown = 4;
            }
            else if (plr.Name == "Elf")
            {
                cost = 25;
                cooldown = 6;
            }
            else if (plr.Name == "Mage")
            {
                cost = 40;
                cooldown = 5;
            }
            if (!IsReady())
                return new ResultUseSkill(false, 0, "Навичка на перезарядці!", Color.Gray);

            if (!checkCost())
                return new ResultUseSkill(false, 0, "Недостатньо мани!", Color.Orange);

            ResultUseSkill result;

            SetCooldown();

            if (plr.Name == "Barbarian")
                return UseBarbarianSkill(enemy);
            else if (plr.Name == "Elf")
                return UseElfSkill(enemy);
            else
                result = UseMageSkill(enemy);

            
            return result;
        }
        private ResultUseSkill UseBarbarianSkill(Enemy enemy)
        {
            int damage = (int)(plr.CalculateAttackPower() * 2);

            damage += enemy.Defense / 4;

            enemy.TakeDamage(damage);

            plr.HasBerserkBuff = true;

            return new ResultUseSkill(
                true,
                damage,
                $"🪓 {plr.Name} використовує Удар берсерка та завдає {damage} шкоди!",
                Color.DarkRed);
        }

        private ResultUseSkill UseElfSkill(Enemy enemy)
        {
            int damage = (int)((plr.CalculateAttackPower() * 1.5) + (enemy.Defense / 2));

            enemy.Health -= damage;

            if (enemy.Health < 0)
                enemy.Health = 0;

            if (new Random().Next(100) < 50)
            {
                enemy.Health -= damage;

                if (enemy.Health < 0)
                    enemy.Health = 0;

                return new ResultUseSkill(
                true,
                damage,
                $"🏹 {plr.Name} використовує Подвійну пронизливу стрілу та завдає {damage * 2} шкоди!",
                Color.Green);
            }
            else 
            {
                return new ResultUseSkill(
                true,
                damage,
                $"🏹 {plr.Name} використовує Пронизливу стрілу та завдає {damage} шкоди!",
                Color.Green);
            }
        }

        private ResultUseSkill UseMageSkill(Enemy enemy)
        {
            int damage = (int)(plr.CalculateAttackPower() * 3);

            damage += enemy.Defense / 4;

            enemy.TakeDamage(damage);

            if (new Random().Next(100) < 30)
            {
                enemy.BurnTurns = 2;
                enemy.BurnStartsNextTurn = true;
            }

            return new ResultUseSkill(
                true,
                damage,
                $"🔥 {plr.Name} використовує Вогняну кулю та завдає {damage} шкоди!",
                Color.OrangeRed);
        }
        public bool IsReady()
        {
            return currentCooldown == 0;
        }

        public void SetCooldown()
        {
            currentCooldown = cooldown;
            plr.UniqueSkillCooldown = currentCooldown;
        }

        public void TickCooldown()
        {
            if (currentCooldown > 0)
            {
                currentCooldown--;
                plr.UniqueSkillCooldown = currentCooldown;
            }
        }
        public void LoadCooldown(int cd)
        {
            currentCooldown = cd;
        }
    }
}
