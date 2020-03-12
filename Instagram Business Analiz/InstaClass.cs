using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Instagram_Business_Analiz
{
    public class InstaClass
    {

        // instagram için veri ayırıcılar
        public string JsonAyrac_1 = "window._sharedData =";
        public string JsonAyrac_2 = ";</script>";








        /// <summary>
        /// İki değer arasındaki veriyi ayırma fonksiyonu
        /// VeriAyiklama(HtmlKod, "<title>", "</title>");
        /// </summary>
        /// <param name="kaynakKod">Metnin tümü</param>
        /// <param name="ilkVeri">İlk veri değeri</param>
        /// <param name="sonVeri">Son veri değeri</param>
        /// <returns></returns>
        #region Veri Ayıklama Fonksiyon - VeriAyiklama(kaynakKod, ilkVeri, sonVeri)
        public string VeriAyiklama(string kaynakKod, string ilkVeri, string sonVeri)
        {
            string ayiklananVeri;
            try
            {
                string gelen = kaynakKod;
                int titleIndexBaslangici = gelen.IndexOf(ilkVeri) + ilkVeri.Length;
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf(sonVeri);
                ayiklananVeri = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);
                return ayiklananVeri;
            }
            catch
            {
                return "False";
            }
        }
        #endregion




        /// <summary>
        /// İlk seçilen zaman ve şimdiki zaman arasındaki farkı hesaplama fonksiyonu
        /// </summary>
        /// <param name="ilkZaman">Seçilen ilk zaman</param>
        /// <returns></returns>
        #region Zaman Farkı > zamanFarki(ilkZaman, sonZaman)
        public string ZamanFarki(string ilkZaman)
        {
            try
            {
                string sonZaman = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").ToString();

                TimeSpan ts = (Convert.ToDateTime(sonZaman) - Convert.ToDateTime(ilkZaman));

                string gun = ts.Days > 0 ? string.Format("{0} gün ", ts.Days) : "";
                string saat = ts.Hours > 0 ? string.Format("{0} saat ", ts.Hours) : "";
                string dakika = ts.Minutes > 0 ? string.Format("{0} dakika ", ts.Minutes) : "";
                string saniye = ts.Seconds > 0 ? string.Format("{0} Saniye ", ts.Seconds) : "";

                return gun + saat + dakika + saniye;
            }
            catch
            {
                return "false";
            }
        }
        #endregion

    }
}
