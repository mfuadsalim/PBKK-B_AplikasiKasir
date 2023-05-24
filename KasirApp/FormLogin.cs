using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KasirApp
{
    public partial class FormLogin : Form
    {
        public static string name;

        private OleDbCommand _command;
        private DataSet _dataSet;
        private OleDbDataAdapter _adapter;
        private OleDbDataReader _reader = null;

        Connection _connection = new Connection();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox1.Text = "admin";
            textBox2.Text = "admin";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = _connection.GetConn();
            {
                conn.Open();
                _command = new OleDbCommand("select * from [user] where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'", conn);
                _command.ExecuteNonQuery();
                _reader  = _command.ExecuteReader();

                if (_reader.Read())
                {
                    name = textBox1.Text;
                    FormMenuUtama formMenuUtama = new FormMenuUtama();
                    formMenuUtama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
