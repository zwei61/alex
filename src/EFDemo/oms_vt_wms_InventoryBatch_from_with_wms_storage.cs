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
    
    public partial class oms_vt_wms_InventoryBatch_from_with_wms_storage
    {
        public Nullable<System.Guid> CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public Nullable<int> MaterialType { get; set; }
        public string MaterialTypeName { get; set; }
        public Nullable<int> SupplyType { get; set; }
        public string SupplyTypeName { get; set; }
        public string BarCode { get; set; }
        public string Model { get; set; }
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public string Batch { get; set; }
        public Nullable<int> ReserveQuantity { get; set; }
        public Nullable<int> WarningQuantity { get; set; }
        public int SaleableQuantity { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> MinPurchaseQuantity { get; set; }
        public Nullable<bool> StopUse { get; set; }
    }
}