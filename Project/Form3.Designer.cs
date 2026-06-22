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
            btnAttack = new Button();
            lblPlayerName = new Label();
            label3 = new Label();
            lblPlayerHP = new Label();
            label5 = new Label();
            lblPlayerMP = new Label();
            label7 = new Label();
            lblEnemyName = new Label();
            label9 = new Label();
            lblEnemyLevel = new Label();
            btnStrongAttack = new Button();
            btnHeal = new Button();
            btnRest = new Button();
            label11 = new Label();
            lblEnemyHP = new Label();
            pictureEnemy = new PictureBox();
            picturePlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Location = new Point(461, 1);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(196, 610);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "";
            // 
            // btnAttack
            // 
            btnAttack.FlatStyle = FlatStyle.Popup;
            btnAttack.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAttack.Location = new Point(25, 302);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(139, 57);
            btnAttack.TabIndex = 2;
            btnAttack.Text = "Attack";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerName.Location = new Point(116, 41);
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
            label3.Location = new Point(25, 79);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 4;
            label3.Text = "Health:";
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerHP.Location = new Point(116, 79);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(58, 21);
            lblPlayerHP.TabIndex = 5;
            lblPlayerHP.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(25, 117);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 6;
            label5.Text = "Mana";
            // 
            // lblPlayerMP
            // 
            lblPlayerMP.AutoSize = true;
            lblPlayerMP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPlayerMP.Location = new Point(116, 117);
            lblPlayerMP.Name = "lblPlayerMP";
            lblPlayerMP.Size = new Size(58, 21);
            lblPlayerMP.TabIndex = 7;
            lblPlayerMP.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(863, 41);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // lblEnemyName
            // 
            lblEnemyName.AutoSize = true;
            lblEnemyName.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyName.Location = new Point(950, 41);
            lblEnemyName.Name = "lblEnemyName";
            lblEnemyName.Size = new Size(58, 21);
            lblEnemyName.TabIndex = 9;
            lblEnemyName.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.Location = new Point(863, 79);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 10;
            label9.Text = "Level";
            // 
            // lblEnemyLevel
            // 
            lblEnemyLevel.AutoSize = true;
            lblEnemyLevel.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyLevel.Location = new Point(950, 79);
            lblEnemyLevel.Name = "lblEnemyLevel";
            lblEnemyLevel.Size = new Size(68, 21);
            lblEnemyLevel.TabIndex = 11;
            lblEnemyLevel.Text = "label10";
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(863, 117);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 15;
            label11.Text = "Health";
            // 
            // lblEnemyHP
            // 
            lblEnemyHP.AutoSize = true;
            lblEnemyHP.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEnemyHP.Location = new Point(950, 117);
            lblEnemyHP.Name = "lblEnemyHP";
            lblEnemyHP.Size = new Size(68, 21);
            lblEnemyHP.TabIndex = 16;
            lblEnemyHP.Text = "label12";
            // 
            // pictureEnemy
            // 
            pictureEnemy.Location = new Point(673, 157);
            pictureEnemy.Name = "pictureEnemy";
            pictureEnemy.Size = new Size(345, 443);
            pictureEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEnemy.TabIndex = 17;
            pictureEnemy.TabStop = false;
            // 
            // picturePlayer
            // 
            picturePlayer.Location = new Point(194, 157);
            picturePlayer.Name = "picturePlayer";
            picturePlayer.Size = new Size(250, 443);
            picturePlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePlayer.TabIndex = 18;
            picturePlayer.TabStop = false;
            // 
            // BattleForm
            // 
            AccessibleRole = AccessibleRole.IpAddress;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 612);
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
            Controls.Add(btnAttack);
            Controls.Add(richTextBoxLog);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "BattleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BattleForm";
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxLog;
        private Button btnAttack;
        private Label lblPlayerName;
        private Label label3;
        private Label lblPlayerHP;
        private Label label5;
        private Label lblPlayerMP;
        private Label label7;
        private Label lblEnemyName;
        private Label label9;
        private Label lblEnemyLevel;
        private Button btnStrongAttack;
        private Button btnHeal;
        private Button btnRest;
        private Label label11;
        private Label lblEnemyHP;
        private PictureBox pictureEnemy;
        private PictureBox picturePlayer;
    }
}