using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using ATBM.Admin.DTO;

namespace ATBM.Admin.BUS
{
    internal class TTHSTrongLopBUS
    {
        readonly public OracleConnection connection = new OracleConnection(Program.connectionString);

        public DataTable LayThongTinHocSinhTrongLop(string pMAHP, int pHK, int pNAM , string pMACT)
        {
            DataTable dataTable = new DataTable();
            string procedureName = "admin_ols1.lay_thong_tin_lop_hoc";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();
                OracleDataAdapter da = new OracleDataAdapter();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("pMAHP", OracleDbType.Varchar2).Value = pMAHP;
                command.Parameters.Add("pHK", OracleDbType.Int16).Value = pHK;
                command.Parameters.Add("pNAM", OracleDbType.Int16).Value = pNAM;
                command.Parameters.Add("pMACT", OracleDbType.Varchar2).Value = pMACT;
                command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                da.SelectCommand = command;
                da.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public void CapNhatDiem(DataTable dt, LopDTO Lop)
        {
            string procedureName = "admin_ols1.cap_nhat_diem";
            using (OracleCommand command = new OracleCommand(procedureName, connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("pMAHP", OracleDbType.Varchar2).Value = Lop.MAHP;
                command.Parameters.Add("pHK", OracleDbType.Int16).Value = Lop.HK;
                command.Parameters.Add("pNAM", OracleDbType.Int16).Value = Lop.NAM;               
                command.Parameters.Add("pMACT", OracleDbType.Varchar2).Value = Lop.MACT;

                foreach (DataRow row in dt.Rows)
                {        
                    Console.WriteLine(row);
                    command.Parameters.Add("pMASV", OracleDbType.Varchar2).Value = row["MASV"].ToString();
                    if (row["DIEMTH"] == DBNull.Value)
                    {
                        command.Parameters.Add("pTH", OracleDbType.Double).Value = 10;
                    }
                    else {command.Parameters.Add("pTH", OracleDbType.Double).Value = Convert.ToDouble(row["DIEMTH"]); }
                    if (row["DIEMQT"] == DBNull.Value)
                    {
                        command.Parameters.Add("pQT", OracleDbType.Double).Value = 10;
                    }
                    else { command.Parameters.Add("pQT", OracleDbType.Double).Value = Convert.ToDouble(row["DIEMQT"]); }
                    if (row["DIEMCK"] == DBNull.Value)
                    {
                        command.Parameters.Add("pCK", OracleDbType.Double).Value = 10;
                    }
                    else { command.Parameters.Add("pCK", OracleDbType.Double).Value = Convert.ToDouble(row["DIEMCK"]); }
                    if (row["DIEMTK"] == DBNull.Value)
                    {
                        command.Parameters.Add("pTK", OracleDbType.Double).Value = 10;
                    }
                    else { command.Parameters.Add("pTK", OracleDbType.Double).Value = Convert.ToDouble(row["DIEMTK"]); }
                    command.ExecuteNonQuery();
                    command.Parameters.Remove(command.Parameters["pMASV"]);
                    command.Parameters.Remove(command.Parameters["pTH"]);
                    command.Parameters.Remove(command.Parameters["pQT"]);
                    command.Parameters.Remove(command.Parameters["pCK"]);
                    command.Parameters.Remove(command.Parameters["pTK"]);
                }

                MessageBox.Show("success");
                
                connection.Close();
            }
        }
    }
}
