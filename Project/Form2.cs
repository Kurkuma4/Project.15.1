using Project.Entities;
using Project.GameServices;

namespace Project
{
    public partial class Form2 : Form
    {
        private Player player;

        private WeaponGenerator weaponGenerator = new WeaponGenerator();
        private ArmorGenerator armorGenerator = new ArmorGenerator();

        private bool isWeaponShop;

        public Form2(Player player)
        {
            InitializeComponent();

            this.player = player;

            GenerateShop();
        }

        private void GenerateShop()
        {
            Random rnd = new Random();

            isWeaponShop = rnd.Next(2) == 0;

            listBoxItems.Items.Clear();

            if (isWeaponShop)
            {
                lblShopType.Text = "Магазин зброї";

                foreach (var weapon in weaponGenerator.CreateMany(5))
                {
                    listBoxItems.Items.Add(weapon);
                }
            }
            else
            {
                lblShopType.Text = "Магазин броні";

                foreach (var armor in armorGenerator.CreateMany(5))
                {
                    listBoxItems.Items.Add(armor);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem == null)
                return;

            if (isWeaponShop)
            {
                Weapon weapon = (Weapon)listBoxItems.SelectedItem;

                if (player.Gold >= weapon.Price)
                {
                    player.Gold -= weapon.Price;
                    player.Weapon = weapon;

                    MessageBox.Show("Зброя куплена та одягнена!");
                }
                else
                {
                    MessageBox.Show("Недостатньо золота!");
                }
            }
            else
            {
                Armor armor = (Armor)listBoxItems.SelectedItem;

                if (player.Gold >= armor.Price)
                {
                    player.Gold -= armor.Price;
                    player.Armor = armor;

                    MessageBox.Show("Броня куплена та одягнена!");
                }
                else
                {
                    MessageBox.Show("Недостатньо золота!");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
