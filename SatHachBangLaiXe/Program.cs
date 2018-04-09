using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachBangLaiXe
{
    static class Program
    {

        public static string connStr = @"Data Source=PHUCCOI\PHUCCOI;Initial Catalog=SATHACHLAIXE;user=sa;pwd=123456";
        public static string MBT;
        public static string SBD;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMenu());
        }
    }
}
