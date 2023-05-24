namespace KasirApp
{
    partial class FormTransaksi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBoxNama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxJumlah = new System.Windows.Forms.TextBox();
            this.BtnCetak = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaksi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receiptBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 332);
            this.dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            this.jumlahDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 130;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(KasirApp.Receipt);
            // 
            // TxtBoxNama
            // 
            this.TxtBoxNama.Location = new System.Drawing.Point(149, 439);
            this.TxtBoxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNama.Name = "TxtBoxNama";
            this.TxtBoxNama.Size = new System.Drawing.Size(351, 30);
            this.TxtBoxNama.TabIndex = 0;
            this.TxtBoxNama.TextChanged += new System.EventHandler(this.TxtBoxNama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nama Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // TxtBoxTotal
            // 
            this.TxtBoxTotal.BackColor = System.Drawing.Color.LightGray;
            this.TxtBoxTotal.Location = new System.Drawing.Point(149, 494);
            this.TxtBoxTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTotal.Name = "TxtBoxTotal";
            this.TxtBoxTotal.ReadOnly = true;
            this.TxtBoxTotal.Size = new System.Drawing.Size(146, 30);
            this.TxtBoxTotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cash";
            // 
            // TxtBoxCash
            // 
            this.TxtBoxCash.Location = new System.Drawing.Point(354, 494);
            this.TxtBoxCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCash.Name = "TxtBoxCash";
            this.TxtBoxCash.Size = new System.Drawing.Size(146, 30);
            this.TxtBoxCash.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga";
            // 
            // TxtBoxHarga
            // 
            this.TxtBoxHarga.BackColor = System.Drawing.Color.LightGray;
            this.TxtBoxHarga.Location = new System.Drawing.Point(574, 439);
            this.TxtBoxHarga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxHarga.Name = "TxtBoxHarga";
            this.TxtBoxHarga.ReadOnly = true;
            this.TxtBoxHarga.Size = new System.Drawing.Size(120, 30);
            this.TxtBoxHarga.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah";
            // 
            // TxtBoxJumlah
            // 
            this.TxtBoxJumlah.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBoxJumlah.Location = new System.Drawing.Point(780, 439);
            this.TxtBoxJumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxJumlah.Name = "TxtBoxJumlah";
            this.TxtBoxJumlah.Size = new System.Drawing.Size(111, 30);
            this.TxtBoxJumlah.TabIndex = 1;
            // 
            // BtnCetak
            // 
            this.BtnCetak.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCetak.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCetak.ForeColor = System.Drawing.Color.White;
            this.BtnCetak.Location = new System.Drawing.Point(780, 489);
            this.BtnCetak.Name = "BtnCetak";
            this.BtnCetak.Size = new System.Drawing.Size(111, 39);
            this.BtnCetak.TabIndex = 5;
            this.BtnCetak.Text = "Cetak";
            this.BtnCetak.UseVisualStyleBackColor = false;
            this.BtnCetak.Click += new System.EventHandler(this.BtnCetak_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHapus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.ForeColor = System.Drawing.Color.White;
            this.BtnHapus.Location = new System.Drawing.Point(643, 489);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(111, 39);
            this.BtnHapus.TabIndex = 4;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseVisualStyleBackColor = false;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTambah.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTambah.ForeColor = System.Drawing.Color.White;
            this.BtnTambah.Location = new System.Drawing.Point(515, 489);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(111, 39);
            this.BtnTambah.TabIndex = 3;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = false;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(780, 25);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 39);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BtnCetak);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.TxtBoxJumlah);
            this.Controls.Add(this.TxtBoxCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxNama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtBoxNama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBoxJumlah;
        private System.Windows.Forms.Button BtnCetak;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}