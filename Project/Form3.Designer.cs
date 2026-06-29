namespace Project
{
    partial class BattleForm
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
            label1 = new Label();
            richTextBoxLog = new RichTextBox();
            btnUniqueSkill = new Button();
            lblPlayerName = new Label();
            label3 = new Label();
            lblPlayerHP = new Label();
            label5 = new Label();
            lblPlayerMP = new Label();
            btnStrongAttack = new Button();
            btnHeal = new Button();
            btnRest = new Button();
            picturePlayer = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            pictureEnemy = new PictureBox();
            lblEnemyHP = new Label();
            lblEnemyName = new Label();
            lblEnemyLevel = new Label();
            btnAttack = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Location = new Point(597, 0);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(266, 611);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "";
            // 
            // btnUniqueSkill
            // 
            btnUniqueSkill.FlatStyle = FlatStyle.Popup;
            btnUniqueSkill.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnUniqueSkill.Location = new Point(25, 302);
            btnUniqueSkill.Name = "btnUniqueSkill";
            btnUniqueSkill.Size = new Size(139, 57);
            btnUniqueSkill.TabIndex = 2;
            btnUniqueSkill.Text = "Unique Skill";
            btnUniqueSkill.UseVisualStyleBackColor = true;
            btnUniqueSkill.Click += btnUniqueSkill_Click;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerName.Location = new Point(106, 21);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(58, 21);
            lblPlayerName.TabIndex = 3;
            lblPlayerName.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 4;
            label3.Text = "Health:";
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerHP.Location = new Point(106, 68);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(58, 21);
            lblPlayerHP.TabIndex = 5;
            lblPlayerHP.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(20, 117);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 6;
            label5.Text = "Mana";
            // 
            // lblPlayerMP
            // 
            lblPlayerMP.AutoSize = true;
            lblPlayerMP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerMP.Location = new Point(106, 117);
            lblPlayerMP.Name = "lblPlayerMP";
            lblPlayerMP.Size = new Size(58, 21);
            lblPlayerMP.TabIndex = 7;
            lblPlayerMP.Text = "label6";
            // 
            // btnStrongAttack
            // 
            btnStrongAttack.FlatStyle = FlatStyle.Popup;
            btnStrongAttack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnStrongAttack.Location = new Point(25, 380);
            btnStrongAttack.Name = "btnStrongAttack";
            btnStrongAttack.Size = new Size(139, 57);
            btnStrongAttack.TabIndex = 12;
            btnStrongAttack.Text = "SuperAttack";
            btnStrongAttack.UseVisualStyleBackColor = true;
            btnStrongAttack.Click += btnStrongAttack_Click;
            // 
            // btnHeal
            // 
            btnHeal.FlatStyle = FlatStyle.Popup;
            btnHeal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnHeal.Location = new Point(25, 458);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(139, 57);
            btnHeal.TabIndex = 13;
            btnHeal.Text = "Heal";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += btnHeal_Click;
            // 
            // btnRest
            // 
            btnRest.FlatStyle = FlatStyle.Popup;
            btnRest.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRest.Location = new Point(25, 533);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(139, 57);
            btnRest.TabIndex = 14;
            btnRest.Text = "Rest";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // picturePlayer
            // 
            picturePlayer.Location = new Point(214, 168);
            picturePlayer.Name = "picturePlayer";
            picturePlayer.Size = new Size(292, 443);
            picturePlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayer.TabIndex = 18;
            picturePlayer.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(1141, 21);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.Location = new Point(1141, 68);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 10;
            label9.Text = "Level";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(1141, 117);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 15;
            label11.Text = "Health";
            // 
            // pictureEnemy
            // 
            pictureEnemy.Location = new Point(934, 168);
            pictureEnemy.Name = "pictureEnemy";
            pictureEnemy.Size = new Size(399, 443);
            pictureEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEnemy.TabIndex = 17;
            pictureEnemy.TabStop = false;
            // 
            // lblEnemyHP
            // 
            lblEnemyHP.AutoSize = true;
            lblEnemyHP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyHP.Location = new Point(1220, 117);
            lblEnemyHP.Name = "lblEnemyHP";
            lblEnemyHP.Size = new Size(68, 21);
            lblEnemyHP.TabIndex = 16;
            lblEnemyHP.Text = "label12";
            // 
            // lblEnemyName
            // 
            lblEnemyName.AutoSize = true;
            lblEnemyName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyName.Location = new Point(1220, 21);
            lblEnemyName.Name = "lblEnemyName";
            lblEnemyName.Size = new Size(58, 21);
            lblEnemyName.TabIndex = 9;
            lblEnemyName.Text = "label8";
            // 
            // lblEnemyLevel
            // 
            lblEnemyLevel.AutoSize = true;
            lblEnemyLevel.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyLevel.Location = new Point(1220, 68);
            lblEnemyLevel.Name = "lblEnemyLevel";
            lblEnemyLevel.Size = new Size(68, 21);
            lblEnemyLevel.TabIndex = 11;
            lblEnemyLevel.Text = "label10";
            // 
            // btnAttack
            // 
            btnAttack.FlatStyle = FlatStyle.Popup;
            btnAttack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAttack.Location = new Point(25, 226);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(139, 57);
            btnAttack.TabIndex = 19;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // BattleForm
            // 
            AccessibleRole = AccessibleRole.IpAddress;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1374, 612);
            Controls.Add(btnAttack);
            Controls.Add(picturePlayer);
            Controls.Add(pictureEnemy);
            Controls.Add(lblEnemyHP);
            Controls.Add(label11);
            Controls.Add(btnRest);
            Controls.Add(btnHeal);
            Controls.Add(btnStrongAttack);
            Controls.Add(lblEnemyLevel);
            Controls.Add(label9);
            Controls.Add(lblEnemyName);
            Controls.Add(label7);
            Controls.Add(lblPlayerMP);
            Controls.Add(label5);
            Controls.Add(lblPlayerHP);
            Controls.Add(label3);
            Controls.Add(lblPlayerName);
            Controls.Add(btnUniqueSkill);
            Controls.Add(richTextBoxLog);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "BattleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BattleForm";
            ((System.ComponentModel.ISupportInitialize)picturePlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxLog;
        private Button btnUniqueSkill;
        private Label lblPlayerName;
        private Label label3;
        private Label lblPlayerHP;
        private Label label5;
        private Label lblPlayerMP;
        private Button btnStrongAttack;
        private Button btnHeal;
        private Button btnRest;
        private PictureBox picturePlayer;
        private Label label7;
        private Label label9;
        private Label label11;
        private PictureBox pictureEnemy;
        private Label lblEnemyHP;
        private Label lblEnemyName;
        private Label lblEnemyLevel;
        private Button btnAttack;
    }
}