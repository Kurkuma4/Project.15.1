using Project.Entities;
using Project.Entities.Skills;
using Project.GameServices;

namespace Project
{
    public partial class BattleForm : Form
    {
        private Player player;
        private Enemy enemy;

        private EnemyGenerator enemyGenerator = new EnemyGenerator();

        private Random rnd = new Random();

        public bool PlayerWon;

        public BattleForm(Player player)
        {
            InitializeComponent();

            this.player = player;

            if (player.Health <= 0)
                player.Health = player.MaxHealth;

            enemy = enemyGenerator.CreateOne(player.Level);

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

        private void buttonBlock(bool isEnebled)
        {
            this.btnAttack.Enabled = isEnebled;
            this.btnStrongAttack.Enabled = isEnebled;
            this.btnHeal.Enabled = isEnebled;
            this.btnRest.Enabled = isEnebled;
        }

        private void usePlayerSkill(int skillIndex)
        {
            buttonBlock(false);
            ResultUseSkill result = player.skills[skillIndex].use(enemy);

            if (!result.IsSuccess)
            {
                AddLog("Недостатньо мани!", Color.Orange);
                buttonBlock(true);
                return;
            }

            AddLog(result.Desc, result.Color);

            UpdateUI();

            if (enemy.Health <= 0)
            {
                PlayerWon = true;
                AddLog($"Ворог {enemy.Name} переможений!", Color.Green);

                int goldReward = rnd.Next(10, 51);
                int expReward = 20;
                int healAfterBattle = player.MaxHealth / 10;
                player.Health += healAfterBattle;

                player.Gold += goldReward;
                player.Experience += expReward;

                if (player.Health > player.MaxHealth)
                    player.Health = player.MaxHealth;

                MessageBox.Show(
                $"🎉 Вітаємо! Ви отримали нагороду!\n\n" +
                $"❤️ Відновлено {healAfterBattle} HP після бою!\n" +
                $"💰 Отримано {goldReward} золота!" + "\n" +
                $"✨ Отримано {expReward} XP!");

                if (player.Experience >= (player.Level + 1) * 100)
                {
                    player.Level++;

                    player.Strength += 2;
                    player.Endurance += 1;
                    player.Agility += 1;
                    player.Intelligence += 1;

                    player.ClampStats();

                    MessageBox.Show(
                        $"🎉 Вітаємо!\n\n" +
                        $"Досягнуто {player.Level} рівня!\n\n" +
                        $"⚔ Сила +2\n" +
                        $"❤️ Витривалість +1\n" +
                        $"🏃 Спритність +1\n" +
                        $"✨ Інтелект +1",
                        "Новий рівень!");
                }
                this.Close();
            }

            EnemyTurn();
            buttonBlock(true);
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
            player.ClampStats();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            usePlayerSkill(3);
            player.ClampStats();
        }
        private void EnemyTurn()
        {
            int action = rnd.Next(1, 3);

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
                PlayerWon = false;
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
            pictureEnemy.Image = Image.FromFile($"Images/{enemy.Name}.jpg");
            picturePlayer.Image = Image.FromFile($"Images/{player.HeroImage}.jpg");
            this.BackgroundImage = Image.FromFile($"Images/Фон{enemy.Name}.jpg");
        }
    }
}
