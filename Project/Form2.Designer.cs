namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnBuy = new Button();
            listBoxItems = new ListBox();
            lblShopType = new Label();
            btnClose = new Button();
            lblArmor = new Label();
            lblGold = new Label();
            lblWeapon = new Label();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(255, 224, 192);
            btnBuy.FlatStyle = FlatStyle.Popup;
            btnBuy.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBuy.Location = new Point(193, 581);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(257, 82);
            btnBuy.TabIndex = 0;
            btnBuy.Text = "Купити";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.BackColor = Color.FromArgb(255, 224, 192);
            listBoxItems.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(320, 221);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(488, 337);
            listBoxItems.TabIndex = 1;
            // 
            // lblShopType
            // 
            lblShopType.AutoSize = true;
            lblShopType.BackColor = Color.FromArgb(255, 224, 192);
            lblShopType.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblShopType.ForeColor = Color.Black;
            lblShopType.Location = new Point(407, 133);
            lblShopType.Name = "lblShopType";
            lblShopType.Size = new Size(120, 50);
            lblShopType.TabIndex = 2;
            lblShopType.Text = "label1";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 224, 192);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClose.Location = new Point(677, 581);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(257, 82);
            btnClose.TabIndex = 3;
            btnClose.Text = "Вийти з магазину";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnExit_Click;
            // 
            // lblArmor
            // 
            lblArmor.AutoSize = true;
            lblArmor.BackColor = Color.FromArgb(255, 224, 192);
            lblArmor.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArmor.Location = new Point(875, 257);
            lblArmor.Name = "lblArmor";
            lblArmor.Size = new Size(120, 50);
            lblArmor.TabIndex = 4;
            lblArmor.Text = "label1";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.BackColor = Color.FromArgb(255, 224, 192);
            lblGold.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGold.Location = new Point(875, 178);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(120, 50);
            lblGold.TabIndex = 5;
            lblGold.Text = "label1";
            // 
            // lblWeapon
            // 
            lblWeapon.AutoSize = true;
            lblWeapon.BackColor = Color.FromArgb(255, 224, 192);
            lblWeapon.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWeapon.Location = new Point(875, 341);
            lblWeapon.Name = "lblWeapon";
            lblWeapon.Size = new Size(120, 50);
            lblWeapon.TabIndex = 6;
            lblWeapon.Text = "label3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1554, 751);
            Controls.Add(lblWeapon);
            Controls.Add(lblGold);
            Controls.Add(lblArmor);
            Controls.Add(btnClose);
            Controls.Add(lblShopType);
            Controls.Add(listBoxItems);
            Controls.Add(btnBuy);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopForm";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuy;
        private ListBox listBoxItems;
        private Label lblShopType;
        private Button btnClose;
        private Label lblArmor;
        private Label lblGold;
        private Label lblWeapon;
    }
}