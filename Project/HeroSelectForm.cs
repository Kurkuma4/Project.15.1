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
    public partial class HeroSelectForm : Form
    {
        private Player player;
        public HeroSelectForm()
        {
            InitializeComponent();

            player = new Player();

            pictureMage.Image = Image.FromFile("Images/Mage.jpg");
            pictureElf.Image = Image.FromFile("Images/Elf.jpg");
            pictureBarbarian.Image = Image.FromFile("Images/Barbarian.jpg");
        }
        private void btnMage_Click(object sender, EventArgs e)
        {
            player.Name = "Mage";
            player.HeroImage = "Mage";

            Form1 game = new Form1(player);

            game.Show();

            this.Close();
        }
        private void btnElf_Click(object sender, EventArgs e)
        {
            player.Name = "Elf";
            player.HeroImage = "Elf";

            Form1 game = new Form1(player);

            game.Show();

            this.Close();
        }
        private void btnBarbarian_Click(object sender, EventArgs e)
        {
            player.Name = "Barbarian";
            player.HeroImage = "Barbarian";

            Form1 game = new Form1(player);

            game.Show();

            this.Close();
        }
    }
}
