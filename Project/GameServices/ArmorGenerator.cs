using Project.Entities;

namespace Project.GameServices
{
    public class ArmorGenerator : BaseGenerator<Armor>
    {
        private Player player;

        public void SetPlayer(Player player)
        {
            this.player = player;
        }
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
            int minDefense = 1;
            int maxDefense = 10;

            if (player != null)
            {
                minDefense = Math.Max(1, player.Level - 2);
                maxDefense = player.Level + 3;
            }

            int defense = rnd.Next(minDefense, maxDefense + 1);

            return new Armor
            {
                Name = names[rnd.Next(names.Count)],
                DefenseBonus = defense,
                Price = defense * 20
            };
        }
    }
}
