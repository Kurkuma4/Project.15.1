using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Entities;

namespace Project
{
    public partial class ClassSelectForm : Form
    {
        public ClassSelectForm()
        {
            InitializeComponent();

            pictureClassMage.Image = Image.FromFile("Images/ClassMage.jpg");
            pictureClassArcher.Image = Image.FromFile("Images/ClassArcher.jpg");
            pictureClassTank.Image = Image.FromFile("Images/ClassTank.jpg");
        }
        private void pictureClassMage_Click(object sender, EventArgs e)
        {
            CharacterSelectForm form = new CharacterSelectForm("Mage");

            form.Show();

            this.Close();
        }

        private void pictureClassArcher_Click(object sender, EventArgs e)
        {
            CharacterSelectForm form = new CharacterSelectForm("Archer");

            form.Show();

            this.Close();
        }

        private void pictureClassTank_Click(object sender, EventArgs e)
        {
            CharacterSelectForm form = new CharacterSelectForm("Tank");

            form.Show();

            this.Close();
        }
    }
}
