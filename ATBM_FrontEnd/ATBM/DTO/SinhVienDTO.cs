using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATBM.DTO
{
    internal class SinhVienDTO
    {
        public string MASV { get; set; }
        public string HOTEN { get; set; }
        public string PHAI { get; set; }
        public DateTime NGSINH { get; set; }
        public string DCHI { get; set; }
        public string DT { get; set; }
        public string MACT { get; set; }
        public string MANGANH { get; set; }
        public int SOTCTL { get; set; }
        public double DTBTL { get; set; }
    }
}
