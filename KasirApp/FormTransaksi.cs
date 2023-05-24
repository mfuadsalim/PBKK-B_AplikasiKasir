using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class FormTransaksi : Form
    {
        private OleDbCommand _command;
        private DataSet _dataSet;
        private OleDbDataAdapter _adapter;
        private OleDbDataReader _reader = null;

        Connection _connection = new Connection();

        int order = 1;
        double total = 0;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = _connection.GetConn();
            _command = new OleDbCommand("select nama from [produk]", conn);
            conn.Open();
            _reader = _command.ExecuteReader();

            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();

            if (_reader.HasRows == true)
            {
                while (_reader.Read())
                {
                    stringCollection.Add(_reader["nama"].ToString());
                }
            }
            _reader.Close();

            TxtBoxNama.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtBoxNama.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtBoxNama.AutoCompleteCustomSource = stringCollection;

            receiptBindingSource.DataSource = new List<Receipt>();
        }

        private void TxtBoxNama_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = _connection.GetConn();
            _command = new OleDbCommand("select harga from [produk] where nama='" + TxtBoxNama.Text + "'", conn);
            conn.Open();
            _reader = _command.ExecuteReader();
            if (_reader.HasRows == true)
            {
                _reader.Read();
                TxtBoxHarga.Text = _reader[0].ToString();
            }
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBoxCash.Text))
            {
                FormReceipt formReceipt = new FormReceipt(receiptBindingSource.DataSource as List<Receipt>,
                    string.Format("Rp{0}", total),
                    string.Format("Rp{0}", TxtBoxCash.Text),
                    string.Format("Rp{0}", Convert.ToDouble(TxtBoxCash.Text)-total),
                    DateTime.Now.ToString("MM/dd/yyyy"));
                formReceipt.ShowDialog();
            } else
            {
                MessageBox.Show("Lakukan pembayaran terlebih dahulu");
            }
            
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtBoxNama.Text) && !string.IsNullOrEmpty(TxtBoxJumlah.Text))
            {
                Receipt receiptObj = new Receipt()
                {
                    id = order++,
                    name = TxtBoxNama.Text,
                    harga = Convert.ToDouble(TxtBoxHarga.Text),
                    jumlah = Convert.ToInt32(TxtBoxJumlah.Text)
                };
                total += receiptObj.harga * receiptObj.jumlah;
                receiptBindingSource.Add(receiptObj);
                receiptBindingSource.MoveLast();
                TxtBoxNama.Text = string.Empty;
                TxtBoxJumlah.Text = string.Empty;
                TxtBoxTotal.Text = string.Format("Rp{0}", total);

            } else
            {
                MessageBox.Show("Pastikan semua form di isi");
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            Receipt receiptObj = receiptBindingSource.Current as Receipt;
            if (receiptObj != null)
            {
                total -= receiptObj.harga * receiptObj.jumlah;
                TxtBoxTotal.Text = string.Format("Rp{0}", total);
                order--;
                receiptBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("Keranjang belanja kosong!");
            }
        }
    }
}
