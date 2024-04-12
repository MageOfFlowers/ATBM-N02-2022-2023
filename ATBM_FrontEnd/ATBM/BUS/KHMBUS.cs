using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM.DTO;

namespace ATBM.BUS
{
    internal class KHMBUS
    {
        public OracleConnection connection = new OracleConnection(Program.connectionString);

        public IList<KHMDTO> ds_KHM()
        {
            string procedureName = "xem_ke_hoach_mo";
            try
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(procedureName, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("c1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        IList<KHMDTO> ds = new List<KHMDTO>();

                        // Read data and populate IList
                        while (reader.Read())
                        {
                            KHMDTO obj = new KHMDTO();
                            obj.MAHP = reader["mahp"].ToString();
                            obj.TENHP = reader["tenhp"].ToString();
                            // Map other properties as needed

                            resultList.Add(obj);
                        }

                        // Use resultList as needed
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                connection.Close(); 
            }
        }
    }
}
