namespace wfPakBank_OOP
{
    partial class frmAnaSayfa
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
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmYeniHesapAc = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmHesapDokumu = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuAnaSayfa.Size = new System.Drawing.Size(574, 25);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmYeniHesapAc,
            this.mitmHesapDokumu,
            this.mitmCikis});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 19);
            this.hesapİşlemleriToolStripMenuItem.Text = "&Hesap İşlemleri";
            // 
            // mitmYeniHesapAc
            // 
            this.mitmYeniHesapAc.Name = "mitmYeniHesapAc";
            this.mitmYeniHesapAc.Size = new System.Drawing.Size(190, 22);
            this.mitmYeniHesapAc.Text = "&Yeni Hesap Aç";
            this.mitmYeniHesapAc.Click += new System.EventHandler(this.mitmYeniHesapAc_Click);
            // 
            // mitmHesapDokumu
            // 
            this.mitmHesapDokumu.Name = "mitmHesapDokumu";
            this.mitmHesapDokumu.Size = new System.Drawing.Size(190, 22);
            this.mitmHesapDokumu.Text = "Hesap &Dökümü İncele";
            this.mitmHesapDokumu.Click += new System.EventHandler(this.mitmHesapDokumu_Click);
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(190, 22);
            this.mitmCikis.Text = "Programdan &Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 440);
            this.Controls.Add(this.mnuAnaSayfa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnaSayfa";
            this.Text = "PAKBANK AnaSayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmYeniHesapAc;
        private System.Windows.Forms.ToolStripMenuItem mitmHesapDokumu;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}