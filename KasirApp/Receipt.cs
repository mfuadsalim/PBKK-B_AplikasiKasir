using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirApp
{
    public class Receipt
    {
        public int id { get; set; }
        public string name { get; set; }
        public double harga { get; set; }
        public int jumlah { get; set; }
        public string total { get { return string.Format("Rp{0}", harga * jumlah); } }
    }
}
