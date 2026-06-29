using Project.Entities;
using Project.GameServices;

namespace Project
{
    public partial class DeathForm : Form
    {
        private SaveLoadService saveService = new SaveLoadService();
        public DeathForm(Player player, Enemy enemy)
        {
            InitializeComponent();

            lblEnemy.Text = "Вас переміг: " + enemy.Name;

            lblStats.Text = "Ваший рівень: " + player.Level;

            if (player.IsLoadedGame)
            {
                saveService.DeleteSave();
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();

            menu.Show();

            this.Close();
        }
    }
}
