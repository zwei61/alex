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
    
    public partial class oms_vt_wms_Inventory
    {
        public string ViewID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public System.Guid MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Model { get; set; }
        public int MaterialType { get; set; }
        public string MaterialTypeName { get; set; }
        public int SupplyType { get; set; }
        public string SupplyTypeName { get; set; }
        public string BarCode { get; set; }
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public Nullable<int> BatchCount { get; set; }
        public int HouseholdValue { get; set; }
        public int MinDeliveryQuantity { get; set; }
        public int MinPurchaseQuantity { get; set; }
        public int WarningQuantity { get; set; }
        public int ReserveQuantity { get; set; }
        public Nullable<int> SaleableQuantity { get; set; }
        public Nullable<int> Quantity { get; set; }
        public bool StopUse { get; set; }
        public string Standard { get; set; }
        public string Unit { get; set; }
        public string SubBrand { get; set; }
        public string Kind { get; set; }
        public string SubKind { get; set; }
        public Nullable<int> Quantity_Sales_NeedPurchase_NotDelivery { get; set; }
        public string Kind_3rd { get; set; }
        public Nullable<int> Quantity_Purchase_NotWarehoused { get; set; }
        public Nullable<int> Quantity_Sales_BeginWork_NotDelivery { get; set; }
        public Nullable<int> Quantity_Sales_ReadyWork_NotDelivery { get; set; }
    }
}
