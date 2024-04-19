using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM.DTO
{
    internal class NhatKyDTO
    {
        public string dbusername { get; set; }
        public string action_name { get; set; }
        public string return_code { get; set; }
        public string object_schema { get; set; }
        public string object_name { get; set; }
        public string system_privilege { get; set; }
        public string unified_audit_policies { get; set; }
        public string event_timestamp { get; set; }
        public Boolean check = true;
    }
}
