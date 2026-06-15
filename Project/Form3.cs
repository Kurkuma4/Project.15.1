using Project.Entities;
using Project.Entities.Skills;
using Project.GameServices;
using System.Runtime.InteropServices.Marshalling;
using static System.Net.Mime.MediaTypeNames;

namespace Project
{
    public partial class BattleForm : Form
    {
        private Player player;
        private Enemy enemy;

        private EnemyGenerator enemyGenerator = new EnemyGenerator();

        private Random rnd = new Random();

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

        private void usePlayerSkill(int skillIndex)
        {
            ResultUseSkill result = player.skills[skillIndex].use(enemy);

            if (!result.IsSuccess)
            {
                AddLog("Недостатньо мани!", Color.Orange);
                return;
            }

            AddLog(result.Desc, result.Color);

            UpdateUI();

            if (enemy.Health <= 0)
            {
                AddLog($"Ворог {enemy.Name} переможений!", Color.Green);
                // нарахування досвіду та нагороди
                this.Close();
            }

            EnemyTurn();
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            usePlayerSkill(0);
        }

        private void btnStrongAttack_Click(object sender, EventArgs e)
        {
            usePlayerSkill(1);
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            usePlayerSkill(2);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            usePlayerSkill(3);
        }
        private void EnemyTurn()
        {
            int action = rnd.Next(1, 2);

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

            UpdateUI();

            if (player.Health <= 0)
            {
                AddLog("Гравець переможений!", Color.Red);
                this.Close();
            }
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
