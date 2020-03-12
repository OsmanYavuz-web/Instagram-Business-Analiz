using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace Instagram_Business_Analiz
{
    public partial class Form1 : Form
    {


        /// <summary>
        /// Referanslar ve Değişkenler
        /// </summary>
        InstaClass Insta = new InstaClass();
        Thread t_InstaAnaliz;
        string TarananListe = null;



        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Form Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch { }
        }


        /// <summary>
        /// Form Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.WindowState != FormWindowState.Minimized)
                {

                    if (e.CloseReason == CloseReason.ApplicationExitCall)
                    {
                        return;
                    }
                    if (MessageBox.Show(this.Text + " kapatılsın mı?",
                               this.Text,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        // kapat
                        Environment.Exit(0);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch { }
        }


        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread Aktifleştirme
            CheckForIllegalCrossThreadCalls = false;
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void Button_TestButonu_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Hedef hesabın json kodlarını çekme
        /// </summary>
        /// <param name="kadi">Instagram kullanıcı adı</param>
        /// <returns></returns>
        public string ProfilJsonVeri(string kadi)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string HTML_Kod = webClient.DownloadString("https://www.instagram.com/" + kadi);
                string JSON_Kod = Insta.VeriAyiklama(HTML_Kod, Insta.JsonAyrac_1, Insta.JsonAyrac_2);

                webClient.Dispose();

                return JSON_Kod;
            }
            catch
            {
                return null;
            }
        }



        /// <summary>
        /// Analiz edilecek hesapları aktarma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_HesaplariAktar_Click(object sender, EventArgs e)
        {
            try
            {
                // Profil aktar ayarları
                OpenFileDialog yukle = new OpenFileDialog();
                yukle.Title = "Hesapları Aktar";
                yukle.Filter = "Txt dosyası|*.txt";

                // Dosya yükleme için onay
                if (yukle.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dosya içeriğini oku ve aktar
                        StreamReader aktar = new StreamReader(yukle.FileName);
                        TarananListe = Path.GetFileName(yukle.FileName);
                        label_taranan.Text = TarananListe + " aktarıldı.";
                        string hesap;
                        while ((hesap = aktar.ReadLine()) != null)
                        {
                            // Profillerin Takipçi Sayılarını Bulma
                            if (hesap != null)
                            {
                                if (listBox_Hesaplar.Items.Contains(hesap) == false)
                                {
                                    listBox_Hesaplar.Items.Add(hesap);
                                }
                            }
                        }
                        aktar.Close();
                        aktar.Dispose();

                        if(listBox_Hesaplar.Items.Contains("SON") == false)
                        {
                            listBox_Hesaplar.Items.Add("SON");
                        }

                        // Dosya içindeki toplam hesap
                        string topProfil = (listBox_Hesaplar.Items.Count-1).ToString();
                        label_Hesaplar_Toplam.Text = "Toplam Hesap: " + topProfil;

                        panel_Sag.Enabled = true;

                        MessageBox.Show("Liste başarıyla aktarıldı. Toplam Hesap: " + topProfil, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        //bilgi mesajı
                        MessageBox.Show("Liste aktarılırken sorun oluştu.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // log kaydet
                MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Listeyi Excel Aktarma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ListeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
                xla.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
                int i = 1;
                int j = 1;
                foreach (ListViewItem item in listView_AyiklananHesaplar.Items)
                {
                    ws.Cells[i, j] = item.Text.ToString();
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        ws.Cells[i, j] = subitem.Text.ToString();
                        j++;
                    }
                    j = 1;
                    i++;
                }
            }
            catch (Exception ex)
            {
                // log kaydet
                MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Hesaplar listesini temizleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_HesapListesi_Temizle_Click(object sender, EventArgs e)
        {
            try
            {
                // sor bakalım istiyor mu :)
                DialogResult soru = MessageBox.Show("Liste silinsin mi?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    // temizle
                    label_Hesaplar_Toplam.Text = "Toplam Hesap: 0";
                    listBox_Hesaplar.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                // log kaydet
                MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Analiz edilen hesaplar listesini temizleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ListeTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                // sor bakalım istiyor mu :)
                DialogResult soru = MessageBox.Show("Liste silinsin mi?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    // temizle
                    listView_AyiklananHesaplar.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                // log kaydet
                MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Başlat butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Baslat_Click(object sender, EventArgs e)
        {

            // Hesap var mı listede?
            if(listBox_Hesaplar.Items.Count > 0)
            {
                // var
                t_InstaAnaliz = new Thread(delegate ()
                {
                    try
                    {
                        // Nesne işlemleri
                        button_Baslat.Enabled = false;
                        listBox_Hesaplar.Enabled = false;
                        button_HesaplariAktar.Enabled = false;
                        button_HesapListesi_Temizle.Enabled = false;
                        button_Durdur.Enabled = true;
                        label_ToplamHesap.Text = "Toplam Hesap: 0";
                        //listBox_Hesaplar.SelectedIndex = 0;

                        label_taranan.Text = TarananListe + " taranıyor.";

                        AnalizRobotu();
                    }
                    catch (Exception ex)
                    {
                        // Nesne işlemleri
                        button_Baslat.Enabled = true;
                        listBox_Hesaplar.Enabled = true;
                        button_HesaplariAktar.Enabled = true;
                        button_HesapListesi_Temizle.Enabled = true;
                        button_Durdur.Enabled = false;

                        // thread sonlandırma
                        if (t_InstaAnaliz.IsAlive)
                        {
                            t_InstaAnaliz.Abort();
                        }

                        // hata
                        MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        // Nesne işlemleri
                        button_Baslat.Enabled = true;
                        listBox_Hesaplar.Enabled = true;
                        button_HesaplariAktar.Enabled = true;
                        button_HesapListesi_Temizle.Enabled = true;
                        button_Durdur.Enabled = false;
                        label_taranan.Text = TarananListe + " tarama tamamlandı.";

                        // tamamen biterse
                        MessageBox.Show("Analiz işlemi tamamlandı.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // thread sonlandırma
                        if (t_InstaAnaliz.IsAlive)
                        {
                            t_InstaAnaliz.Abort();
                        }
                    }

                });
                t_InstaAnaliz.Start();

            }
            else
            {
                // yok
                MessageBox.Show("Başlatmadan önce hesap aktarın.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Durdur butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Durdur_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("İşlem durdurulsun mu?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                try
                {
                    // Nesne işlemleri
                    button_Baslat.Enabled = true;
                    listBox_Hesaplar.Enabled = true;
                    button_HesaplariAktar.Enabled = true;
                    button_HesapListesi_Temizle.Enabled = true;
                    button_Durdur.Enabled = false;
                    label_taranan.Text = TarananListe + " tarama tamamlandı.";

                    // thread sonlandırma
                    if (t_InstaAnaliz.IsAlive)
                    {
                        t_InstaAnaliz.Abort();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        /// <summary>
        /// Anlaiz Robotu
        /// </summary>
        void AnalizRobotu()
        {
            // Liste işlemleri
            int Toplam_HesapListesi = listBox_Hesaplar.Items.Count;
            int Index_SeciliHesap = listBox_Hesaplar.SelectedIndex + 1;

            // Seçili hesap
            string kadi = listBox_Hesaplar.Text;

            if (Toplam_HesapListesi != Index_SeciliHesap)
            {
                try
                {
                    // Json verisini objeye çevir
                    WebClient webClient = new WebClient();
                    webClient.Encoding = Encoding.UTF8;
                    string HTML_Kod = webClient.DownloadString("https://www.instagram.com/" + kadi);
                    string JSON_Kod = Insta.VeriAyiklama(HTML_Kod, Insta.JsonAyrac_1, Insta.JsonAyrac_2);

                    webClient.Dispose();

                    JObject JSONParser = JObject.Parse(JSON_Kod);

                    // verileri
                    string biography = (string)JSONParser["entry_data"]["ProfilePage"][0]["graphql"]["user"]["biography"];
                    string external_url = (string)JSONParser["entry_data"]["ProfilePage"][0]["graphql"]["user"]["external_url"];
                    string isBusiness = (string)JSONParser["entry_data"]["ProfilePage"][0]["graphql"]["user"]["is_business_account"];
                    string followed_by = (string)JSONParser["entry_data"]["ProfilePage"][0]["graphql"]["user"]["edge_followed_by"]["count"];
                    string follow = (string)JSONParser["entry_data"]["ProfilePage"][0]["graphql"]["user"]["edge_follow"]["count"];
                    string telefon = "";
                    string eposta = "";


                    // düzeltmeler
                    if (biography == null)
                        biography = "";
                    if (external_url == null)
                        external_url = "";
                    if (external_url == null)
                        external_url = "";


                    external_url = external_url.Replace("=90", "0");
                    biography = biography.Replace("=90", "0");


                    #region Telefon
                    // Telefon şablonu
                    const string TelefonSablon = @"(([\+]90?)|([0]?))([ ]?)((\([0-9]{3}\))|([0-9]{3}))([ ]?)([0-9]{3})(\s*[\-]?)([0-9]{2})(\s*[\-]?)([0-9]{2})";
                    Regex rx_telefon = new Regex(TelefonSablon, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    // bio içinde telefon
                    MatchCollection matches_bio_telefon = rx_telefon.Matches(biography);
                    foreach (Match match_bio_telefon in matches_bio_telefon)
                    {
                        telefon += match_bio_telefon.Value.ToString() + ",";
                    }

                    // Link içinde telefon
                    MatchCollection matches_url_telefon = rx_telefon.Matches(external_url);
                    foreach (Match match_url_telefon in matches_url_telefon)
                    {
                        telefon += match_url_telefon.Value.ToString() + ",";
                    }
                    #endregion

                    #region Eposta
                    // Eposta
                    const string EpostaSablon = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
                    Regex rx_eposta = new Regex(EpostaSablon, RegexOptions.Compiled | RegexOptions.IgnoreCase);


                    // bio içinde Eposta
                    MatchCollection matches_bio_eposta = rx_eposta.Matches(biography);
                    foreach (Match match_bio_eposta in matches_bio_eposta)
                    {
                        eposta += match_bio_eposta.Value.ToString() + ",";
                    }

                    // Link içinde Eposta
                    MatchCollection matches_url_eposta = rx_eposta.Matches(external_url);
                    foreach (Match match_url_eposta in matches_url_eposta)
                    {
                        eposta += match_url_eposta.Value.ToString() + ",";
                    }
                    #endregion


                    // Düzeltmeler
                    if (telefon.Length > 5)
                    {
                        telefon = telefon.Substring(0, telefon.Length - 1);
                    }
                    if (eposta.Length > 5)
                    {
                        eposta = eposta.Substring(0, eposta.Length - 1);
                    }



                    // iş hesabıysa ekle
                    if (isBusiness == "True" || telefon.Length > 5 || eposta.Length > 5)
                    {
                        // evet
                        string[] veri = { kadi, telefon, eposta, followed_by, follow };
                        var satir = new ListViewItem(veri);
                        listView_AyiklananHesaplar.Items.Add(satir);
                    }


                }
                catch { }



                // Tekrar çalıştır
                label_ToplamHesap.Text = "Toplam Hesap: " + listView_AyiklananHesaplar.Items.Count.ToString();
                listBox_Hesaplar.SelectedIndex = Index_SeciliHesap;
                AnalizRobotu();
            }

        }


        /// <summary>
        /// TXT Kaydet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_TXTKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kontrolü göster
                SaveFileDialog kaydet = new SaveFileDialog();
                kaydet.Title = "Listeyi Kaydet";
                kaydet.Filter = "Txt dosyası|*.txt";

                if (kaydet.ShowDialog() == DialogResult.OK)
                {
                    string yol = kaydet.FileName;
                    //Yeni bir dosya oluştur
                    try
                    {
                        //Dosyayı appendText ile yazmak için açtık
                        StreamWriter dosyaAc = File.AppendText(yol);


                        foreach (ListViewItem item in listView_AyiklananHesaplar.Items)
                        {
                            if (item.Text != "KullanıcıAdı")
                                dosyaAc.WriteLine(item.Text);
                        }


                        // Dosya yı kapattık.
                        dosyaAc.Close();
                        dosyaAc.Dispose();

                        // Bilgi Mesajı
                        MessageBox.Show("Liste başarıyla kaydedildi. Kayıt Yolu: " + yol, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {

                        //bilgi mesajı
                        MessageBox.Show("Liste kaydedilirken sorun oluştu.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kritik Hata!\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



    }
}
