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
    
    public partial class oms_vt_Purchase_ConfirmWarehouseIOItem
    {
        public System.Guid WarehouseIOItemID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> PurchaseOrderItemID { get; set; }
        public System.Guid WarehouseIOID { get; set; }
        public string WarehouseIOCode { get; set; }
        public string WarehouseIOTypeCode { get; set; }
        public string WarehouseIOStatusCode { get; set; }
        public System.Guid MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Model { get; set; }
        public Nullable<int> MaterialType { get; set; }
        public string MaterialTypeName { get; set; }
        public string Batch { get; set; }
        public string InventoryTypeCode { get; set; }
        public string InventoryTypeName { get; set; }
        public Nullable<int> ExpectQuantity { get; set; }
        public Nullable<int> FactQuantity { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
    }
}
