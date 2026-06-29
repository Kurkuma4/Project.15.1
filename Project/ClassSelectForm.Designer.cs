namespace Project
{
    partial class ClassSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSelectForm));
            pictureClassMage = new PictureBox();
            pictureClassArcher = new PictureBox();
            pictureClassTank = new PictureBox();
            label1 = new Label();
            lblMage = new Label();
            lblArcher = new Label();
            lblTank = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureClassMage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureClassArcher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureClassTank).BeginInit();
            SuspendLayout();
            // 
            // pictureClassMage
            // 
            pictureClassMage.Location = new Point(106, 193);
            pictureClassMage.Name = "pictureClassMage";
            pictureClassMage.Size = new Size(139, 138);
            pictureClassMage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClassMage.TabIndex = 0;
            pictureClassMage.TabStop = false;
            pictureClassMage.Click += pictureClassMage_Click;
            // 
            // pictureClassArcher
            // 
            pictureClassArcher.Location = new Point(328, 193);
            pictureClassArcher.Name = "pictureClassArcher";
            pictureClassArcher.Size = new Size(139, 138);
            pictureClassArcher.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClassArcher.TabIndex = 1;
            pictureClassArcher.TabStop = false;
            pictureClassArcher.Click += pictureClassArcher_Click;
            // 
            // pictureClassTank
            // 
            pictureClassTank.Location = new Point(545, 193);
            pictureClassTank.Name = "pictureClassTank";
            pictureClassTank.Size = new Size(139, 138);
            pictureClassTank.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClassTank.TabIndex = 2;
            pictureClassTank.TabStop = false;
            pictureClassTank.Click += pictureClassTank_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 69);
            label1.Name = "label1";
            label1.Size = new Size(658, 65);
            label1.TabIndex = 3;
            label1.Text = "⚔ CHOOSE YOUR CLASS ⚔";
            // 
            // lblMage
            // 
            lblMage.AutoSize = true;
            lblMage.BackColor = Color.Transparent;
            lblMage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMage.ForeColor = SystemColors.Control;
            lblMage.Location = new Point(144, 356);
            lblMage.Name = "lblMage";
            lblMage.Size = new Size(62, 25);
            lblMage.TabIndex = 4;
            lblMage.Text = "Mage";
            // 
            // lblArcher
            // 
            lblArcher.AutoSize = true;
            lblArcher.BackColor = Color.Transparent;
            lblArcher.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblArcher.ForeColor = Color.White;
            lblArcher.Location = new Point(361, 356);
            lblArcher.Name = "lblArcher";
            lblArcher.Size = new Size(71, 25);
            lblArcher.TabIndex = 5;
            lblArcher.Text = "Archer";
            // 
            // lblTank
            // 
            lblTank.AutoSize = true;
            lblTank.BackColor = Color.Transparent;
            lblTank.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTank.ForeColor = SystemColors.Control;
            lblTank.Location = new Point(588, 356);
            lblTank.Name = "lblTank";
            lblTank.Size = new Size(54, 25);
            lblTank.TabIndex = 6;
            lblTank.Text = "Tank";
            // 
            // ClassSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTank);
            Controls.Add(lblArcher);
            Controls.Add(lblMage);
            Controls.Add(label1);
            Controls.Add(pictureClassTank);
            Controls.Add(pictureClassArcher);
            Controls.Add(pictureClassMage);
            Name = "ClassSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeroSelectForm";
            ((System.ComponentModel.ISupportInitialize)pictureClassMage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureClassArcher).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureClassTank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureClassMage;
        private PictureBox pictureClassArcher;
        private PictureBox pictureClassTank;
        private Label label1;
        private Label lblMage;
        private Label lblArcher;
        private Label lblTank;
    }
}