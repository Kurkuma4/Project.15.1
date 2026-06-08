using Project.Entities;

namespace Project.GameServices
{
    public class ArmorGenerator
    {
        Random rnd = new Random();

        private string[] names =
        {
            "Шкіряна броня",
            "Залізна броня",
            "Броня ельфа",
            "Броня орка",
            "Броня гнома",
            "Кольчуга",
            "Камуфляж",
            "Щит",
            "Магічний плащ",
            "Драконяча броня"
        };

        public Armor CreateOne()
        {
            int defense = rnd.Next(1, 11);

            return new Armor
            {
                Name = names[rnd.Next(names.Length)],
                DefenseBonus = defense,
                Price = defense * 20
            };
        }

        public List<Armor> CreateMany(int count)
        {
            List<Armor> armors = new List<Armor>();

            for (int i = 0; i < count; i++)
            {
                armors.Add(CreateOne());
            }

            return armors;
        }
    }
}
