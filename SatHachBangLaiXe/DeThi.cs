using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatHachBangLaiXe
{
    public class DeThi
    {
            private DataTable ds;

            public DeThi()
            {
                //string cmd = "SELECT * FROM phan1 union SELECT* FROM phan2  union SELECT* FROM phan3 union SELECT* FROM phan4  union  SELECT* FROM phan5  union  SELECT* FROM phan6";
                //string cmd = "Select TTCauHoi.MaCH , TTCauHoi.SoDA , TTCauHoi.DapAn from TTCauHoi INNER JOIN TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  where TTDeThiCauHoi.MaDeThi='KT01001' ";
                string cmd = "select TTCauHoi.MaCH ,TTCauHoi.SoDA ,TTCauHoi.DapAn from TTCauHoi inner join TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  where TTDeThiCauHoi.MaDeThi =   (select TOP(1) TTDeThi.MaDeThi from TTHocVien  inner join TTDeThi on TTHocVien.KyThi= TTDeThi.KyThi inner join TTDeThiCauHoi on    TTDeThiCauHoi.MaDeThi = TTDeThi.MaDeThi inner join TTCauHoi on TTCauHoi.MaCH= TTDeThiCauHoi.MaCH where TTHocVien.MaHV='" + Properties.Settings.Default.mahocvien + "' ORDER BY NEWID()) ";
                SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.connStr);
                ds = new DataTable();
                adap.Fill(ds);

            }
        public DataTable getDethi()
        {
            return ds;
        }

}
}
