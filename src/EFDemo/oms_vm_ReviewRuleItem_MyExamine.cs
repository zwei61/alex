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
    
    public partial class oms_vm_ReviewRuleItem_MyExamine
    {
        public System.Guid MyExamineID { get; set; }
        public string ReviewRuleTypeCode { get; set; }
        public string OrigStatusCode { get; set; }
        public string TargStatusCode { get; set; }
        public System.Guid ReviewRuleItemID { get; set; }
        public int ReviewStatusCode { get; set; }
        public System.Guid OrderID { get; set; }
        public string OrderCode { get; set; }
        public Nullable<System.DateTime> OrderCreateDate { get; set; }
        public Nullable<System.Guid> CurrentReviewSubmiterID { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public bool IsObsoleted { get; set; }
        public System.Guid Reviewer { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewRuleTypeName { get; set; }
        public string OrigStatusName { get; set; }
        public string TargStatusName { get; set; }
        public string CurrentReviewSubmiterName { get; set; }
        public string ReviewStatusName { get; set; }
        public System.Guid CompanyID { get; set; }
    }
}
