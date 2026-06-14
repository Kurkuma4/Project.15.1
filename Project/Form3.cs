using Project.Entities;
using Project.GameServices;

namespace Project
{
    public partial class BattleForm : Form
    {
        private Player player;
        private Enemy enemy;

        private EnemyGenerator enemyGenerator = new EnemyGenerator();

        private Random rnd = new Random();

        private bool isPlayerTurn = true;

        public bool PlayerWon = false;
        public bool PlayerLost = false;
        public BattleForm(Player player)
        {
            InitializeComponent();

            this.player = player;

            player.Health = player.MaxHealth;
            player.Mana = player.MaxMana;

            enemy = enemyGenerator.CreateOne();

            UpdateUI();
        }
        private void AddLog(string text, Color color)
        {
            richTextBoxLog.SelectionColor = color;
            richTextBoxLog.AppendText(text + "\n");
            richTextBoxLog.SelectionColor = Color.Black;

            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            richTextBoxLog.ScrollToCaret();
        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn)
            {
                AddLog("Гравець переможений!", Color.Red);
                PlayerLost = true;
                this.Close();
                return;
            }


            int damage = player.CalculateAttackPower();
            enemy.TakeDamage(damage);

            AddLog($"{player.Name} атакує і наносить {damage} шкоди!", Color.Blue);

            UpdateUI();

            isPlayerTurn = false;

            EnemyTurn();
        }
        private void btnStrongAttack_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn)
                return;

            int manaCost = 15;

            if (player.Mana < manaCost)
            {
                AddLog("Недостатньо мани!", Color.Orange);
                return;
            }

            int damage = player.CalculateAttackPower() * 2;

            enemy.TakeDamage(damage);
            player.Mana -= manaCost;

            AddLog($"{player.Name} використовує СИЛЬНУ АТАКУ і наносить {damage} шкоди!", Color.DarkRed);

            UpdateUI();

            if (enemy.Health <= 0)
            {
                AddLog($"Ворог {enemy.Name} переможений!", Color.Green);
                PlayerWon = true;
                this.Close();
                return;
            }

            isPlayerTurn = false;
            EnemyTurn();
        }
        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn)
                return;

            int manaCost = 10;

            if (player.Mana < manaCost)
            {
                AddLog("Недостатньо мани!", Color.Orange);
                return;
            }

            player.Heal(25);
            player.Mana -= manaCost;

            AddLog($"{player.Name} лікується і відновлює HP!", Color.Green);

            UpdateUI();

            isPlayerTurn = false;
            EnemyTurn();
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            if (!isPlayerTurn)
                return;

            player.Mana += 15;

            if (player.Mana > player.MaxMana)
                player.Mana = player.MaxMana;

            AddLog($"{player.Name} відпочиває і відновлює ману!", Color.Blue);

            UpdateUI();

            isPlayerTurn = false;
            EnemyTurn();
        }
        private void EnemyTurn()
        {
            if (enemy.Health <= 0)
            {
                AddLog($"Ворог {enemy.Name} переможений!", Color.Green);
                PlayerWon = true;
                this.Close();
                return;
            }

            if (player.Health <= 0)
            {
                AddLog("Гравець переможений!", Color.Red);
                PlayerLost = true;
                this.Close();
                return;
            }

            int action = rnd.Next(1, 4);

            if (action == 1)
            {
                int damage = enemy.Attack;
                player.TakeDamage(damage);
                AddLog($"{enemy.Name} атакує і наносить {damage} шкоди!", Color.Red);
            }
            else if (action == 2)
            {
                enemy.Heal(enemy.Level * 2);
                AddLog($"{enemy.Name} відновлює HP!", Color.Blue);
            }
            else
            {
                AddLog($"{enemy.Name} пропускає хід", Color.Gray);
            }

            isPlayerTurn = true;
            UpdateUI();
        }
        private void UpdateUI()
        {
            lblPlayerName.Text = player.Name;
            lblPlayerHP.Text = $" {player.Health}/{player.MaxHealth}";
            lblPlayerMP.Text = $" {player.Mana}/{player.MaxMana}";

            lblEnemyName.Text = enemy.Name;
            lblEnemyLevel.Text = $" {enemy.Level}";
            lblEnemyHP.Text = $" {enemy.Health}/{enemy.MaxHealth}";
        }
    }
}
