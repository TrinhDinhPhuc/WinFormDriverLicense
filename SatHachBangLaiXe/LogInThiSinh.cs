using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace SatHachBangLaiXe
{
    public partial class LogInThiSinh : MetroFramework.Forms.MetroForm
    {
        public LogInThiSinh()
        {
            InitializeComponent();
        }

        private void LogInThiSinh_Load(object sender, EventArgs e)
        {
            //Khởi tạo giao diện metro
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra null or empty
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng điền tên đăng nhập", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
                return;
            }
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //Excute sql query, then map data return from sql to User class
                    UserThiSinh obj = db.Query<UserThiSinh>($"select * from TTHocVien where SoCMND ='{txtTenTaiKhoan.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    string mahocvien = obj.MaHV;
                    Properties.Settings.Default.mahocvien = mahocvien;
                    if (obj != null)
                    {
                        if (obj.MaHV == txtMatKhau.Text)//True
                        {
                            Console.WriteLine("\n\n Gia tri cua mahocvien la:  " + Properties.Settings.Default.mahocvien);

                            using (FrmThi frm = new FrmThi())//Open main form and hide login form
                            {
                                this.Hide();
                                frm.ShowDialog();
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Sai Tài Khoản Hoặc Mật Khẩu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Sai Tài Khoản Hoặc Mật Khẩu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
