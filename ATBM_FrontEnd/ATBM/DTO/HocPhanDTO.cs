using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM.DTO
{
    public class HocPhanDTO
    {
        [DisplayName("Mã học phần")]
        public string MAHP {  get; set; }

        [DisplayName("Tên học phần")]
        public string TENHP { get; set; }

        [DisplayName("Số tín chỉ")]
        public int SOTC { get; set; }

        [DisplayName("Số tiết lý thuyết")]
        public int STLT { get; set; }

        [DisplayName("Số tiết thực hành")]
        public int STTH { get; set; }

        [DisplayName("Số sinh viên tiếp nhận")]
        public int SOSVTD { get; set; }

        [DisplayName("Mã đơn vị")]
        public string MADV { get; set; }
    }
}
