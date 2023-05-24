using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KasirApp
{
    internal class Connection
    {
        public OleDbConnection GetConn ()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\college\\Framework-based Programming\\KasirApp\\KasirApp\\KasirApp1.accdb\"";
            return conn;
        }

        
    }
}
