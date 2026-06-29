using Project.Entities;
using Project.GameServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainMenu : Form
    {
        SaveLoadService saveService = new SaveLoadService();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DifficultySelectForm form = new DifficultySelectForm();

            form.Show();

            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Мета гри - перемагати ворогів, отримувати досвід, купувати нове спорядження та прокачувати героя.",
                "Правила гри",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if (!saveService.HasSave())
            {
                MessageBox.Show("У вас немає збережених ігор!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player player = saveService.Load();
            player.IsLoadedGame = true;

            if (player == null)
            {
                MessageBox.Show("Помилка завантаження!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form1 game = new Form1(player);
            game.Show();

            this.Hide();
        }
    }
}
