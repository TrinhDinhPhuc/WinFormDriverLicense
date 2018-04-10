using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatHachBangLaiXe
{
    public class OnTap
    {
        private DataTable ds1;
        public OnTap()
        {
            string cmd = "SELECT* FROM phan1 union SELECT * FROM phan2  union SELECT* FROM phan3 union SELECT* FROM phan4  union  SELECT* FROM phan5  union  SELECT* FROM phan6";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
            ds1 = new DataTable();
            adap.Fill(ds1);
        }
        public DataTable getOnTap()
        {
            return ds1;
        }

    }
}
