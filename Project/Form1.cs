using Project.Entities;
using Project.Entities.Skills;
using Project.GameServices;
using System.Numerics;

namespace Project
{
    public partial class Form1 : Form
    {
        SaveLoadService saveService = new SaveLoadService();

        private Player player;
        Random rnd = new Random();

        public static int BossCooldown = 0;
        private int lastForest = 0;

        private List<string> events;

        public Form1(Player player)
        {
            InitializeComponent();

            this.player = player;
            ((UniqueSkill)this.player.skills[4]).LoadCooldown(this.player.UniqueSkillCooldown);

            BossCooldown = this.player.SavedBossCooldown;

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

            RestoreBackground();
            UpdateUI();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Ви впевнені, що хочете зберегти гру?",
               "Підтвердження збереження",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            player.SavedBossCooldown = Form1.BossCooldown;

            saveService.Save(player);

            MessageBox.Show("Гра збережена!");
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
                    if (battle.CurrentEnemy.IsBoss)
                    {
                        SetBossBackground();
                        AddLog("👑 Ви перемогли БОСА!", Color.Gold);
                    }
                    else
                    {
                        if (BossCooldown > 0)
                            BossCooldown--;

                        SetForestBackground();
                        AddLog("Перемога в бою! Ви отримали нагороду!", Color.Green);
                    }
                }
                else
                {
                    DeathForm death = new DeathForm(player, battle.CurrentEnemy);

                    death.Show();

                    this.Close();
                }

                UpdateUI();
            }
            else
            {
                AddLog("Знайдено магазин!", Color.Green);

                Form2 shop = new Form2(player);
                shop.ShowDialog();

                SetShopBackground();

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
            lblHealthValue.Text = $"{player.Health} / {player.MaxHealth}";
            lblManaValue.Text = $"{player.Mana} / {player.MaxMana}";
            lblGoldValue.Text = player.Gold.ToString();
            if (player.Armor == null)
                lblArmorValue.Text = "None";
            else
                lblArmorValue.Text = $"{player.Armor.Name} | Defense +{player.Armor.DefenseBonus}";

            if (player.Weapon == null)
                lblWeaponValue.Text = "None";
            else
                lblWeaponValue.Text = $"{player.Weapon.Name} | Attack +{player.Weapon.AttackBonus}";
            lblExperienceValue.Text = $"{player.Experience} / {player.Level * 100}";
        }
        private void SetForestBackground()
        {
            int bg;

            do
            {
                bg = rnd.Next(1, 4);
            }
            while (bg == lastForest);

            lastForest = bg;

            if (bg == 1)
                BackgroundImage = Image.FromFile("Images/Форм1Forest1.jpg");
            else if (bg == 2)
                BackgroundImage = Image.FromFile("Images/Форм1Forest2.jpg");
            else
                BackgroundImage = Image.FromFile("Images/Форм1Forest3.jpg");

            BackgroundImageLayout = ImageLayout.Stretch;

            player.BackgroundState = 0;
        }

        private void SetShopBackground()
        {
            BackgroundImage = Image.FromFile("Images/Форм1AfterShop1.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            player.BackgroundState = 1;
        }

        private void SetBossBackground()
        {
            BackgroundImage = Image.FromFile("Images/Форм1AfterBattle1.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            player.BackgroundState = 2;
        }
        private void RestoreBackground()
        {
            switch (player.BackgroundState)
            {
                case 0:
                    SetForestBackground();
                    break;

                case 1:
                    SetShopBackground();
                    break;

                case 2:
                    SetBossBackground();
                    break;
            }
        }
    }
}
