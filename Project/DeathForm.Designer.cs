namespace Project
{
    partial class DeathForm
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
            lblTitle = new Label();
            lblEnemy = new Label();
            lblStats = new Label();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Impact", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(247, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 82);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "YOU DIED";
            // 
            // lblEnemy
            // 
            lblEnemy.AutoSize = true;
            lblEnemy.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEnemy.Location = new Point(274, 206);
            lblEnemy.Name = "lblEnemy";
            lblEnemy.Size = new Size(109, 19);
            lblEnemy.TabIndex = 1;
            lblEnemy.Text = "Вас переміг:";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStats.Location = new Point(274, 267);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(127, 19);
            lblStats.TabIndex = 2;
            lblStats.Text = "Ваший рівень:";
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(192, 332);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(387, 91);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Повернутися в меню";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // DeathForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(lblStats);
            Controls.Add(lblEnemy);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.Control;
            Name = "DeathForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeathForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEnemy;
        private Label lblStats;
        private Button btnMenu;
    }
}