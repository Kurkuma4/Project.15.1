using Project.Entities;

namespace Project.GameServices
{
    public class WeaponGenerator
    {
        Random rnd = new Random();

        private string[] names =
        {
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
        };

        public Weapon CreateOne()
        {
            int attack = rnd.Next(1, 11);

            return new Weapon
            {
                Name = names[rnd.Next(names.Length)],
                AttackBonus = attack,
                Price = attack * 20
            };
        }

        public List<Weapon> CreateMany(int count)
        {
            List<Weapon> weapons = new List<Weapon>();

            for (int i = 0; i < count; i++)
            {
                weapons.Add(CreateOne());
            }

            return weapons;
        }
    }
}
