using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
{
    class cHesap
    {
        private int _hesapID;
        private string _hesapNo;
        private string _tarih;
        private string _ad;
        private string _soyad;
        private string _tckno;
        private double _bakiye;
        private string _hesapTuru;

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

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Tckno
        {
            get
            {
                return _tckno;
            }

            set
            {
                _tckno = value;
            }
        }

        public double Bakiye
        {
            get
            {
                return _bakiye;
            }

            set
            {
                _bakiye = value;
            }
        }

        public string HesapTuru
        {
            get
            {
                return _hesapTuru;
            }

            set
            {
                _hesapTuru = value;
            }
        }
        #endregion

        Random rnd = new Random();
        private string YeniHesapNo;
        public int SonIDBul()
        {
            StreamWriter DosyaOlustur = new StreamWriter("HesapKartlari.txt", true);
            DosyaOlustur.Close();

            int ID = 0;
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            if (okunansatir == null)
                ID = 1;
            else
            {
                while (okunansatir != null)
                {
                    string[] Degerler = okunansatir.Split(';'); //Her bir müşteri kaydındaki bilgileri ; sembolüne göre parçalara ayırır, herbir parçayı string bir diziye atar.
                    ID = Convert.ToInt32(Degerler[0]) + 1;
                    okunansatir = DosyaOku.ReadLine();
                }
            }
            DosyaOku.Close();
            return ID;
        }
        public string HesapNumarasiOlustur()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapVarmi();
            } while (Varmi);
            return YeniHesapNo;
        }
        public bool HesapVarmi()
        {
            YeniHesapNo = "ACC" + rnd.Next(1000, 10000);
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (YeniHesapNo == Degerler[1])
                {
                    DosyaOku.Close();
                    ///*HesapNumarasiOlustur(); /*//recursive methods (kendini çağıran metotlar)
                    return true;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
        public bool YeniHesapAc(int ID, string HesapNo, string Tarih, string Adi, string Soyadi, string TCKNo, double Bakiye, string HesapTuru)
        {
            StreamWriter HesapAc = new StreamWriter("HesapKartlari.txt", true);
            HesapAc.WriteLine(ID + ";" + HesapNo + ";" + Tarih + ";" + Adi + ";" + Soyadi + ";" + TCKNo + ";" + Bakiye + ";" + HesapTuru);
            HesapAc.Close();

            return true;
        }
        public bool YeniHesapAc(cHesap h)
        {
            StreamWriter HesapAc = new StreamWriter("HesapKartlari.txt", true);
            HesapAc.WriteLine(h._hesapID + ";" + h._hesapNo + ";" + h._tarih + ";" + h._ad + ";" + h._soyad + ";" + h._tckno + ";" + h._bakiye + ";" + h._hesapTuru);
            HesapAc.Close();

            return true;
        }
        public void HesapBilgileriGoster(TextBox HesapNo, TextBox Adi, TextBox Soyadi, TextBox TCKNo, TextBox HesapTuru, TextBox Tarih)
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (HesapNo.Text == Degerler[1])
                {
                    Adi.Text = Degerler[3];
                    Soyadi.Text = Degerler[4];
                    TCKNo.Text = Degerler[5];
                    HesapTuru.Text = Degerler[7];
                    Tarih.Text = Degerler[2];
                    break;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }

        public cHesap HesapBilgileriGoster(string HesapNo)
        {
            cHesap h = new cHesap();
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (HesapNo == Degerler[1])
                {
                    h._ad = Degerler[3];
                    h._soyad = Degerler[4];
                    h._tckno = Degerler[5];
                    h._hesapTuru = Degerler[7];
                    h._tarih = Degerler[2];
                    break;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return h;
        }
    }
}
