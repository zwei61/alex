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
    
    public partial class oms_open_vt_SettlementOrderItem
    {
        public System.Guid SettlementOrderItemID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.Guid SettlementOrderID { get; set; }
        public decimal BillAmount { get; set; }
        public decimal SettlementAmount { get; set; }
        public decimal ConfirmAmount { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public System.Guid SupplierID { get; set; }
        public string SettlementOrderStatusName { get; set; }
        public string o_skuId { get; set; }
        public Nullable<int> SettlementOrderStatusCode { get; set; }
        public Nullable<System.Guid> MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string MaterialCode { get; set; }
        public string Standard { get; set; }
        public string Model { get; set; }
        public string BarCode { get; set; }
        public string Unit { get; set; }
        public string o_skuCode { get; set; }
    }
}
