namespace Project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lblTitle = new Label();
            btnStart = new Button();
            btnRules = new Button();
            btnExit = new Button();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(207, 220);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(553, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "⚔ RPG ADVENTURE ⚔";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnStart.Location = new Point(207, 516);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(163, 51);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnRules
            // 
            btnRules.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRules.Location = new Point(399, 516);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(163, 51);
            btnRules.TabIndex = 2;
            btnRules.Text = "Rules";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += btnRules_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(591, 516);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 51);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(871, 549);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(87, 21);
            lblVersion.TabIndex = 4;
            lblVersion.Text = "Version 1.0";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 579);
            Controls.Add(lblVersion);
            Controls.Add(btnExit);
            Controls.Add(btnRules);
            Controls.Add(btnStart);
            Controls.Add(lblTitle);
            ForeColor = Color.Black;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnStart;
        private Button btnRules;
        private Button btnExit;
        private Label lblVersion;
    }
}