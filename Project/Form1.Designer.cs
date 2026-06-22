namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblName = new Label();
            lblLevel = new Label();
            lblHealth = new Label();
            lblMana = new Label();
            lblGold = new Label();
            lblManaValue = new Label();
            lblHealthValue = new Label();
            lblLevelValue = new Label();
            lblNameValue = new Label();
            lblGoldValue = new Label();
            NextTurn = new Button();
            richTextBox1 = new RichTextBox();
            lblArmor = new Label();
            lblArmorValue = new Label();
            lblWeaponValue = new Label();
            lblWeapon = new Label();
            lblExperienceValue = new Label();
            lblExperience = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(24, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLevel.Location = new Point(26, 48);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(59, 25);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Level:";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHealth.Location = new Point(26, 127);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(71, 25);
            lblHealth.TabIndex = 2;
            lblHealth.Text = "Health:";
            // 
            // lblMana
            // 
            lblMana.AutoSize = true;
            lblMana.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMana.Location = new Point(26, 166);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(64, 25);
            lblMana.TabIndex = 3;
            lblMana.Text = "Mana:";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGold.Location = new Point(26, 206);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(56, 25);
            lblGold.TabIndex = 4;
            lblGold.Text = "Gold:";
            // 
            // lblManaValue
            // 
            lblManaValue.AutoSize = true;
            lblManaValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblManaValue.Location = new Point(108, 166);
            lblManaValue.Name = "lblManaValue";
            lblManaValue.Size = new Size(63, 25);
            lblManaValue.TabIndex = 5;
            lblManaValue.Text = "label1";
            // 
            // lblHealthValue
            // 
            lblHealthValue.AutoSize = true;
            lblHealthValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHealthValue.Location = new Point(108, 127);
            lblHealthValue.Name = "lblHealthValue";
            lblHealthValue.Size = new Size(63, 25);
            lblHealthValue.TabIndex = 6;
            lblHealthValue.Text = "label1";
            // 
            // lblLevelValue
            // 
            lblLevelValue.AutoSize = true;
            lblLevelValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLevelValue.Location = new Point(108, 48);
            lblLevelValue.Name = "lblLevelValue";
            lblLevelValue.Size = new Size(63, 25);
            lblLevelValue.TabIndex = 7;
            lblLevelValue.Text = "label1";
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNameValue.Location = new Point(108, 9);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(63, 25);
            lblNameValue.TabIndex = 8;
            lblNameValue.Text = "label1";
            // 
            // lblGoldValue
            // 
            lblGoldValue.AutoSize = true;
            lblGoldValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGoldValue.Location = new Point(108, 206);
            lblGoldValue.Name = "lblGoldValue";
            lblGoldValue.Size = new Size(63, 25);
            lblGoldValue.TabIndex = 9;
            lblGoldValue.Text = "label1";
            // 
            // NextTurn
            // 
            NextTurn.BackColor = Color.White;
            NextTurn.FlatStyle = FlatStyle.Popup;
            NextTurn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextTurn.Location = new Point(26, 372);
            NextTurn.Name = "NextTurn";
            NextTurn.Size = new Size(145, 57);
            NextTurn.TabIndex = 10;
            NextTurn.Text = "Next Turn";
            NextTurn.TextImageRelation = TextImageRelation.TextAboveImage;
            NextTurn.UseVisualStyleBackColor = false;
            NextTurn.Click += btnNextTurn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.BurlyWood;
            richTextBox1.Font = new Font("SimSun-ExtB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(375, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(396, 406);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // lblArmor
            // 
            lblArmor.AutoSize = true;
            lblArmor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArmor.Location = new Point(16, 282);
            lblArmor.Name = "lblArmor";
            lblArmor.Size = new Size(69, 25);
            lblArmor.TabIndex = 12;
            lblArmor.Text = "Armor:";
            // 
            // lblArmorValue
            // 
            lblArmorValue.AutoSize = true;
            lblArmorValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblArmorValue.Location = new Point(108, 282);
            lblArmorValue.Name = "lblArmorValue";
            lblArmorValue.Size = new Size(63, 25);
            lblArmorValue.TabIndex = 13;
            lblArmorValue.Text = "lable1";
            // 
            // lblWeaponValue
            // 
            lblWeaponValue.AutoSize = true;
            lblWeaponValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWeaponValue.Location = new Point(108, 241);
            lblWeaponValue.Name = "lblWeaponValue";
            lblWeaponValue.Size = new Size(63, 25);
            lblWeaponValue.TabIndex = 14;
            lblWeaponValue.Text = "lable1";
            // 
            // lblWeapon
            // 
            lblWeapon.AutoSize = true;
            lblWeapon.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWeapon.Location = new Point(11, 241);
            lblWeapon.Name = "lblWeapon";
            lblWeapon.Size = new Size(86, 25);
            lblWeapon.TabIndex = 15;
            lblWeapon.Text = "Weapon:";
            // 
            // lblExperienceValue
            // 
            lblExperienceValue.AutoSize = true;
            lblExperienceValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblExperienceValue.Location = new Point(125, 87);
            lblExperienceValue.Name = "lblExperienceValue";
            lblExperienceValue.Size = new Size(63, 25);
            lblExperienceValue.TabIndex = 16;
            lblExperienceValue.Text = "label1";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblExperience.Location = new Point(11, 87);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(108, 25);
            lblExperience.TabIndex = 17;
            lblExperience.Text = "Experience:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExperience);
            Controls.Add(lblExperienceValue);
            Controls.Add(lblWeapon);
            Controls.Add(lblWeaponValue);
            Controls.Add(lblArmorValue);
            Controls.Add(lblArmor);
            Controls.Add(richTextBox1);
            Controls.Add(NextTurn);
            Controls.Add(lblGoldValue);
            Controls.Add(lblNameValue);
            Controls.Add(lblLevelValue);
            Controls.Add(lblHealthValue);
            Controls.Add(lblManaValue);
            Controls.Add(lblGold);
            Controls.Add(lblMana);
            Controls.Add(lblHealth);
            Controls.Add(lblLevel);
            Controls.Add(lblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLevel;
        private Label lblHealth;
        private Label lblMana;
        private Label lblGold;
        private Label lblManaValue;
        private Label lblHealthValue;
        private Label lblLevelValue;
        private Label lblNameValue;
        private Label lblGoldValue;
        private Button NextTurn;
        private RichTextBox richTextBox1;
        private Label lblArmor;
        private Label lblArmorValue;
        private Label lblWeaponValue;
        private Label lblWeapon;
        private Label lblExperienceValue;
        private Label lblExperience;
    }
}
