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
    
    public partial class oms_tt_SalesOrderContract
    {
        public System.Guid SalesOrderContractID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string ContractCode { get; set; }
        public string CustomerName { get; set; }
        public string ProductPackage { get; set; }
        public string ProjectStatus { get; set; }
        public System.DateTime ContractSigningDate { get; set; }
        public Nullable<System.DateTime> ContractBeginWorkDate { get; set; }
        public Nullable<System.DateTime> MidTermAcceptanceCheckDate { get; set; }
        public Nullable<System.DateTime> ContractCompletedDate { get; set; }
        public string Memo { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public System.DateTime BuyTime { get; set; }
    }
}
