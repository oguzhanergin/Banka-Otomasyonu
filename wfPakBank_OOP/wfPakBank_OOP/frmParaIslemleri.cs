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
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }
        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            cbIslemTipleri.SelectedIndex = 1;
            txtTutar.Focus();
        }
        public void HesapBilgileri(string HesapID, string HesapNo)
        {
            lblHesapID.Text = HesapID;
            lblHesapNo.Text = HesapNo;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (cbIslemTipleri.SelectedItem.ToString() == "yatan" || frmHesapDokumu.bakiye >= Convert.ToDouble(txtTutar.Text))
            {
                cHesapHareket hh = new cHesapHareket();
                hh.HesapID = Convert.ToInt32(lblHesapID.Text);
                hh.HesapNo = lblHesapNo.Text;
                hh.Tarih = lblTarih.Text;
                hh.Tutar = Convert.ToDouble(txtTutar.Text);
                hh.IslemTipi = cbIslemTipleri.SelectedItem.ToString();
                bool Sonuc = hh.HesapHareketEkle(hh);
                if (Sonuc)
                {
                    MessageBox.Show("Para işlemleri gerçekleştirildi.");
                    this.Close();
                }
            }else
            {
                MessageBox.Show("Yetersiz Bakiye !!!" + "Max.Tutar = " + frmHesapDokumu.bakiye);
                txtTutar.Focus();
            }
        }
    }
}
