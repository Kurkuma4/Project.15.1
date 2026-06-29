namespace Project
{
    partial class CharacterSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelectForm));
            lblHeroName = new Label();
            lblTitle = new Label();
            pictureHero = new PictureBox();
            btnBack = new Button();
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHero).BeginInit();
            SuspendLayout();
            // 
            // lblHeroName
            // 
            lblHeroName.BackColor = Color.Transparent;
            lblHeroName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblHeroName.ForeColor = Color.White;
            lblHeroName.Location = new Point(341, 287);
            lblHeroName.Name = "lblHeroName";
            lblHeroName.Size = new Size(139, 25);
            lblHeroName.TabIndex = 12;
            lblHeroName.Text = ".";
            lblHeroName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(123, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(586, 47);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "⚔ CHOOSE YOUR CHARACTER ⚔";
            // 
            // pictureHero
            // 
            pictureHero.Location = new Point(341, 125);
            pictureHero.Name = "pictureHero";
            pictureHero.Size = new Size(139, 138);
            pictureHero.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHero.TabIndex = 8;
            pictureHero.TabStop = false;
            pictureHero.Click += pictureHero_Click;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(457, 343);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(132, 46);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatStyle = FlatStyle.Popup;
            btnInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnInfo.Location = new Point(233, 343);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(132, 46);
            btnInfo.TabIndex = 14;
            btnInfo.Text = "Character Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // CharacterSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInfo);
            Controls.Add(btnBack);
            Controls.Add(lblHeroName);
            Controls.Add(lblTitle);
            Controls.Add(pictureHero);
            Name = "CharacterSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CharacterSelectForm";
            ((System.ComponentModel.ISupportInitialize)pictureHero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeroName;
        private Label lblTitle;
        private PictureBox pictureHero;
        private Button btnBack;
        private Button btnInfo;
    }
}