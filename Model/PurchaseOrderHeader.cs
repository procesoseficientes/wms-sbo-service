using System;

namespace SBOService.Services
{
    public class PurchaseOrderHeader
    {
        public string CardCode { get; internal set; }
        public DateTime DocDate { get; internal set; }
        public string Comments { get; internal set; }
        public string DocCur { get; internal set; }
    }
}