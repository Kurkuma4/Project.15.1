namespace Project
{
    partial class HeroSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroSelectForm));
            pictureMage = new PictureBox();
            pictureElf = new PictureBox();
            pictureBarbarian = new PictureBox();
            label1 = new Label();
            lblMage = new Label();
            lblElf = new Label();
            lblBarbarian = new Label();
            btnMage = new Button();
            btnElf = new Button();
            btnBarbarian = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureMage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureElf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBarbarian).BeginInit();
            SuspendLayout();
            // 
            // pictureMage
            // 
            pictureMage.Location = new Point(105, 106);
            pictureMage.Name = "pictureMage";
            pictureMage.Size = new Size(139, 138);
            pictureMage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMage.TabIndex = 0;
            pictureMage.TabStop = false;
            // 
            // pictureElf
            // 
            pictureElf.Location = new Point(325, 106);
            pictureElf.Name = "pictureElf";
            pictureElf.Size = new Size(139, 138);
            pictureElf.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureElf.TabIndex = 1;
            pictureElf.TabStop = false;
            // 
            // pictureBarbarian
            // 
            pictureBarbarian.Location = new Point(543, 106);
            pictureBarbarian.Name = "pictureBarbarian";
            pictureBarbarian.Size = new Size(139, 138);
            pictureBarbarian.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBarbarian.TabIndex = 2;
            pictureBarbarian.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 27);
            label1.Name = "label1";
            label1.Size = new Size(438, 37);
            label1.TabIndex = 3;
            label1.Text = "⚔ CHOOSE YOUR CHARACTER ⚔";
            // 
            // lblMage
            // 
            lblMage.AutoSize = true;
            lblMage.BackColor = Color.Transparent;
            lblMage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMage.ForeColor = SystemColors.Control;
            lblMage.Location = new Point(141, 266);
            lblMage.Name = "lblMage";
            lblMage.Size = new Size(62, 25);
            lblMage.TabIndex = 4;
            lblMage.Text = "Mage";
            // 
            // lblElf
            // 
            lblElf.AutoSize = true;
            lblElf.BackColor = Color.Transparent;
            lblElf.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblElf.ForeColor = Color.Black;
            lblElf.Location = new Point(379, 266);
            lblElf.Name = "lblElf";
            lblElf.Size = new Size(34, 25);
            lblElf.TabIndex = 5;
            lblElf.Text = "Elf";
            // 
            // lblBarbarian
            // 
            lblBarbarian.AutoSize = true;
            lblBarbarian.BackColor = Color.Transparent;
            lblBarbarian.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBarbarian.ForeColor = SystemColors.Control;
            lblBarbarian.Location = new Point(566, 266);
            lblBarbarian.Name = "lblBarbarian";
            lblBarbarian.Size = new Size(99, 25);
            lblBarbarian.TabIndex = 6;
            lblBarbarian.Text = "Barbarian";
            // 
            // btnMage
            // 
            btnMage.FlatStyle = FlatStyle.Popup;
            btnMage.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMage.Location = new Point(105, 317);
            btnMage.Name = "btnMage";
            btnMage.Size = new Size(139, 54);
            btnMage.TabIndex = 7;
            btnMage.Text = "Choose Mage";
            btnMage.UseVisualStyleBackColor = true;
            btnMage.Click += btnMage_Click;
            // 
            // btnElf
            // 
            btnElf.FlatStyle = FlatStyle.Popup;
            btnElf.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnElf.Location = new Point(325, 317);
            btnElf.Name = "btnElf";
            btnElf.Size = new Size(139, 54);
            btnElf.TabIndex = 8;
            btnElf.Text = "Choose Elf";
            btnElf.UseVisualStyleBackColor = true;
            btnElf.Click += btnElf_Click;
            // 
            // btnBarbarian
            // 
            btnBarbarian.FlatStyle = FlatStyle.Popup;
            btnBarbarian.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBarbarian.Location = new Point(543, 317);
            btnBarbarian.Name = "btnBarbarian";
            btnBarbarian.Size = new Size(139, 54);
            btnBarbarian.TabIndex = 9;
            btnBarbarian.Text = "Choose Barbarian";
            btnBarbarian.UseVisualStyleBackColor = true;
            btnBarbarian.Click += btnBarbarian_Click;
            // 
            // HeroSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBarbarian);
            Controls.Add(btnElf);
            Controls.Add(btnMage);
            Controls.Add(lblBarbarian);
            Controls.Add(lblElf);
            Controls.Add(lblMage);
            Controls.Add(label1);
            Controls.Add(pictureBarbarian);
            Controls.Add(pictureElf);
            Controls.Add(pictureMage);
            Name = "HeroSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeroSelectForm";
            ((System.ComponentModel.ISupportInitialize)pictureMage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureElf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBarbarian).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureMage;
        private PictureBox pictureElf;
        private PictureBox pictureBarbarian;
        private Label label1;
        private Label lblMage;
        private Label lblElf;
        private Label lblBarbarian;
        private Button btnMage;
        private Button btnElf;
        private Button btnBarbarian;
    }
}