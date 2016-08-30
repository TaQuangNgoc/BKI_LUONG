using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LicenseManager
{
    public class CTrial
    {
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public DateTime TRAIL_TIME { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public string COMPANY { get; set; }
    }

    public class CLicense {
        public string COMPANY { get; set; }
        public DateTime CREATE_TIME { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
    }
}
