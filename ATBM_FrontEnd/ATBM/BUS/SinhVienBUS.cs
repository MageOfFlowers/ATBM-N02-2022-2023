using System;
using System.Data;
using System.Windows.Forms;
using ATBM.DTO;
using Oracle.ManagedDataAccess.Client;

namespace ATBM.BUS
{
    internal class SinhVienBUS
    {
        readonly OracleConnection connection = new OracleConnection(Program.connectionString);
    }
}
