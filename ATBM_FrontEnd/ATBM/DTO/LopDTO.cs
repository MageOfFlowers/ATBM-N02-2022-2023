using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM.Admin.DTO
{
    public class LopDTO
    {
        public string MAHP { get; set; }
        public string TENHP { get; set; }
        public int HK { get; set; }
        public int NAM { get; set; }
        public string MACT { get; set; }
        public string display
        {
            get { return $"{MAHP} - {TENHP}"; }
        }

        public Boolean check = true;
    }
}
