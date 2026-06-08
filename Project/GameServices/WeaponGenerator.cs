using Project.Entities;

namespace Project.GameServices
{
    public class WeaponGenerator : BaseGenerator<Weapon>
    {
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
            int attack = rnd.Next(1, 11);

            return new Weapon
            {
                Name = names[rnd.Next(names.Count)],
                AttackBonus = attack,
                Price = attack * 20
            };
        }
    }
}
