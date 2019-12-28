namespace SilverMeal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listPeriyot = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listMiktar = new System.Windows.Forms.ListBox();
            this.listTalep = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtSutunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEldeBulundurmaMal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSabitMal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Periyot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Talep";
            // 
            // listPeriyot
            // 
            this.listPeriyot.FormattingEnabled = true;
            this.listPeriyot.Location = new System.Drawing.Point(281, 45);
            this.listPeriyot.Name = "listPeriyot";
            this.listPeriyot.Size = new System.Drawing.Size(46, 225);
            this.listPeriyot.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Miktar";
            // 
            // listMiktar
            // 
            this.listMiktar.FormattingEnabled = true;
            this.listMiktar.Location = new System.Drawing.Point(385, 45);
            this.listMiktar.Name = "listMiktar";
            this.listMiktar.Size = new System.Drawing.Size(46, 225);
            this.listMiktar.TabIndex = 24;
            // 
            // listTalep
            // 
            this.listTalep.FormattingEnabled = true;
            this.listTalep.Location = new System.Drawing.Point(333, 45);
            this.listTalep.Name = "listTalep";
            this.listTalep.Size = new System.Drawing.Size(46, 225);
            this.listTalep.TabIndex = 23;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(26, 234);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(191, 36);
            this.btnHesapla.TabIndex = 22;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.txtSutunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSayfaAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(26, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 133);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(55, 92);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtSutunAdi
            // 
            this.txtSutunAdi.Location = new System.Drawing.Point(66, 57);
            this.txtSutunAdi.Name = "txtSutunAdi";
            this.txtSutunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSutunAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sütun Adı:";
            // 
            // txtSayfaAdi
            // 
            this.txtSayfaAdi.Location = new System.Drawing.Point(66, 31);
            this.txtSayfaAdi.Name = "txtSayfaAdi";
            this.txtSayfaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa Adı:";
            // 
            // txtEldeBulundurmaMal
            // 
            this.txtEldeBulundurmaMal.Location = new System.Drawing.Point(154, 59);
            this.txtEldeBulundurmaMal.Name = "txtEldeBulundurmaMal";
            this.txtEldeBulundurmaMal.Size = new System.Drawing.Size(100, 20);
            this.txtEldeBulundurmaMal.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Elde Bulundurma Maliyeti:";
            // 
            // txtSabitMal
            // 
            this.txtSabitMal.Location = new System.Drawing.Point(154, 33);
            this.txtSabitMal.Name = "txtSabitMal";
            this.txtSabitMal.Size = new System.Drawing.Size(100, 20);
            this.txtSabitMal.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sabit Maliyet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 290);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPeriyot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listMiktar);
            this.Controls.Add(this.listTalep);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEldeBulundurmaMal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSabitMal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listPeriyot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listMiktar;
        private System.Windows.Forms.ListBox listTalep;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtSutunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEldeBulundurmaMal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSabitMal;
        private System.Windows.Forms.Label label1;
    }
}

