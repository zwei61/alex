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
    
    public partial class oms_vm_SupplyPrice
    {
        public System.Guid SupplyPriceID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public System.Guid MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string Model { get; set; }
        public string MaterialName { get; set; }
        public int TransMode { get; set; }
        public string TransModeName { get; set; }
        public System.Guid SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public System.DateTime BeginDate { get; set; }
        public decimal SupplyTaxPrice { get; set; }
        public decimal SupplyNoTaxPrice { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public string ParentMaterialCode { get; set; }
    }
}