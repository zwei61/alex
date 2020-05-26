//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class oms_va_Biz_InPa
    {
        public System.Guid BizInPaID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.DateTime ArchiveDate { get; set; }
        public System.Guid MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string SupplyTypeName { get; set; }
        public Nullable<int> MaterialType { get; set; }
        public string MaterialTypeName { get; set; }
        public string Model { get; set; }
        public string Standard { get; set; }
        public string Unit { get; set; }
        public string Kind { get; set; }
        public string SubKind { get; set; }
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public System.Guid SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public System.Guid BizWarehouseID { get; set; }
        public string BizWarehouseCode { get; set; }
        public string BizWarehouseName { get; set; }
        public System.Guid BizOrderID { get; set; }
        public System.Guid BizOrderItemID { get; set; }
        public string BizOrderCode { get; set; }
        public string BizTypeName { get; set; }
        public string BizIOTypeCode { get; set; }
        public int BizOrderTypeCode { get; set; }
        public System.DateTime BizDate { get; set; }
        public string Batch { get; set; }
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public int BizQuantity { get; set; }
        public Nullable<System.Guid> IncomeFromID { get; set; }
        public string IncomeFromName { get; set; }
        public Nullable<System.Guid> PaymentToID { get; set; }
        public string PaymentToName { get; set; }
        public Nullable<decimal> IncomeTaxPrice { get; set; }
        public Nullable<decimal> IncomeTaxAmount { get; set; }
        public Nullable<decimal> IncomeNoTaxPrice { get; set; }
        public Nullable<decimal> IncomeNoTaxAmount { get; set; }
        public Nullable<decimal> PaymentTaxPrice { get; set; }
        public Nullable<decimal> PaymentTaxAmount { get; set; }
        public Nullable<decimal> PaymentNoTaxPrice { get; set; }
        public Nullable<decimal> PaymentNoTaxAmount { get; set; }
        public Nullable<decimal> CostTaxPrice { get; set; }
        public Nullable<decimal> CostTaxAmount { get; set; }
        public Nullable<decimal> CostNoTaxPrice { get; set; }
        public Nullable<decimal> CostNoTaxAmount { get; set; }
        public Nullable<decimal> SupplyTaxPrice { get; set; }
        public Nullable<decimal> SupplyTaxAmount { get; set; }
        public Nullable<decimal> SupplyNoTaxPrice { get; set; }
        public Nullable<decimal> SupplyNoTaxAmount { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public string Kind_3rd { get; set; }
    }
}