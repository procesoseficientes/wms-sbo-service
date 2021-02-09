using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SAPbobsCOM;
using SBOService.Model;

namespace SBOService.Services
{    
    public class SAPService
    {
        public Company oCompany;
        public SAPService(AppSettings configuration)
        {
            oCompany = new Company
            {
                UseTrusted = false,
                CompanyDB = configuration.CompanyDB,
                Server = configuration.Server,
                UserName = configuration.UserName,
                Password = configuration.Password,
                DbUserName = configuration.DbUserName,
                DbPassword = configuration.DbPassword,
                DbServerType = configuration.DbServerType,
                LicenseServer = configuration.LicenseServer,
                language = configuration.Language,
            };
        }

        public void Connect()
        {
            int ret = oCompany.Connect();
            string errMsg = oCompany.GetLastErrorDescription();
            int errNo = oCompany.GetLastErrorCode();
            if (errNo != 0) throw new Exception(errMsg);
        }
        public Documents GetDraft(int DocEntry)
        {
            Connect();
            var draft = (Documents)oCompany.GetBusinessObject(BoObjectTypes.oDrafts);
            draft.GetByKey(DocEntry);

            return draft;
        }
        public string SaveDraftToDocument(int DocEntry)
        {
            Documents draft = (Documents)oCompany.GetBusinessObject(BoObjectTypes.oDrafts);
            bool retVal = draft.GetByKey(DocEntry);
            int docNum = draft.DocNum;

            if (retVal == true)
            {
                string key = draft.DocNum.ToString();
                draft.UserFields.Fields.Item("U_Estado2").Value = "05";
                if (draft.Update() == 0 && draft.SaveDraftToDocument() == 0)
                {
                    return key;
                }
                
                oCompany.GetLastError(out int codigo, out string mensaje);
                return "Error: " + codigo.ToString() + ", " + mensaje;
            } else
            {
                oCompany.GetLastError(out int codigo, out string mensaje);

                return "Error: " + codigo.ToString() + ", " + mensaje;
            }
        }
    }
}
