using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class DifficultySelectForm : Form
    {
        public DifficultySelectForm()
        {
            InitializeComponent();
        }
        private void pictureEasy_Click(object sender, EventArgs e)
        {
            GameSettings.GameDifficulty = Difficulty.Easy;

            ClassSelectForm form = new ClassSelectForm();
            form.Show();

            this.Close();
        }
        private void pictureNormal_Click(object sender, EventArgs e)
        {
            GameSettings.GameDifficulty = Difficulty.Normal;

            ClassSelectForm form = new ClassSelectForm();
            form.Show();

            this.Close();
        }
        private void pictureHard_Click(object sender, EventArgs e)
        {
            GameSettings.GameDifficulty = Difficulty.Hard;

            ClassSelectForm form = new ClassSelectForm();
            form.Show();

            this.Close();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "🟢 EASY\n" +
                "━━━━━━━━━━━━━━\n" +
                "✔ Вороги не лікуються\n" +
                "✔ Немає босів\n\n" +

                "🟡 NORMAL\n" +
                "━━━━━━━━━━━━━━\n" +
                "✔ Є боси\n" +
                "✔ Звичайний баланс бою\n" +
                "✔ Трішки менше нагород\n" +
                "✔ Стандартна складність\n\n" +

                "🔴 HARD\n" +
                "━━━━━━━━━━━━━━\n" +
                "✔ Вороги можуть лікуватися\n" +
                "✔ Колосально менше нагород\n\n",

                "Difficulty Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
