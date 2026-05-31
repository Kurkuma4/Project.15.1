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
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(26, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLevel.Location = new Point(26, 85);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(49, 21);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Level:";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHealth.Location = new Point(26, 127);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(58, 21);
            lblHealth.TabIndex = 2;
            lblHealth.Text = "Health:";
            // 
            // lblMana
            // 
            lblMana.AutoSize = true;
            lblMana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMana.Location = new Point(26, 166);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(52, 21);
            lblMana.TabIndex = 3;
            lblMana.Text = "Mana:";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGold.Location = new Point(26, 206);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(46, 21);
            lblGold.TabIndex = 4;
            lblGold.Text = "Gold:";
            // 
            // lblManaValue
            // 
            lblManaValue.AutoSize = true;
            lblManaValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblManaValue.Location = new Point(95, 166);
            lblManaValue.Name = "lblManaValue";
            lblManaValue.Size = new Size(52, 21);
            lblManaValue.TabIndex = 5;
            lblManaValue.Text = "label1";
            // 
            // lblHealthValue
            // 
            lblHealthValue.AutoSize = true;
            lblHealthValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHealthValue.Location = new Point(95, 127);
            lblHealthValue.Name = "lblHealthValue";
            lblHealthValue.Size = new Size(52, 21);
            lblHealthValue.TabIndex = 6;
            lblHealthValue.Text = "label1";
            // 
            // lblLevelValue
            // 
            lblLevelValue.AutoSize = true;
            lblLevelValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLevelValue.Location = new Point(95, 85);
            lblLevelValue.Name = "lblLevelValue";
            lblLevelValue.Size = new Size(52, 21);
            lblLevelValue.TabIndex = 7;
            lblLevelValue.Text = "label1";
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNameValue.Location = new Point(95, 44);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(52, 21);
            lblNameValue.TabIndex = 8;
            lblNameValue.Text = "label1";
            // 
            // lblGoldValue
            // 
            lblGoldValue.AutoSize = true;
            lblGoldValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGoldValue.Location = new Point(95, 206);
            lblGoldValue.Name = "lblGoldValue";
            lblGoldValue.Size = new Size(52, 21);
            lblGoldValue.TabIndex = 9;
            lblGoldValue.Text = "label1";
            // 
            // NextTurn
            // 
            NextTurn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextTurn.Location = new Point(26, 372);
            NextTurn.Name = "NextTurn";
            NextTurn.Size = new Size(145, 57);
            NextTurn.TabIndex = 10;
            NextTurn.Text = "Next Turn";
            NextTurn.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
    }
}
