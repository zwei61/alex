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
    
    public partial class oms_ta_Inventory
    {
        public System.Guid InventoryDailyID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.DateTime ArchiveDate { get; set; }
        public System.Guid WarehouseID { get; set; }
        public System.Guid MaterialID { get; set; }
        public string Batch { get; set; }
        public string InventoryTypeCode { get; set; }
        public int Quantity_First { get; set; }
        public Nullable<int> Quantity_In { get; set; }
        public Nullable<int> Quantity_Out { get; set; }
        public int Quantity_End { get; set; }
        public System.Guid SupplierID { get; set; }
        public decimal SupplyTaxPrice { get; set; }
        public decimal SupplyNoTaxPrice { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
    }
}
