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
    
    public partial class oms_open_vt_ShoppingOrderItem
    {
        public System.Guid openShoppingOrderItemID { get; set; }
        public System.Guid openShoppingOrderID { get; set; }
        public System.Guid APPID { get; set; }
        public string o_skuId { get; set; }
        public string o_itemId { get; set; }
        public Nullable<int> o_quantity { get; set; }
        public System.Guid CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public Nullable<System.Guid> WarehouseIOItemID { get; set; }
        public string WarehouseIOCode { get; set; }
        public Nullable<System.Guid> openPurchaseOrderItemID { get; set; }
        public string o_buyerCompanyId { get; set; }
        public string o_buyerCompanyName { get; set; }
        public string o_buyerCompanyPid { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Model { get; set; }
        public string TransModeName { get; set; }
        public Nullable<int> ExpectQuantity { get; set; }
    }
}
