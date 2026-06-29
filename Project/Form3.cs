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
        public Enemy CurrentEnemy
        {
            get { return enemy; }
        }
        public BattleForm(Player player)
        {
            InitializeComponent();

            this.player = player;

            enemyGenerator.SetPlayer(player);
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

        private void buttonBlock(bool isEnebled)
        {
            this.btnAttack.Enabled = isEnebled;
            this.btnUniqueSkill.Enabled = isEnebled;
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
                AddLog(result.Desc, result.Color);
                buttonBlock(true);
                return;
            }

            AddLog(result.Desc, result.Color);

            UpdateUI();

            if (enemy.Health <= 0)
            {
                PlayerWon = true;
                AddLog($"Ворог {enemy.Name} переможений!", Color.Green);

                int goldReward = 0;
                int expReward = 0;

                if (GameSettings.GameDifficulty == Difficulty.Easy)
                {
                    goldReward = rnd.Next(20, 61);
                    expReward = 25;
                }
                else if (GameSettings.GameDifficulty == Difficulty.Normal)
                {
                    goldReward = rnd.Next(10, 51);
                    expReward = 20;
                }
                else if (GameSettings.GameDifficulty == Difficulty.Hard)
                {
                    goldReward = rnd.Next(5, 31);
                    expReward = 10;
                }

                if (enemy.IsBoss)
                {
                    goldReward *= 2;
                    expReward *= 2;
                }

                int healAfterBattle = player.MaxHealth / 10;
                int manaAfterBattle = (player.Level + 1) * 5;

                player.Health += healAfterBattle;
                player.Mana += manaAfterBattle;

                player.Gold += goldReward;
                player.Experience += expReward;

                if (player.Health > player.MaxHealth)
                    player.Health = player.MaxHealth;

                if (player.Mana > player.MaxMana)
                    player.Mana = player.MaxMana;

                if (enemy.IsBoss)
                {

                    MessageBox.Show(
                    $"👑 Ви перемогли БОСА!\n💰 Нагорода збільшена у 2 рази!\n\n" +
                    $"❤️ Відновлено {healAfterBattle} HP після бою!\n" +
                    $"🌟 Відновлено {manaAfterBattle} MP після бою!\n" +
                    $"💰 Отримано {goldReward} золота!" + "\n" +
                    $"✨ Отримано {expReward} XP!");
                }

                else 
                {
                    MessageBox.Show(
                    $"🎉 Вітаємо! Ви отримали нагороду!\n\n" +
                    $"❤️ Відновлено {healAfterBattle} HP після бою!\n" +
                    $"🌟 Відновлено {manaAfterBattle} MP після бою!\n" +
                    $"💰 Отримано {goldReward} золота!" + "\n" +
                    $"✨ Отримано {expReward} XP!");
                }

                if (player.Experience >= player.Level * 100)
                {
                    player.Experience = 0;
                    player.Level++;

                    ApplyLevelUp();
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
        private void btnUniqueSkill_Click(object sender, EventArgs e)
        {
            usePlayerSkill(4);
        }
        private void EnemyTurn()
        {
            int action;

            if (enemy.BurnStartsNextTurn)
            {
                enemy.BurnStartsNextTurn = false;
            }
            else if (enemy.BurnTurns > 0)
            {
                int burnDamage = enemy.MaxHealth / 10;

                enemy.Health -= burnDamage;
                if (enemy.Health < 0)
                    enemy.Health = 0;
                enemy.BurnTurns--;

                AddLog($"🔥 Ворог горить, вогонь наносить {burnDamage} шкоди!", Color.Red);
            }

            if (GameSettings.GameDifficulty == Difficulty.Hard)
            {
                action = rnd.Next(1, 3);
            }
            else
            {
                action = 1;
            }

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

            ((UniqueSkill)player.skills[4]).TickCooldown();

            UpdateUI();

            if (player.Health <= 0)
            {
                PlayerWon = false;

                this.Close();
            }
        }
        private void ApplyLevelUp()
        {
            if (player.Level % 10 == 0)
            {
                player.Strength += 5;
                player.Endurance += 5;
                player.Agility += 5;
                player.Intelligence += 5;

                MessageBox.Show(
                $"🎉 ЮВІЛЕЙНИЙ РІВЕНЬ!\n\n" +
                $"Досягнуто {player.Level} рівня!\n\n" +
                $"⚔ Сила +5\n" +
                $"❤️ Витривалість +5\n" +
                $"🏃 Спритність +5\n" +
                $"✨ Інтелект +5");
            }
            else
            {
                if (player.Name == "Barbarian")
                {
                    player.Strength += 4;
                    player.Endurance += 2;
                    player.Agility += 1;
                    player.Intelligence += 1;
                    MessageBox.Show(
                    $"🎉 Вітаємо!\n\n" +
                    $"Досягнуто {player.Level} рівня!\n\n" +
                    $"⚔ Сила +4\n" +
                    $"❤️ Витривалість +2\n" +
                    $"🏃 Спритність +1\n" +
                    $"✨ Інтелект +1",
                    "Новий рівень!");
                }
                else if (player.Name == "Elf")
                {
                    player.Strength += 2;
                    player.Endurance += 2;
                    player.Agility += 3;
                    player.Intelligence += 1;
                    MessageBox.Show(
                    $"🎉 Вітаємо!\n\n" +
                    $"Досягнуто {player.Level} рівня!\n\n" +
                    $"⚔ Сила +2\n" +
                    $"❤️ Витривалість +2\n" +
                    $"🏃 Спритність +3\n" +
                    $"✨ Інтелект +1",
                    "Новий рівень!");
                }
                else if (player.Name == "Mage")
                {
                    player.Strength += 1;
                    player.Endurance += 2;
                    player.Agility += 1;
                    player.Intelligence += 4;
                    MessageBox.Show(
                    $"🎉 Вітаємо!\n\n" +
                    $"Досягнуто {player.Level} рівня!\n\n" +
                    $"⚔ Сила +1\n" +
                    $"❤️ Витривалість +2\n" +
                    $"🏃 Спритність +1\n" +
                    $"✨ Інтелект +4",
                    "Новий рівень!");
                }
            }

            player.ClampStats();
        }
        private void UpdateUI()
        {
            lblPlayerName.Text = player.Name;
            lblPlayerHP.Text = $" {player.Health}/{player.MaxHealth}";
            lblPlayerMP.Text = $" {player.Mana}/{player.MaxMana}";

            lblEnemyName.Text = enemy.Name;
            lblEnemyLevel.Text = $" {enemy.Level}";
            lblEnemyHP.Text = $" {enemy.Health}/{enemy.MaxHealth}";
            pictureEnemy.Image = System.Drawing.Image.FromFile($"Images/{enemy.Name}.png");
            picturePlayer.Image = System.Drawing.Image.FromFile($"Images/{player.HeroImage}.png");
            this.BackgroundImage = System.Drawing.Image.FromFile($"Images/Фон{enemy.Name}.png");
        }
    }
}
