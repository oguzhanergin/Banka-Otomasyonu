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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void mitmCikis_Click(object sender, EventArgs e)
        {
            //this.Close(); //Aktif formu kapatır.
            Application.Exit(); //Açık tüm formları kapatarak uygulamanın çalışmasını sonlandırır.
        }
        private void mitmYeniHesapAc_Click(object sender, EventArgs e)
        {
            frmHesapAcilisi frm = new frmHesapAcilisi();
            //frm.Show(); //İstenildiği kadar form arka arkaya açılabilir.
            frm.ShowDialog(); //Aktif form kapatılmadan başka bir form ile çalışılamaz.
        }

        private void mitmHesapDokumu_Click(object sender, EventArgs e)
        {
            frmHesapDokumu frm = new frmHesapDokumu();
            frm.ShowDialog();
        }
    }
}
