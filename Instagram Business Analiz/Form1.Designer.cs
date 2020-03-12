namespace Instagram_Business_Analiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_HesaplariAktar = new System.Windows.Forms.Button();
            this.listBox_Hesaplar = new System.Windows.Forms.ListBox();
            this.label_Hesaplar_Toplam = new System.Windows.Forms.Label();
            this.button_TestButonu = new System.Windows.Forms.Button();
            this.richTextBox_TestKutusu = new System.Windows.Forms.RichTextBox();
            this.listView_AyiklananHesaplar = new System.Windows.Forms.ListView();
            this.col_Kadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Eposta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Takipci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TakipEdilen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_ListeTemizle = new System.Windows.Forms.Button();
            this.button_ListeKaydet = new System.Windows.Forms.Button();
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button_Durdur = new System.Windows.Forms.Button();
            this.panel_Sag = new System.Windows.Forms.Panel();
            this.label_ToplamHesap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_taranan = new System.Windows.Forms.Label();
            this.button_HesapListesi_Temizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_TXTKaydet = new System.Windows.Forms.Button();
            this.panel_Sag.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_HesaplariAktar
            // 
            this.button_HesaplariAktar.AutoSize = true;
            this.button_HesaplariAktar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_HesaplariAktar.Location = new System.Drawing.Point(12, 12);
            this.button_HesaplariAktar.Name = "button_HesaplariAktar";
            this.button_HesaplariAktar.Size = new System.Drawing.Size(200, 30);
            this.button_HesaplariAktar.TabIndex = 0;
            this.button_HesaplariAktar.Text = "Hesapları Aktar";
            this.button_HesaplariAktar.UseVisualStyleBackColor = true;
            this.button_HesaplariAktar.Click += new System.EventHandler(this.Button_HesaplariAktar_Click);
            // 
            // listBox_Hesaplar
            // 
            this.listBox_Hesaplar.FormattingEnabled = true;
            this.listBox_Hesaplar.ItemHeight = 14;
            this.listBox_Hesaplar.Location = new System.Drawing.Point(12, 48);
            this.listBox_Hesaplar.Name = "listBox_Hesaplar";
            this.listBox_Hesaplar.Size = new System.Drawing.Size(200, 382);
            this.listBox_Hesaplar.TabIndex = 1;
            // 
            // label_Hesaplar_Toplam
            // 
            this.label_Hesaplar_Toplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Hesaplar_Toplam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Hesaplar_Toplam.Location = new System.Drawing.Point(12, 433);
            this.label_Hesaplar_Toplam.Name = "label_Hesaplar_Toplam";
            this.label_Hesaplar_Toplam.Size = new System.Drawing.Size(200, 30);
            this.label_Hesaplar_Toplam.TabIndex = 2;
            this.label_Hesaplar_Toplam.Text = "Toplam Hesap:";
            this.label_Hesaplar_Toplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_TestButonu
            // 
            this.button_TestButonu.Location = new System.Drawing.Point(843, 14);
            this.button_TestButonu.Name = "button_TestButonu";
            this.button_TestButonu.Size = new System.Drawing.Size(125, 23);
            this.button_TestButonu.TabIndex = 3;
            this.button_TestButonu.Text = "Test Butonu";
            this.button_TestButonu.UseVisualStyleBackColor = true;
            this.button_TestButonu.Click += new System.EventHandler(this.Button_TestButonu_Click);
            // 
            // richTextBox_TestKutusu
            // 
            this.richTextBox_TestKutusu.Location = new System.Drawing.Point(843, 43);
            this.richTextBox_TestKutusu.Name = "richTextBox_TestKutusu";
            this.richTextBox_TestKutusu.Size = new System.Drawing.Size(213, 114);
            this.richTextBox_TestKutusu.TabIndex = 4;
            this.richTextBox_TestKutusu.Text = "";
            // 
            // listView_AyiklananHesaplar
            // 
            this.listView_AyiklananHesaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Kadi,
            this.col_Telefon,
            this.col_Eposta,
            this.col_Takipci,
            this.col_TakipEdilen});
            this.listView_AyiklananHesaplar.FullRowSelect = true;
            this.listView_AyiklananHesaplar.HideSelection = false;
            this.listView_AyiklananHesaplar.Location = new System.Drawing.Point(3, 39);
            this.listView_AyiklananHesaplar.Name = "listView_AyiklananHesaplar";
            this.listView_AyiklananHesaplar.Size = new System.Drawing.Size(605, 414);
            this.listView_AyiklananHesaplar.TabIndex = 5;
            this.listView_AyiklananHesaplar.UseCompatibleStateImageBehavior = false;
            this.listView_AyiklananHesaplar.View = System.Windows.Forms.View.Details;
            // 
            // col_Kadi
            // 
            this.col_Kadi.Text = "Kullanıcı Adı";
            this.col_Kadi.Width = 150;
            // 
            // col_Telefon
            // 
            this.col_Telefon.Text = "Telefon";
            this.col_Telefon.Width = 130;
            // 
            // col_Eposta
            // 
            this.col_Eposta.Text = "Eposta";
            this.col_Eposta.Width = 180;
            // 
            // col_Takipci
            // 
            this.col_Takipci.Text = "Takipçi";
            // 
            // col_TakipEdilen
            // 
            this.col_TakipEdilen.Text = "Takip";
            // 
            // button_ListeTemizle
            // 
            this.button_ListeTemizle.AutoSize = true;
            this.button_ListeTemizle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ListeTemizle.Location = new System.Drawing.Point(3, 456);
            this.button_ListeTemizle.Name = "button_ListeTemizle";
            this.button_ListeTemizle.Size = new System.Drawing.Size(145, 30);
            this.button_ListeTemizle.TabIndex = 6;
            this.button_ListeTemizle.Text = "Listeyi Temizle";
            this.button_ListeTemizle.UseVisualStyleBackColor = true;
            this.button_ListeTemizle.Click += new System.EventHandler(this.Button_ListeTemizle_Click);
            // 
            // button_ListeKaydet
            // 
            this.button_ListeKaydet.AutoSize = true;
            this.button_ListeKaydet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ListeKaydet.Location = new System.Drawing.Point(305, 456);
            this.button_ListeKaydet.Name = "button_ListeKaydet";
            this.button_ListeKaydet.Size = new System.Drawing.Size(145, 30);
            this.button_ListeKaydet.TabIndex = 7;
            this.button_ListeKaydet.Text = "EXCEL Kaydet";
            this.button_ListeKaydet.UseVisualStyleBackColor = true;
            this.button_ListeKaydet.Click += new System.EventHandler(this.Button_ListeKaydet_Click);
            // 
            // button_Baslat
            // 
            this.button_Baslat.AutoSize = true;
            this.button_Baslat.BackColor = System.Drawing.Color.DarkGreen;
            this.button_Baslat.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_Baslat.FlatAppearance.BorderSize = 2;
            this.button_Baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Baslat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Baslat.ForeColor = System.Drawing.Color.White;
            this.button_Baslat.Location = new System.Drawing.Point(3, 3);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(145, 30);
            this.button_Baslat.TabIndex = 8;
            this.button_Baslat.Text = "Başlat";
            this.button_Baslat.UseVisualStyleBackColor = false;
            this.button_Baslat.Click += new System.EventHandler(this.Button_Baslat_Click);
            // 
            // button_Durdur
            // 
            this.button_Durdur.AutoSize = true;
            this.button_Durdur.BackColor = System.Drawing.Color.DarkRed;
            this.button_Durdur.Enabled = false;
            this.button_Durdur.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button_Durdur.FlatAppearance.BorderSize = 2;
            this.button_Durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Durdur.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Durdur.ForeColor = System.Drawing.Color.White;
            this.button_Durdur.Location = new System.Drawing.Point(154, 3);
            this.button_Durdur.Name = "button_Durdur";
            this.button_Durdur.Size = new System.Drawing.Size(145, 30);
            this.button_Durdur.TabIndex = 10;
            this.button_Durdur.Text = "Durdur";
            this.button_Durdur.UseVisualStyleBackColor = false;
            this.button_Durdur.Click += new System.EventHandler(this.Button_Durdur_Click);
            // 
            // panel_Sag
            // 
            this.panel_Sag.Controls.Add(this.button_TXTKaydet);
            this.panel_Sag.Controls.Add(this.label_ToplamHesap);
            this.panel_Sag.Controls.Add(this.label1);
            this.panel_Sag.Controls.Add(this.label_taranan);
            this.panel_Sag.Controls.Add(this.button_Baslat);
            this.panel_Sag.Controls.Add(this.button_Durdur);
            this.panel_Sag.Controls.Add(this.listView_AyiklananHesaplar);
            this.panel_Sag.Controls.Add(this.button_ListeTemizle);
            this.panel_Sag.Controls.Add(this.button_ListeKaydet);
            this.panel_Sag.Enabled = false;
            this.panel_Sag.Location = new System.Drawing.Point(218, 10);
            this.panel_Sag.Name = "panel_Sag";
            this.panel_Sag.Size = new System.Drawing.Size(619, 497);
            this.panel_Sag.TabIndex = 11;
            // 
            // label_ToplamHesap
            // 
            this.label_ToplamHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ToplamHesap.Location = new System.Drawing.Point(456, 456);
            this.label_ToplamHesap.Name = "label_ToplamHesap";
            this.label_ToplamHesap.Size = new System.Drawing.Size(152, 30);
            this.label_ToplamHesap.TabIndex = 13;
            this.label_ToplamHesap.Text = "Toplam Hesap: 0";
            this.label_ToplamHesap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(305, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Durum: ";
            // 
            // label_taranan
            // 
            this.label_taranan.AutoSize = true;
            this.label_taranan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_taranan.Location = new System.Drawing.Point(361, 10);
            this.label_taranan.Name = "label_taranan";
            this.label_taranan.Size = new System.Drawing.Size(66, 16);
            this.label_taranan.TabIndex = 11;
            this.label_taranan.Text = "Bekleniyor";
            // 
            // button_HesapListesi_Temizle
            // 
            this.button_HesapListesi_Temizle.AutoSize = true;
            this.button_HesapListesi_Temizle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_HesapListesi_Temizle.Location = new System.Drawing.Point(12, 466);
            this.button_HesapListesi_Temizle.Name = "button_HesapListesi_Temizle";
            this.button_HesapListesi_Temizle.Size = new System.Drawing.Size(200, 30);
            this.button_HesapListesi_Temizle.TabIndex = 12;
            this.button_HesapListesi_Temizle.Text = "Listeyi Temizle";
            this.button_HesapListesi_Temizle.UseVisualStyleBackColor = true;
            this.button_HesapListesi_Temizle.Click += new System.EventHandler(this.Button_HesapListesi_Temizle_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(839, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Powered By seowebgrafik.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TXTKaydet
            // 
            this.button_TXTKaydet.AutoSize = true;
            this.button_TXTKaydet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_TXTKaydet.Location = new System.Drawing.Point(154, 456);
            this.button_TXTKaydet.Name = "button_TXTKaydet";
            this.button_TXTKaydet.Size = new System.Drawing.Size(145, 30);
            this.button_TXTKaydet.TabIndex = 14;
            this.button_TXTKaydet.Text = "TXT Kaydet";
            this.button_TXTKaydet.UseVisualStyleBackColor = true;
            this.button_TXTKaydet.Click += new System.EventHandler(this.Button_TXTKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(839, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_HesapListesi_Temizle);
            this.Controls.Add(this.panel_Sag);
            this.Controls.Add(this.richTextBox_TestKutusu);
            this.Controls.Add(this.button_TestButonu);
            this.Controls.Add(this.label_Hesaplar_Toplam);
            this.Controls.Add(this.listBox_Hesaplar);
            this.Controls.Add(this.button_HesaplariAktar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Instagram Business Analiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Sag.ResumeLayout(false);
            this.panel_Sag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_HesaplariAktar;
        private System.Windows.Forms.ListBox listBox_Hesaplar;
        private System.Windows.Forms.Label label_Hesaplar_Toplam;
        private System.Windows.Forms.Button button_TestButonu;
        private System.Windows.Forms.RichTextBox richTextBox_TestKutusu;
        private System.Windows.Forms.ListView listView_AyiklananHesaplar;
        private System.Windows.Forms.ColumnHeader col_Kadi;
        private System.Windows.Forms.ColumnHeader col_Telefon;
        private System.Windows.Forms.ColumnHeader col_Eposta;
        private System.Windows.Forms.ColumnHeader col_Takipci;
        private System.Windows.Forms.ColumnHeader col_TakipEdilen;
        private System.Windows.Forms.Button button_ListeTemizle;
        private System.Windows.Forms.Button button_ListeKaydet;
        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button_Durdur;
        private System.Windows.Forms.Panel panel_Sag;
        private System.Windows.Forms.Button button_HesapListesi_Temizle;
        private System.Windows.Forms.Label label_taranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ToplamHesap;
        private System.Windows.Forms.Button button_TXTKaydet;
    }
}

