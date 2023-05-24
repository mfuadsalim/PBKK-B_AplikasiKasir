using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KasirApp
{
    public partial class FormMenuUtama : Form
    {
        FormTransaksi formTransaksi;
        void formTransaksi_Closed(object sender, FormClosedEventArgs e)
        {
            formTransaksi = null;
        }
        FormProduk formProduk;
        void formProduk_Closed(object sender, FormClosedEventArgs e)
        {
            formProduk = null;
        }
        FormAbout formAbout;
        void formAbout_Closed(object sender, FormClosedEventArgs e)
        {
            formAbout = null;
        }

        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            label2.Text = FormLogin.name;
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTransaksi == null)
            {
                formTransaksi = new FormTransaksi();
                formTransaksi.FormClosed += new FormClosedEventHandler(formTransaksi_Closed);
                formTransaksi.ShowDialog();
            } else
            {
                formTransaksi.Activate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formProduk == null)
            {
                formProduk = new FormProduk();
                formProduk.FormClosed += new FormClosedEventHandler(formProduk_Closed);
                formProduk.ShowDialog();
            } else
            {
                formProduk.Activate();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAbout == null)
            {
                formAbout = new FormAbout();
                formAbout.FormClosed += new FormClosedEventHandler(formAbout_Closed);
                formAbout.ShowDialog();
            }
            else
            {
                formAbout.Activate();
            }
        }
    }
}
