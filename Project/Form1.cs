using Project.Entities;

namespace Project
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        Random rnd = new Random();
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
                player.Gold += 10;
                AddLog("Подія! +10 золота", Color.Blue);
            }
            else if (random <= 90)
            {
                AddLog("Зустрів ворога!", Color.Red);
            }
            else
            {
                AddLog("Знайдено магазин!", Color.Green);
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
        }
    }
}
