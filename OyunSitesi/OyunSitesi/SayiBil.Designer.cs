namespace OyunSitesi
{
    partial class SayiBil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SayiBil));
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Timer(this.components);
            this.lbSkor = new System.Windows.Forms.ListBox();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lblBilgiEkranı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTahmin
            // 
            this.btnTahmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTahmin.BackColor = System.Drawing.SystemColors.Info;
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(87, 264);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(417, 59);
            this.btnTahmin.TabIndex = 0;
            this.btnTahmin.Text = "Tahminde Bulun";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(92, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "1-200 arasında Bir sayı Giriniz:";
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBasla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(95, 114);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(409, 53);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Oyunu Başlat";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Süre";
            // 
            // lblSure
            // 
            this.lblSure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSure.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblSure.ForeColor = System.Drawing.Color.Lime;
            this.lblSure.Location = new System.Drawing.Point(242, 50);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(98, 38);
            this.lblSure.TabIndex = 4;
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSure.Click += new System.EventHandler(this.lblSure_Click);
            // 
            // Sure
            // 
            this.Sure.Interval = 1000;
            this.Sure.Tick += new System.EventHandler(this.Sure_Tick);
            // 
            // lbSkor
            // 
            this.lbSkor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSkor.FormattingEnabled = true;
            this.lbSkor.ItemHeight = 22;
            this.lbSkor.Location = new System.Drawing.Point(530, 32);
            this.lbSkor.Name = "lbSkor";
            this.lbSkor.Size = new System.Drawing.Size(258, 400);
            this.lbSkor.TabIndex = 5;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTahmin.Location = new System.Drawing.Point(421, 197);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(83, 22);
            this.txtTahmin.TabIndex = 6;
            // 
            // lblBilgiEkranı
            // 
            this.lblBilgiEkranı.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBilgiEkranı.BackColor = System.Drawing.SystemColors.Window;
            this.lblBilgiEkranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiEkranı.Location = new System.Drawing.Point(92, 344);
            this.lblBilgiEkranı.Name = "lblBilgiEkranı";
            this.lblBilgiEkranı.Size = new System.Drawing.Size(412, 52);
            this.lblBilgiEkranı.TabIndex = 7;
            this.lblBilgiEkranı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SayiBil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBilgiEkranı);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lbSkor);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTahmin);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "SayiBil";
            this.Text = "SayiBil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer Sure;
        private System.Windows.Forms.ListBox lbSkor;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label lblBilgiEkranı;
    }
}