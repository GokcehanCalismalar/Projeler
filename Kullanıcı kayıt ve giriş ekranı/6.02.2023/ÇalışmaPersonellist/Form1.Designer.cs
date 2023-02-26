namespace ÇalışmaPersonellist
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblGmail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chcGoster = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciGirişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ÇalışmaPersonellist.Properties.Resources.tekno;
            this.pictureBox1.Location = new System.Drawing.Point(429, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(121, 244);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(186, 37);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.BackColor = System.Drawing.Color.Transparent;
            this.lblGmail.Location = new System.Drawing.Point(-3, 113);
            this.lblGmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(104, 18);
            this.lblGmail.TabIndex = 3;
            this.lblGmail.Text = "Gmail Adresi";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(121, 110);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 24);
            this.txtMail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(121, 165);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(186, 24);
            this.txtSifre.TabIndex = 4;
            // 
            // chcGoster
            // 
            this.chcGoster.AutoSize = true;
            this.chcGoster.BackColor = System.Drawing.Color.Transparent;
            this.chcGoster.ForeColor = System.Drawing.Color.White;
            this.chcGoster.Location = new System.Drawing.Point(225, 204);
            this.chcGoster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chcGoster.Name = "chcGoster";
            this.chcGoster.Size = new System.Drawing.Size(82, 22);
            this.chcGoster.TabIndex = 5;
            this.chcGoster.Text = "Göster";
            this.chcGoster.UseVisualStyleBackColor = false;
            this.chcGoster.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Öğrenci Giriş Ekranı";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciGirişEkranıToolStripMenuItem,
            this.personelGirişToolStripMenuItem,
            this.kayıtOluşturToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciGirişEkranıToolStripMenuItem
            // 
            this.öğrenciGirişEkranıToolStripMenuItem.Name = "öğrenciGirişEkranıToolStripMenuItem";
            this.öğrenciGirişEkranıToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.öğrenciGirişEkranıToolStripMenuItem.Text = "Öğrenci Giriş Ekranı";
            // 
            // personelGirişToolStripMenuItem
            // 
            this.personelGirişToolStripMenuItem.Name = "personelGirişToolStripMenuItem";
            this.personelGirişToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.personelGirişToolStripMenuItem.Text = "Personel Giriş";
            // 
            // kayıtOluşturToolStripMenuItem
            // 
            this.kayıtOluşturToolStripMenuItem.Name = "kayıtOluşturToolStripMenuItem";
            this.kayıtOluşturToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.kayıtOluşturToolStripMenuItem.Text = "Kayıt Oluştur";
            this.kayıtOluşturToolStripMenuItem.Click += new System.EventHandler(this.kayıtOluşturToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ÇalışmaPersonellist.Properties.Resources.tekno1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcGoster);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chcGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGirişEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtOluşturToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

