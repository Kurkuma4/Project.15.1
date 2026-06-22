using System;
using System.Collections.Generic;
using System.Text;

using Project.Entities;

namespace Project.GameServices
{
    public class EnemyGenerator : BaseGenerator<Enemy>
    {
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
            return CreateOne(1);
        }
        public Enemy CreateOne(int playerLevel)
        {
            Random rnd = new Random();

            int minLevel = Math.Max(1, playerLevel - 1);
            int maxLevel = playerLevel + 2;

            int level = rnd.Next(minLevel, maxLevel + 1);

            return new Enemy
            {
                Name = names[rnd.Next(names.Count)],
                Level = level,
                Attack = level * 3,
                Defense = level * 2,
                MaxHealth = level * 30,
                Health = level * 30,
            };
        }
    }
}
