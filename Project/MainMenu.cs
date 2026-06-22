using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            HeroSelectForm heroForm = new HeroSelectForm();

            heroForm.Show();

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
    }
}
