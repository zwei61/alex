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
    
    public partial class oms_tm_Supplier
    {
        public System.Guid SupplierID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string Area { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Brand { get; set; }
        public string SupplierType { get; set; }
        public int MaterialType { get; set; }
        public Nullable<int> TransMode_default { get; set; }
        public int Supplier_SignVerifyCostDays { get; set; }
        public int Supplier_ManufactureCostDays { get; set; }
        public int Supplier_TransCostDays { get; set; }
        public Nullable<int> IsCooperation { get; set; }
        public string Address { get; set; }
        public string Leader { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string FinanceCode { get; set; }
        public string Memo { get; set; }
        public string Contacts { get; set; }
        public string ContactPhone { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public string o_agentId { get; set; }
        public string o_supplierId { get; set; }
        public Nullable<int> Supplier_BO_SignVerifyCostDays { get; set; }
        public Nullable<System.DateTime> sync_vk_date { get; set; }
    }
}
