using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
{
    class cHesapHareket
    {
        private int _hesapID;
        private string _hesapNo;
        private string _tarih;
        private double _tutar;
        private string _islemTipi;

        #region Properties
        public int HesapID
        {
            get
            {
                return _hesapID;
            }

            set
            {
                _hesapID = value;
            }
        }

        public string HesapNo
        {
            get
            {
                return _hesapNo;
            }

            set
            {
                _hesapNo = value;
            }
        }

        public string Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public double Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }

        public string IslemTipi
        {
            get
            {
                return _islemTipi;
            }

            set
            {
                _islemTipi = value;
            }
        } 
        #endregion

        public bool HesapHareketEkle(int ID, string HesapNo, string Tarih, double Tutar, string IslemTipi)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(ID + ";" + HesapNo + ";" + Tarih + ";" + Tutar + ";" + IslemTipi);
            HareketYaz.Close();
            return true;
        }
        public bool HesapHareketEkle(cHesapHareket hh)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(hh._hesapID + ";" + hh._hesapNo + ";" + hh._tarih + ";" + hh._tutar + ";" + hh._islemTipi);
            HareketYaz.Close();
            return true;
        }
        public void HesapHareketleriGoster(string HesapNo, ListView liste)
        {
            liste.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunansatir = DosyaOku.ReadLine();
            int i = 0;
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (HesapNo == Degerler[1])
                {
                    liste.Items.Add(Degerler[0]);
                    liste.Items[i].SubItems.Add(Degerler[1]);
                    liste.Items[i].SubItems.Add(Degerler[2]);
                    liste.Items[i].SubItems.Add(Degerler[3]);
                    liste.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
    }
}
