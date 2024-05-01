using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ATBM.DTO;
using System.CodeDom.Compiler;
using System.IO;

namespace ATBM.BUS
{
    public class cmdBUS
    {
        public void PhucHoiBang(string tenbang, string tg, string luachon)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            Process process = Process.Start(psi);
            StreamWriter sw = process.StandardInput;

            //input command line here;
            sw.WriteLine("sqlplus / as sysdba"); 
            sw.WriteLine("alter session set container = ATBM_3;");
            sw.WriteLine("ALTER TABLE admin_ols1." + tenbang+" ENABLE ROW MOVEMENT;");
            //sw.WriteLine("ALTER TABLE admin_ols1." + tenbang+" FLASHBACK ON;");
            if (luachon == "1")
            {
                sw.WriteLine("flashback TABLE admin_ols1." + tenbang + " to timestamp (systimestamp - interval '" + tg + "' minute);");
            }
            else if (luachon == "2") 
            {
                sw.WriteLine("flashback TABLE admin_ols1." + tenbang + " to timestamp TO_TIMESTAMP('" + tg + "', 'YYYY-MM-DD HH24:MI:SS');");
            }
            else
            {
                sw.WriteLine("flashback table admin_ols1." + tenbang + " to restore point CHECKPOINT_1;");
                sw.WriteLine("alter database open resetlogs;");
            }
            
            sw.WriteLine("exit");

            //
            sw.Close();
            string output = process.StandardOutput.ReadToEnd();
            MessageBox.Show(output);
            process.WaitForExit();
            process.Close();

        }
        public void PhucHoiDuLieu(string tg, string luachon)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            Process process = Process.Start(psi);
            StreamWriter sw = process.StandardInput;

            //input command line here;
            sw.WriteLine("sqlplus / as sysdba");
            sw.WriteLine("alter session set container = ATBM_3;");
            sw.WriteLine("alter pluggable database ATBM_3 close;");
            if (luachon == "1")
            {
                sw.WriteLine("flashback TABLE pluggable database ATBM_3 to timestamp (systimestamp - interval '" + tg + "' minute);");
            }
            else if (luachon == "2")
            {
                sw.WriteLine("flashback TABLE pluggable database ATBM_3 to timestamp TO_TIMESTAMP('" + tg + "', 'YYYY-MM-DD HH24:MI:SS');");
            }
            else
            {
                sw.WriteLine("flashback pluggable database ATBM_3 to restore point CHECKPOINT_1;");
                sw.WriteLine("alter database open resetlogs;");
            }
            
            sw.WriteLine("exit");

            //
            sw.Close();
            string output = process.StandardOutput.ReadToEnd();
            MessageBox.Show(output);
            process.WaitForExit();
            process.Close();

        }
        public void TaoCheckPoint()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            Process process = Process.Start(psi);
            StreamWriter sw = process.StandardInput;

            //input command line here;
            sw.WriteLine("sqlplus / as sysdba");
            sw.WriteLine("create restore point CHECKPOINT_1 guarantee flashback database;");
            sw.WriteLine("exit");

            //
            sw.Close();
            string output = process.StandardOutput.ReadToEnd();
            MessageBox.Show(output);
            process.WaitForExit();
            process.Close();
        }

    }
}
