using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        static public string laybien()
        {

            //SqlConnection connDB = new SqlConnection(Program.connStr);
            //connDB.Open();
            //String sqlcmd = "";
            //sqlcmd = "select TOP(1) TTDeThi.MaDeThi from TTHocVien  inner join TTDeThi on TTHocVien.KyThi= TTDeThi.KyThi inner join TTDeThiCauHoi on    TTDeThiCauHoi.MaDeThi = TTDeThi.MaDeThi inner join TTCauHoi on TTCauHoi.MaCH= TTDeThiCauHoi.MaCH where TTHocVien.MaHV='" + Properties.Settings.Default.mahocvien + "' ORDER BY NEWID()";
            //string a = sqlcmd;
            //SqlCommand sqlCmd = new SqlCommand(sqlcmd, connDB);
            //try
            //{
            //    string aa = sqlCmd.ExecuteNonQuery().ToString();
            //    Properties.Settings.Default.madethi = aa;
            //}
            //catch { }
            //connDB.Close();
            //return a;
            string result = "";
            string connString = @"Data Source=PHUCCOI\PHUCCOI;Initial Catalog=SATHACHLAIXE;user=sa;pwd=123456";
            string sql= "select TOP(1) TTDeThi.MaDeThi from TTHocVien  inner join TTDeThi on TTHocVien.KyThi= TTDeThi.KyThi inner join TTDeThiCauHoi on    TTDeThiCauHoi.MaDeThi = TTDeThi.MaDeThi inner join TTCauHoi on TTCauHoi.MaCH= TTDeThiCauHoi.MaCH where TTHocVien.MaHV='" + Properties.Settings.Default.mahocvien + "' ORDER BY NEWID()";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    result = cmd.ExecuteScalar().ToString();
                    string madethi = result;
                    Properties.Settings.Default.madethi = madethi;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n\n\nko them dccccccccccc");
                }

            }
            return result;
        }
        public DeThi()
            {
            laybien();
                //string cmd = "SELECT * FROM phan1 union SELECT* FROM phan2  union SELECT* FROM phan3 union SELECT* FROM phan4  union  SELECT* FROM phan5  union  SELECT* FROM phan6";
                //string cmd = "Select TTCauHoi.MaCH , TTCauHoi.SoDA , TTCauHoi.DapAn from TTCauHoi INNER JOIN TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  where TTDeThiCauHoi.MaDeThi='KT01001' ";
            string cmd = "select TTCauHoi.MaCH ,TTCauHoi.SoDA ,TTCauHoi.DapAn from TTCauHoi inner join TTDeThiCauHoi on TTCauHoi.MaCH = TTDeThiCauHoi.MaCH  where TTDeThiCauHoi.MaDeThi =   '" + Properties.Settings.Default.madethi + "' ";

            Console.WriteLine("\n\n\n\n Gia tri cua madethi la:  " + Properties.Settings.Default.madethi);

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
