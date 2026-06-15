using Project.Entities;

namespace Project
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Random rnd = new Random();

        private List<string> events;

        public Form1()
        {
            InitializeComponent();

            player.Name = "Hero";
            player.Level = 1;
            player.Strength = 5;
            player.Endurance = 5;
            player.Agility = 5;
            player.Intelligence = 5;
            player.Gold = 100;

            player.ResetStats();

            player.Health = player.MaxHealth;
            player.Mana = player.MaxMana;

            events = new List<string>
            {
                "Ви знайшли мішочок з грошима! +30 золота",
                "Боржник повернув вам золото! +40 золота",
                "Ви знайшли сховок з золотом! +50 золота",
                "Ви зустріли доброго гнома! +15 золота",
                "Ви знайшли чарівне дерево на якому росте золото! +25 золота",
                "Під корчем поваленого дуба скриня з золотом , +70 золота",
                "Переходячи в брод лісову річечку, ви знайшли декілька золотих самородків! +45 золота",

                "Ви загубили мішочок з золотом :( -20 золота",
                "Ви натрапили на відьму ( потрібно відкупитися ) -30 золота",
                "Ви повинні кредитору золото :( -200 золота"
            };

            UpdateUI();
        }
        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            int random = rnd.Next(1, 101);

            if (random <= 30)
            {
                AddLog("Нічого не сталося", Color.Black);
            }
            else if (random <= 60)
            {
                string eventText = events[rnd.Next(events.Count)];

                AddLog(eventText, Color.Blue);

                if (eventText.Contains("+15")) player.Gold += 15;
                else if (eventText.Contains("+25")) player.Gold += 25;
                else if (eventText.Contains("+30")) player.Gold += 30;
                else if (eventText.Contains("+40")) player.Gold += 40;
                else if (eventText.Contains("+45")) player.Gold += 45;
                else if (eventText.Contains("+50")) player.Gold += 50;
                else if (eventText.Contains("+70")) player.Gold += 70;
                else if (eventText.Contains("-200")) player.Gold -= 200;
                else if (eventText.Contains("-20")) player.Gold -= 20;
                else if (eventText.Contains("-30")) player.Gold -= 30;
            }
            else if (random <= 90)
            {
                AddLog("Зустрів ворога!", Color.Red);

                BattleForm battle = new BattleForm(player);
                battle.ShowDialog();

                if (battle.PlayerWon)
                {
                    AddLog("Перемога в бою! Ви отримали нагороду!", Color.Green);
                }
                else
                {
                    AddLog("Поразка в бою...", Color.Red);
                }

                UpdateUI();
            }
            else
            {
                AddLog("Знайдено магазин!", Color.Green);

                Form2 shop = new Form2(player);
                shop.ShowDialog();

                UpdateUI();
            }

            UpdateUI();
        }
        private void AddLog(string message, Color color)
        {
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(message + "\n");
            richTextBox1.SelectionColor = Color.Black;

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void UpdateUI()
        {
            lblNameValue.Text = player.Name;
            lblLevelValue.Text = player.Level.ToString();
            lblHealthValue.Text = player.MaxHealth.ToString();
            lblManaValue.Text = player.MaxMana.ToString();
            lblGoldValue.Text = player.Gold.ToString();
            lblArmorValue.Text = player.Armor == null ? "Немає" : player.Armor.ToString();
            lblWeaponValue.Text = player.Weapon == null ? "Немає" : player.Weapon.ToString();
        }
    }
}
