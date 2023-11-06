namespace _3_KitapDukkani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.rdbYok = new System.Windows.Forms.RadioButton();
            this.rdbVar = new System.Windows.Forms.RadioButton();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.cmbYazari = new System.Windows.Forms.ComboBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.cmbMeslegi = new System.Windows.Forms.ComboBox();
            this.cmbAldigiKitap = new System.Windows.Forms.ComboBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsbMusteriler = new System.Windows.Forms.ListBox();
            this.lsbKitapAdiYazarAdi = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDogumTarihi);
            this.groupBox1.Controls.Add(this.btnYazarEkle);
            this.groupBox1.Controls.Add(this.rdbYok);
            this.groupBox1.Controls.Add(this.rdbVar);
            this.groupBox1.Controls.Add(this.txtYazarAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YAZAR EKLE";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(116, 86);
            this.dtDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(184, 22);
            this.dtDogumTarihi.TabIndex = 19;
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(48, 206);
            this.btnYazarEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(129, 28);
            this.btnYazarEkle.TabIndex = 18;
            this.btnYazarEkle.Text = "YAZAR EKLE";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // rdbYok
            // 
            this.rdbYok.AutoSize = true;
            this.rdbYok.Location = new System.Drawing.Point(151, 158);
            this.rdbYok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbYok.Name = "rdbYok";
            this.rdbYok.Size = new System.Drawing.Size(55, 20);
            this.rdbYok.TabIndex = 15;
            this.rdbYok.TabStop = true;
            this.rdbYok.Text = "YOK";
            this.rdbYok.UseVisualStyleBackColor = true;
            // 
            // rdbVar
            // 
            this.rdbVar.AutoSize = true;
            this.rdbVar.Location = new System.Drawing.Point(151, 129);
            this.rdbVar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbVar.Name = "rdbVar";
            this.rdbVar.Size = new System.Drawing.Size(56, 20);
            this.rdbVar.TabIndex = 14;
            this.rdbVar.TabStop = true;
            this.rdbVar.Text = "VAR";
            this.rdbVar.UseVisualStyleBackColor = true;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(103, 33);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(132, 22);
            this.txtYazarAdi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nobel Ödülü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Controls.Add(this.cmbTuru);
            this.groupBox2.Controls.Add(this.cmbYazari);
            this.groupBox2.Controls.Add(this.txtKitapAdi);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.txtSayfaSayisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(439, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(352, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KİTAP EKLE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(108, 224);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(121, 28);
            this.btnKitapEkle.TabIndex = 19;
            this.btnKitapEkle.Text = "KİTAP EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Items.AddRange(new object[] {
            "Roman",
            "KPSS",
            "YDS",
            "İlköğretim",
            "Mühendislik"});
            this.cmbTuru.Location = new System.Drawing.Point(136, 80);
            this.cmbTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(160, 24);
            this.cmbTuru.TabIndex = 14;
            // 
            // cmbYazari
            // 
            this.cmbYazari.FormattingEnabled = true;
            this.cmbYazari.Location = new System.Drawing.Point(136, 191);
            this.cmbYazari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYazari.Name = "cmbYazari";
            this.cmbYazari.Size = new System.Drawing.Size(160, 24);
            this.cmbYazari.TabIndex = 15;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(136, 38);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(132, 22);
            this.txtKitapAdi.TabIndex = 13;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(136, 154);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(132, 22);
            this.txtFiyat.TabIndex = 14;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(136, 117);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(132, 22);
            this.txtSayfaSayisi.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Yazar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMusteriEkle);
            this.groupBox3.Controls.Add(this.cmbMeslegi);
            this.groupBox3.Controls.Add(this.cmbAldigiKitap);
            this.groupBox3.Controls.Add(this.txtMusteriAdi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(20, 334);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(356, 249);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MÜŞTERİ EKLE";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(88, 194);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(100, 28);
            this.btnMusteriEkle.TabIndex = 20;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // cmbMeslegi
            // 
            this.cmbMeslegi.FormattingEnabled = true;
            this.cmbMeslegi.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen",
            "Memur",
            "İşçi",
            "İş Arayan"});
            this.cmbMeslegi.Location = new System.Drawing.Point(99, 106);
            this.cmbMeslegi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMeslegi.Name = "cmbMeslegi";
            this.cmbMeslegi.Size = new System.Drawing.Size(160, 24);
            this.cmbMeslegi.TabIndex = 16;
            // 
            // cmbAldigiKitap
            // 
            this.cmbAldigiKitap.FormattingEnabled = true;
            this.cmbAldigiKitap.Location = new System.Drawing.Point(99, 139);
            this.cmbAldigiKitap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAldigiKitap.Name = "cmbAldigiKitap";
            this.cmbAldigiKitap.Size = new System.Drawing.Size(160, 24);
            this.cmbAldigiKitap.TabIndex = 17;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(99, 55);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(132, 22);
            this.txtMusteriAdi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Müşteri Adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mesleği:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Aldığı Kitap:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbMusteriler);
            this.groupBox4.Controls.Add(this.lsbKitapAdiYazarAdi);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(439, 334);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(352, 249);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SORGULA";
            // 
            // lsbMusteriler
            // 
            this.lsbMusteriler.FormattingEnabled = true;
            this.lsbMusteriler.ItemHeight = 16;
            this.lsbMusteriler.Location = new System.Drawing.Point(8, 59);
            this.lsbMusteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbMusteriler.Name = "lsbMusteriler";
            this.lsbMusteriler.Size = new System.Drawing.Size(159, 116);
            this.lsbMusteriler.TabIndex = 16;
            this.lsbMusteriler.SelectedIndexChanged += new System.EventHandler(this.lsbMusteriler_SelectedIndexChanged);
            this.lsbMusteriler.DoubleClick += new System.EventHandler(this.lsbMusteriler_DoubleClick);
            // 
            // lsbKitapAdiYazarAdi
            // 
            this.lsbKitapAdiYazarAdi.FormattingEnabled = true;
            this.lsbKitapAdiYazarAdi.ItemHeight = 16;
            this.lsbKitapAdiYazarAdi.Location = new System.Drawing.Point(184, 59);
            this.lsbKitapAdiYazarAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbKitapAdiYazarAdi.Name = "lsbKitapAdiYazarAdi";
            this.lsbKitapAdiYazarAdi.Size = new System.Drawing.Size(159, 116);
            this.lsbKitapAdiYazarAdi.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(23, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Hangi Müşteri Hangi Kitabı Aldı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.RadioButton rdbYok;
        private System.Windows.Forms.RadioButton rdbVar;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.ComboBox cmbYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ComboBox cmbMeslegi;
        private System.Windows.Forms.ComboBox cmbAldigiKitap;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsbMusteriler;
        private System.Windows.Forms.ListBox lsbKitapAdiYazarAdi;
        private System.Windows.Forms.Label label12;
    }
}

