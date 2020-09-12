using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBOService.Model
{
    public class AppSettings
    {
        public string CompanyDB { get; set; }
        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public BoDataServerTypes DbServerType { get; set; }
        public string LicenseServer { get; set; }
        public BoSuppLangs Language { get; set; }
    }
}
