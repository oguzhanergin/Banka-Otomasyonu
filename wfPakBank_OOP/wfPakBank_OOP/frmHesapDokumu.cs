using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakBank_OOP
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }
        public static double bakiye;
        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 20;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text.Trim() != "")
            {
                cHesap h = new cHesap();
                //h.HesapBilgileriGoster(txtHesapNo, txtAdi, txtSoyadi, txtTCKNo, txtHesapTuru, txtTarih);
                h = h.HesapBilgileriGoster(txtHesapNo.Text);
                txtAdi.Text = h.Ad;
                txtSoyadi.Text = h.Soyad;
                txtTCKNo.Text = h.Tckno;
                txtHesapTuru.Text = h.HesapTuru;
                txtTarih.Text = h.Tarih;
                cHesapHareket har = new cHesapHareket();
                har.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);
                ToplamlariGoster();
            }
        }
        private void ToplamlariGoster()
        {
            double ToplamYatan = 0;
            double ToplamCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text == "yatan")
                    ToplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                else if (lvHareketler.Items[i].SubItems[4].Text == "cekilen")
                    ToplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
            }
            txtToplamYatan.Text = ToplamYatan.ToString();
            txtToplamCekilen.Text = ToplamCekilen.ToString();
            txtBakiye.Text = (ToplamYatan - ToplamCekilen).ToString();
        }
        private void btnPara_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToDouble(txtBakiye.Text);
            frmParaIslemleri frm = new frmParaIslemleri();
            frm.HesapBilgileri(lvHareketler.Items[0].SubItems[0].Text, lvHareketler.Items[0].SubItems[1].Text);
            frm.ShowDialog();
            //ParaIslemleri formu kapatıldıktan sonra program burdan çalışmaya devam eder.
            cHesapHareket har = new cHesapHareket();
            har.HesapHareketleriGoster(txtHesapNo.Text, lvHareketler);
            ToplamlariGoster();
        }
    }
}
