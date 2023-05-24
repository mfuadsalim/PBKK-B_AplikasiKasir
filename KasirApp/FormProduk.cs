using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KasirApp
{
    public partial class FormProduk : Form
    {
        private OleDbCommand _command;
        private DataSet _dataSet;
        private OleDbDataAdapter _adapter;
        private OleDbDataReader _reader = null;

        Connection _connection = new Connection();

        void InitialCondition()
        {
            TxtBoxNama.Text = "";
            TxtBoxKategori.SelectedItem = TxtBoxKategori.Items[0];
            TxtBoxHarga.Text = "";
            TxtBoxStok.Text = "";
        }
        void GridContentView()
        {
            OleDbConnection conn = _connection.GetConn();
            conn.Open();
            _command = new OleDbCommand("select * from [produk]", conn);
            _dataSet = new DataSet();
            _adapter = new OleDbDataAdapter(_command);
            _adapter.Fill(_dataSet, "produk");
            dataGridView1.DataSource = _dataSet;
            dataGridView1.DataMember = "produk";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public FormProduk()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            InitialCondition();
            GridContentView();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (TxtBoxNama.Text.Trim() == "" ||
                TxtBoxHarga.Text.Trim() == "" ||
                TxtBoxStok.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi");
            } else
            {
                OleDbConnection conn = _connection.GetConn();
                _command = new OleDbCommand("insert into [produk] (id, nama, kategori, harga, stok) values ('"
                    + TxtBoxId.Text + "', '"
                    + TxtBoxNama.Text + "', '"
                    + TxtBoxKategori.Text + "', '"
                    + TxtBoxHarga.Text + "', '"
                    + TxtBoxStok.Text + "')", conn);
                conn.Open();
                _command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di masukkan");
                GridContentView();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtBoxNama.Text.Trim() == "" ||
                TxtBoxHarga.Text.Trim() == "" ||
                TxtBoxStok.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan semua form terisi");
            }
            else
            {
                OleDbConnection conn = _connection.GetConn();
                _command = new OleDbCommand("update [produk] set nama='" + TxtBoxNama.Text + "', kategori='"
                    + TxtBoxKategori.Text + "', harga='"
                    + TxtBoxHarga.Text + "', stok='"
                    + TxtBoxStok.Text + "' where id='" + TxtBoxId.Text + "'", conn);
                conn.Open();
                _command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di edit");
                GridContentView();
            }
        }

        private void TxtBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                OleDbConnection conn = _connection.GetConn();
                _command = new OleDbCommand("select * from [produk] where id='" + TxtBoxId.Text + "'", conn);
                conn.Open();
                _command.ExecuteNonQuery();
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    TxtBoxNama.Text = _reader[1].ToString();
                    TxtBoxKategori.SelectedItem = _reader[2].ToString();
                    TxtBoxHarga.Text = _reader[3].ToString();
                    TxtBoxStok.Text = _reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("Tidak ada data ditemukan!");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtBoxId.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan ID produk yang akan dihapus");
            }
            else
            {
                OleDbConnection conn = _connection.GetConn();
                _command = new OleDbCommand("delete from [produk] where id='" + TxtBoxId.Text + "'", conn);
                conn.Open();
                _command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di hapus");
                GridContentView();
            }
        }
    }
}
