using Project.Entities;

namespace Project.GameServices
{
    public class ArmorGenerator : BaseGenerator<Armor>
    {
        public ArmorGenerator()
        {
            this.names.AddRange([
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
            ]);
        }


        public override Armor CreateOne()
        {
            int defense = rnd.Next(1, 11);

            return new Armor
            {
                Name = names[rnd.Next(names.Count)],
                DefenseBonus = defense,
                Price = defense * 20
            };
        }
    }
}
