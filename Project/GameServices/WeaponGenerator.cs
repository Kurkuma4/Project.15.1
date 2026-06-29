using Project.Entities;

namespace Project.GameServices
{
    public class WeaponGenerator : BaseGenerator<Weapon>
    {
        private Player player;

        public void SetPlayer(Player player)
        {
            this.player = player;
        }
        public WeaponGenerator()
        {
            this.names.AddRange([
                "Меч",
                "Сокира",
                "Кинджал",
                "Булава",
                "Молот",
                "Спис",
                "Катана",
                "Лісовий ніж",
                "Палка",
                "Шабля"
            ]);
        }
            public override Weapon CreateOne()
        {
            int minAttack = 1;
            int maxAttack = 10;

            if (player != null)
            {
                minAttack = Math.Max(1, player.Level - 2);
                maxAttack = player.Level + 3;
            }

            int attack = rnd.Next(minAttack, maxAttack + 1);

            return new Weapon
            {
                Name = names[rnd.Next(names.Count)],
                AttackBonus = attack,
                Price = attack * 20
            };
        }
    }
}
