namespace EsiniBulOyunu
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
            pnlKartlar = new Panel();
            gboYeniOyun = new GroupBox();
            rb5 = new RadioButton();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            menuStrip1 = new MenuStrip();
            oyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Location = new Point(12, 36);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(780, 747);
            pnlKartlar.TabIndex = 0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gboYeniOyun.ForeColor = Color.Bisque;
            gboYeniOyun.Location = new Point(223, 226);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(380, 361);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            // 
            // rb5
            // 
            rb5.Anchor = AnchorStyles.None;
            rb5.AutoSize = true;
            rb5.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rb5.ForeColor = Color.Bisque;
            rb5.Location = new Point(103, 233);
            rb5.Name = "rb5";
            rb5.Size = new Size(160, 39);
            rb5.TabIndex = 1;
            rb5.TabStop = true;
            rb5.Text = "Çok zor";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.Anchor = AnchorStyles.None;
            rb4.AutoSize = true;
            rb4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rb4.ForeColor = Color.Bisque;
            rb4.Location = new Point(103, 185);
            rb4.Name = "rb4";
            rb4.Size = new Size(97, 39);
            rb4.TabIndex = 1;
            rb4.TabStop = true;
            rb4.Text = "Zor";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.Anchor = AnchorStyles.None;
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rb3.ForeColor = Color.Bisque;
            rb3.Location = new Point(103, 137);
            rb3.Name = "rb3";
            rb3.Size = new Size(113, 39);
            rb3.TabIndex = 1;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.Anchor = AnchorStyles.None;
            rb2.AutoSize = true;
            rb2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rb2.ForeColor = Color.Bisque;
            rb2.Location = new Point(103, 89);
            rb2.Name = "rb2";
            rb2.Size = new Size(131, 39);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.AutoSize = true;
            rb1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rb1.ForeColor = Color.Bisque;
            rb1.Location = new Point(103, 41);
            rb1.Name = "rb1";
            rb1.Size = new Size(194, 39);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Anchor = AnchorStyles.None;
            btnOyunuBaslat.BackColor = Color.LightSalmon;
            btnOyunuBaslat.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOyunuBaslat.ForeColor = Color.Bisque;
            btnOyunuBaslat.Location = new Point(27, 285);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(338, 70);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Baslat";
            btnOyunuBaslat.UseVisualStyleBackColor = false;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            oyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            oyunToolStripMenuItem.Size = new Size(71, 29);
            oyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(224, 34);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.MicrosoftTeams_image__1_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(804, 795);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private Button btnOyunuBaslat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}