using System;
using System.Collections.Generic;
using System.Text;

using Project.Entities;

namespace Project.GameServices
{
    public class EnemyGenerator : BaseGenerator<Enemy>
    {
        private Player currentPlayer;
        public void SetPlayer(Player player)
        {
            currentPlayer = player;
        }
        private List<string> bossNames = new List<string>()
        {
            "Король Орків",
            "Король Скелетів",
            "Темний Лорд",
            "Древній Дракон",
            "Демон"
        };
        public EnemyGenerator()
        {
            names.AddRange([
                "Гоблін",
                "Орк",
                "Скелет",
                "Зомбі",
                "Бандит",
                "Вовк",
                "Троль",
                "Відьма",
                "Павук",
                "Дракон"
            ]);
        }
        public override Enemy CreateOne()
        {
            return CreateOne(currentPlayer);
        }
        public Enemy CreateOne(Player player)
        {
            Random rnd = new Random();
            /*
            int gearPower = 0;

            if (player.Weapon != null)
                gearPower += player.Weapon.AttackBonus;

            if (player.Armor != null)
                gearPower += player.Armor.DefenseBonus;
            */

            int minLevel;
            int maxLevel;

            minLevel = Math.Max(1, player.Level - 1);
            maxLevel = player.Level + 1;

            /*
            if (gearPower == 0)
            {
                minLevel = Math.Max(1, player.Level - 1);
                maxLevel = player.Level + 1;
            }
            else
            {
                minLevel = Math.Max(1, player.Level - 1);
                maxLevel = player.Level + 2;
            }
            */

            int level = rnd.Next(minLevel, maxLevel + 1);

            int bossChance = 0;

            if (player.Level >= 3 && player.Level <= 5)
            {
                bossChance = 5;
            }
            else if (player.Level > 5)
            {
                bossChance = 10;
            }

            bool isBoss = false;

            if (GameSettings.GameDifficulty != Difficulty.Easy)
            {
                if (Form1.BossCooldown == 0)
                {
                    isBoss = rnd.Next(100) < bossChance;
                }
            }

            string enemyName;
            int attack = level * 3;
            int defense = level * 2;
            int health = level * 30;

            if (isBoss)
            {
                Form1.BossCooldown = 5;

                enemyName = bossNames[rnd.Next(bossNames.Count)];

                level += 3;

                attack = level * 5;
                defense = level * 4;
                health = level * 60;
            }
            else
            {
                enemyName = names[rnd.Next(names.Count)];
            }

            return new Enemy
            {
                Name = enemyName,
                Level = level,
                Attack = attack,
                Defense = defense,
                MaxHealth = health,
                Health = health,
                IsBoss = isBoss
            };
        }
    }
}
