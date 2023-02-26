namespace RastgeleSayılar
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSureYazı = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblEkran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(307, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Stencil", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(279, 9);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(0, 27);
            this.lblKullanıcıAdı.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblSureYazı
            // 
            this.lblSureYazı.AutoSize = true;
            this.lblSureYazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureYazı.Location = new System.Drawing.Point(23, 51);
            this.lblSureYazı.Name = "lblSureYazı";
            this.lblSureYazı.Size = new System.Drawing.Size(54, 24);
            this.lblSureYazı.TabIndex = 3;
            this.lblSureYazı.Text = "Süre";
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSure.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSure.Location = new System.Drawing.Point(17, 89);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(60, 36);
            this.lblSure.TabIndex = 4;
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSure
            // 
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.Location = new System.Drawing.Point(35, 9);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(680, 16);
            this.lblBilgilendirme.TabIndex = 5;
            this.lblBilgilendirme.Text = "Bu oyun amacı 0-50 arasında bir sayı verilicektir ve 20 saniye içerisinde doğru s" +
    "ayıyı tahmin etmeniz istenmektedir.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(55, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tahminizi Giriniz";
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.SystemColors.Info;
            this.btnTahmin.Location = new System.Drawing.Point(592, 216);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(122, 23);
            this.btnTahmin.TabIndex = 7;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = false;
            // 
            // lblEkran
            // 
            this.lblEkran.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEkran.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEkran.Location = new System.Drawing.Point(189, 151);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(364, 48);
            this.lblEkran.TabIndex = 8;
            this.lblEkran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEkran);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblSureYazı);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSureYazı;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblBilgilendirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblEkran;
    }
}