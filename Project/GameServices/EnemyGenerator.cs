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
            int level = rnd.Next(1, 6);

            return new Enemy
            {
                Name = names[rnd.Next(names.Count)],
                Level = level,
                Attack = level * 3,
                Defense = level * 2,
                MaxHealth = level * 30,
                Health = level * 30,
                RewardGold = level * 20,
                RewardXP = level * 15
            };
        }
    }
}
