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
    
    public partial class oms_open_vt_BillOrderItem
    {
        public System.Guid BillOrderItemID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.Guid BillOrderID { get; set; }
        public string BillOrderCode { get; set; }
        public string SupplierName { get; set; }
        public string BillOrderStatusName { get; set; }
        public System.Guid WarehouseIOID { get; set; }
        public System.Guid MaterialID { get; set; }
        public int TransMode { get; set; }
        public string TransModeName { get; set; }
        public decimal SupplyPrice { get; set; }
        public int BillingQuantity { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public string MaterialName { get; set; }
        public Nullable<int> MaterialType { get; set; }
        public string MaterialTypeName { get; set; }
        public string MaterialCode { get; set; }
        public string BarCode { get; set; }
        public string Batch { get; set; }
        public string Unit { get; set; }
        public string SubBrand { get; set; }
        public string Model { get; set; }
        public string Standard { get; set; }
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public System.Guid WarehouseIOItemID { get; set; }
        public string WarehouseIOStatusCode { get; set; }
        public string WarehouseIOTypeCode { get; set; }
        public Nullable<System.DateTime> WarehouseConfirmDate { get; set; }
        public string WarehouseIOCode { get; set; }
        public string WarehouseIOStatusName { get; set; }
        public string Consignee { get; set; }
        public string Memo { get; set; }
        public int BillOrderStatusCode { get; set; }
        public string o_skuCode { get; set; }
        public string o_skuId { get; set; }
        public string BussinessID { get; set; }
    }
}
