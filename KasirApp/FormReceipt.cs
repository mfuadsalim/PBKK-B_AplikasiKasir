using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class FormReceipt : Form
    {
        List<Receipt> _receiptList;
        string _total, _cash, _change, _date;

        public FormReceipt(List<Receipt> receiptList, string total, string cash, string change, string date)
        {
            InitializeComponent();
            _receiptList = receiptList;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("total", _total),
                new Microsoft.Reporting.WinForms.ReportParameter("cash", _cash),
                new Microsoft.Reporting.WinForms.ReportParameter("change", _change),
                new Microsoft.Reporting.WinForms.ReportParameter("date", _date),
            };
            
            this.reportViewer1.LocalReport.SetParameters(para);

            ReportDataSource rds = new ReportDataSource("DataSetReceipt", _receiptList);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
