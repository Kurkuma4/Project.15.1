namespace Project
{
    partial class DifficultySelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultySelectForm));
            label1 = new Label();
            pictureHard = new PictureBox();
            pictureNormal = new PictureBox();
            pictureEasy = new PictureBox();
            btnInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEasy).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 73);
            label1.Name = "label1";
            label1.Size = new Size(763, 65);
            label1.TabIndex = 10;
            label1.Text = "⚔ CHOOSE YOUR DIFFICULTY ⚔";
            // 
            // pictureHard
            // 
            pictureHard.Image = (Image)resources.GetObject("pictureHard.Image");
            pictureHard.Location = new Point(542, 170);
            pictureHard.Name = "pictureHard";
            pictureHard.Size = new Size(139, 161);
            pictureHard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHard.TabIndex = 9;
            pictureHard.TabStop = false;
            pictureHard.Click += pictureHard_Click;
            // 
            // pictureNormal
            // 
            pictureNormal.Image = (Image)resources.GetObject("pictureNormal.Image");
            pictureNormal.Location = new Point(322, 170);
            pictureNormal.Name = "pictureNormal";
            pictureNormal.Size = new Size(139, 161);
            pictureNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureNormal.TabIndex = 8;
            pictureNormal.TabStop = false;
            pictureNormal.Click += pictureNormal_Click;
            // 
            // pictureEasy
            // 
            pictureEasy.AccessibleRole = AccessibleRole.Clock;
            pictureEasy.Image = (Image)resources.GetObject("pictureEasy.Image");
            pictureEasy.Location = new Point(100, 170);
            pictureEasy.Name = "pictureEasy";
            pictureEasy.Size = new Size(139, 161);
            pictureEasy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEasy.TabIndex = 7;
            pictureEasy.TabStop = false;
            pictureEasy.Click += pictureEasy_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatStyle = FlatStyle.Popup;
            btnInfo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnInfo.Location = new Point(322, 368);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(139, 52);
            btnInfo.TabIndex = 11;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // DifficultySelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInfo);
            Controls.Add(label1);
            Controls.Add(pictureHard);
            Controls.Add(pictureNormal);
            Controls.Add(pictureEasy);
            Name = "DifficultySelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DifficultySelectForm";
            ((System.ComponentModel.ISupportInitialize)pictureHard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEasy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureHard;
        private PictureBox pictureNormal;
        private PictureBox pictureEasy;
        private Button btnInfo;
    }
}