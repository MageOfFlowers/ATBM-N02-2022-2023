using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATBM.DTO
{
    public class NhanSuDTO
    {
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public string PHAI { get; set; }
        public DateTime NGSINH { get; set; }
        public double PHUCAP { get; set; }
        public string DT { get; set; }
        public string VAITRO { get; set; }
        public string MADV { get; set; }
        public string display
        {
            get { return $"{MANV} - {HOTEN}"; }
        }
    }
}
