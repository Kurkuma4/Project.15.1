using Project.Entities;

namespace Project
{
    public partial class CharacterSelectForm : Form
    {
        private string selectedClass;
        private Player player;
        public CharacterSelectForm(string heroClass)
        {
            InitializeComponent();

            selectedClass = heroClass;

            player = new Player();

            LoadCharacter();
        }
        private void LoadCharacter()
        {
            if (selectedClass == "Tank")
            {
                pictureHero.Image = Image.FromFile("Images/Barbarian.png");
                lblHeroName.Text = "Barbarian";
            }
            else if (selectedClass == "Archer")
            {
                pictureHero.Image = Image.FromFile("Images/Elf.png");
                lblHeroName.Text = "Elf";
            }
            else if (selectedClass == "Mage")
            {
                pictureHero.Image = Image.FromFile("Images/Mage.png");
                lblHeroName.Text = "Mage";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ClassSelectForm form = new ClassSelectForm();

            form.Show();

            this.Close();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (selectedClass == "Tank")
            {
                MessageBox.Show(
                    "⚔ BARBARIAN\n\n" +
                    "Class: Tank\n\n" +
                    "Strength: 8\n" +
                    "Endurance: 7\n" +
                    "Agility: 2\n" +
                    "Intelligence: 3\n\n" +
                    "HP: 70\n" +
                    "Mana: 15\n\n" +
                    "Level Up:\n" +
                    "+4 Strength\n" +
                    "+2 Endurance\n" +
                    "+1 Agility\n" +
                    "+1 Intelligence\n\n" +
                    "Unique Skill:\n" +
                    "Unique Skill:\n" +
                    "Berserk Strike\n\n" +
                    "• Deals 200% damage.\n" +
                    "• Ignores 50% enemy defense.\n" +
                    "• Costs 20 Mana.\n" +
                    "• Cooldown: 3 turns.\n" +
                    "• After using the skill,\n" +
                    "  gains +20% Attack\n" +
                    "  for the next turn.",
                    "Character Info");
            }
            else if (selectedClass == "Archer")
            {
                MessageBox.Show(
                    "🏹 ELF ARCHER\n\n" +
                    "Class: Archer\n\n" +
                    "Strength: 5\n" +
                    "Endurance: 4\n" +
                    "Agility: 8\n" +
                    "Intelligence: 3\n\n" +
                    "HP: 40\n" +
                    "Mana: 15\n\n" +
                    "Level Up:\n" +
                    "+2 Strength\n" +
                    "+2 Endurance\n" +
                    "+3 Agility\n" +
                    "+1 Intelligence\n\n" +
                    "Unique Skill:\n" +
                    "Piercing Arrow\n\n" +
                    "• Deals 150% damage.\n" +
                    "• Ignores 100% enemy defense.\n" +
                    "• Costs 25 Mana.\n" +
                    "• Cooldown: 5 turns.\n" +
                    "• 50% chance to fire\n" +
                    "  one extra normal shot.", 
                    "Character Info");
            }
            else if (selectedClass == "Mage")
            {
                MessageBox.Show(
                    "🪄 MAGE\n\n" +
                    "Class: Mage\n\n" +
                    "Strength: 4\n" +
                    "Endurance: 4\n" +
                    "Agility: 4\n" +
                    "Intelligence: 8\n\n" +
                    "HP: 40\n" +
                    "Mana: 40\n\n" +
                    "Level Up:\n" +
                    "+1 Strength\n" +
                    "+2 Endurance\n" +
                    "+1 Agility\n" +
                    "+4 Intelligence\n\n" +
                    "Unique Skill:\n" +
                    "Fireball\n\n" +
                    "• Deals 300% damage.\n" +
                    "• Ignores 50% enemy defense.\n" +
                    "• Costs 40 Mana.\n" +
                    "• Cooldown: 4 turns.\n" +
                    "• 30% chance to Burn\n" +
                    "  the enemy for\n" +
                    "  extra damage next turn.",
                    "Character Info");
            }
        }

        private void pictureHero_Click(object sender, EventArgs e)
        {
            if (selectedClass == "Tank")
            {
                CreateHero("Barbarian", 8, 7, 2, 3);
            }
            else if (selectedClass == "Archer")
            {
                CreateHero("Elf", 5, 4, 8, 3);
            }
            else if (selectedClass == "Mage")
            {
                CreateHero("Mage", 4, 4, 4, 8);
            }
        }
        private void CreateHero(string name, int str, int end, int agi, int intel)
        {
            player.IsLoadedGame = false;

            player.Name = name;
            player.HeroImage = name;

            player.Level = 1;

            player.Strength = str;
            player.Endurance = end;
            player.Agility = agi;
            player.Intelligence = intel;

            player.Gold = 100;
            player.Experience = 0;

            player.Health = player.MaxHealth;
            player.Mana = player.MaxMana;

            player.SavedDifficulty = GameSettings.GameDifficulty;

            Form1 game = new Form1(player);
            game.Show();

            this.Close();
        }
    }
}
