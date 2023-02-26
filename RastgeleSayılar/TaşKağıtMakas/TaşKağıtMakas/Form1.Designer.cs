namespace TaşKağıtMakas
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
            this.btnMakas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKullanıcıPuan = new System.Windows.Forms.Label();
            this.lblPCPuan = new System.Windows.Forms.Label();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.lblKullanıcıEkran = new System.Windows.Forms.Label();
            this.lblPcEkran = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnKagıt = new System.Windows.Forms.Button();
            this.btnTas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakas
            // 
            this.btnMakas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMakas.Location = new System.Drawing.Point(9, 380);
            this.btnMakas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(116, 42);
            this.btnMakas.TabIndex = 0;
            this.btnMakas.Text = "Makas";
            this.btnMakas.UseVisualStyleBackColor = false;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilgisayar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı";
            // 
            // lblKullanıcıPuan
            // 
            this.lblKullanıcıPuan.AutoSize = true;
            this.lblKullanıcıPuan.Location = new System.Drawing.Point(123, 305);
            this.lblKullanıcıPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullanıcıPuan.Name = "lblKullanıcıPuan";
            this.lblKullanıcıPuan.Size = new System.Drawing.Size(0, 22);
            this.lblKullanıcıPuan.TabIndex = 3;
            // 
            // lblPCPuan
            // 
            this.lblPCPuan.AutoSize = true;
            this.lblPCPuan.Location = new System.Drawing.Point(123, 59);
            this.lblPCPuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCPuan.Name = "lblPCPuan";
            this.lblPCPuan.Size = new System.Drawing.Size(0, 22);
            this.lblPCPuan.TabIndex = 4;
            // 
            // txtIsım
            // 
            this.txtIsım.Location = new System.Drawing.Point(99, 573);
            this.txtIsım.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(158, 29);
            this.txtIsım.TabIndex = 5;
            this.txtIsım.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblKullanıcıEkran
            // 
            this.lblKullanıcıEkran.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKullanıcıEkran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKullanıcıEkran.Location = new System.Drawing.Point(225, 224);
            this.lblKullanıcıEkran.Name = "lblKullanıcıEkran";
            this.lblKullanıcıEkran.Size = new System.Drawing.Size(147, 134);
            this.lblKullanıcıEkran.TabIndex = 7;
            this.lblKullanıcıEkran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPcEkran
            // 
            this.lblPcEkran.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPcEkran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPcEkran.Location = new System.Drawing.Point(225, 45);
            this.lblPcEkran.Name = "lblPcEkran";
            this.lblPcEkran.Size = new System.Drawing.Size(147, 134);
            this.lblPcEkran.TabIndex = 7;
            this.lblPcEkran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 580);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "İsim";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(281, 573);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(91, 29);
            this.btnKayıt.TabIndex = 9;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnKagıt
            // 
            this.btnKagıt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKagıt.Location = new System.Drawing.Point(133, 380);
            this.btnKagıt.Margin = new System.Windows.Forms.Padding(4);
            this.btnKagıt.Name = "btnKagıt";
            this.btnKagıt.Size = new System.Drawing.Size(116, 42);
            this.btnKagıt.TabIndex = 0;
            this.btnKagıt.Text = "Kağıt";
            this.btnKagıt.UseVisualStyleBackColor = false;
            this.btnKagıt.Click += new System.EventHandler(this.btnKagıt_Click);
            // 
            // btnTas
            // 
            this.btnTas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTas.Location = new System.Drawing.Point(256, 380);
            this.btnTas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(116, 42);
            this.btnTas.TabIndex = 0;
            this.btnTas.Text = "Taş";
            this.btnTas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPcEkran);
            this.Controls.Add(this.lblKullanıcıEkran);
            this.Controls.Add(this.txtIsım);
            this.Controls.Add(this.lblPCPuan);
            this.Controls.Add(this.lblKullanıcıPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTas);
            this.Controls.Add(this.btnKagıt);
            this.Controls.Add(this.btnMakas);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKullanıcıPuan;
        private System.Windows.Forms.Label lblPCPuan;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Label lblKullanıcıEkran;
        private System.Windows.Forms.Label lblPcEkran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnKagıt;
        private System.Windows.Forms.Button btnTas;
    }
}

