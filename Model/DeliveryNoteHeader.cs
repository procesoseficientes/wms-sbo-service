using SBOService.Model;
using System;
using System.Collections.Generic;

namespace SBOService.Services
{
    public class DeliveryNoteHeader
    {
        public List<DeliveryDetail> DeliveryDetail { get; set; }
        public List<PickingSerie> SwiftPickingSeries { get; set; }
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string Classification { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string HandWritten { get; set; }
        public DateTime DocDate { get; set; }
        public string Comments { get; set; }
        public string DocCur { get; set; }
        public decimal DocRate { get; set; }
        public decimal? DiscPrcnt
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string Address2
        {
            get;
            set;
        }

        public string ShipToAddressType
        {
            get;
            set;
        }

        public string ShipToStreet
        {
            get;
            set;
        }

        public string ShipToState
        {
            get;
            set;
        }

        public string ShipToCountry
        {
            get;
            set;
        }

        public short? TrnspCode
        {
            get;
            set;
        }

        public DateTime? DocDueDate
        {
            get;
            set;
        }

        public short? SalesPersoncode
        {
            get;
            set;
        }
        public string UFacSerie { get; set; }
        public string StringUFacNit { get; set; }
        public string UFacNom { get; set; }
        public string UFacFecha { get; set; }
        public string StringUTienda { get; set; }
        public string UStatusNc { get; set; }
        public string UUsuario { get; set; }
        public string UFacnum { get; set; }
        public string USucursal { get; set; }
        // ReSharper disable once InconsistentNaming
        public string U_Total_Flete { get; set; }
        public string UTipoPago { get; set; }
        public string UCuotas { get; set; }
        public string UTotalTarjeta { get; set; }
        public string UFechap { get; set; }
        // ReSharper disable once InconsistentNaming
        public string UTrasladoOC { get; set; }


        public string UEstado2 { get; set; }
        public string UStatusDespacho { get; set; }
        public string UFacserie { get; set; }
        public string UFacnit { get; set; }
        public string UFacnom { get; set; }
        public string UTienda { get; set; }
        public string UTipoDocumento { get; set; }
        public string UTotalFlete { get; set; }

        public string U_Bodega { get; set; }

        public int PICKING_HEADER { get; set; }
        public string CLASSIFICATION_PICKING { get; set; }
        public string CODE_CLIENT { get; set; }
        public string NAME_CUSTOMER { get; set; }
        public string ADRESS_CUSTOMER { get; set; }
        public string CODE_USER { get; set; }
        public string REFERENCE { get; set; }
        public string DOC_SAP_RECEPTION { get; set; }
        public string STATUS { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        public string LAST_UPDATE_BY { get; set; }
        public string COMMENTS { get; set; }
        public DateTime SCHEDULE_FOR { get; set; }
        public int SEQ { get; set; }
        public string FF { get; set; }
        public string FF_STATUS { get; set; }
        public int? ATTEMPTED_WITH_ERROR { get; set; }
        public int? IS_POSTED_ERP { get; set; }
        public DateTime? POSTED_ERP { get; set; }
        public string POSTED_RESPONSE { get; set; }
        public string CODE_WAREHOUSE_SOURCE { get; set; }
        public string SOURCE_DOC_TYPE { get; set; }
        public int? SOURCE_DOC { get; set; }
        public int? TARGET_DOC { get; set; }
        public string CODE_SELLER { get; set; }
        public string CODE_ROUTE { get; set; }
        public string ERP_REFERENCE { get; set; }
        public int HAS_MASTERPACK { get; set; }
        public int POSTED_STATUS { get; set; }
        public string CODE_WAREHOUSE { get; set; }
        public string OWNER { get; set; }
        public int PERFORMS_INTERNAL_SALE { get; set; }
        public int INTERNAL_SALE_INTERFACE { get; set; }
        public string INTERNAL_SALE_COMPANY { get; set; }
        public string INNER_SALE_STATUS { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public string TAX_ID { get; set; }
        public string CARD_NAME { get; set; }

        public int? PAYMENT_CONDITION { get; set; }

        public string NumAtCard { get; set; }
        public DateTime? U_FacFecha { get; set; }
        public string U_FacNit { get; set; }
        public string U_FacNom { get; set; }
        public string U_Sucursal { get; set; }
        public string U_MotivoAuto { get; set; }
        public decimal DISCOUNT { get; set; }

        public int WAVE_PICKING_ID { get; set; }

        public int DOC_NUM { get; set; }
        public string PICKING_STATUS { get; set; }
    }
}