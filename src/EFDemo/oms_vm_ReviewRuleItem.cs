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
    
    public partial class oms_vm_ReviewRuleItem
    {
        public System.Guid ReviewRuleItemID { get; set; }
        public System.Guid ReviewRuleID { get; set; }
        public string ReviewRuleItemCode { get; set; }
        public string ReviewRuleItemName { get; set; }
        public int ReviewRuleItemOrder { get; set; }
        public System.Guid Reviewer { get; set; }
        public System.Guid CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool IsObsoleted { get; set; }
        public string ReviewRuleTypeCode { get; set; }
        public string ReviewRuleTypeName { get; set; }
        public string OrigStatusCode { get; set; }
        public string OrigStatusName { get; set; }
        public string TargStatusCode { get; set; }
        public string TargStatusName { get; set; }
        public string ReviewRuleName { get; set; }
        public string ReviewRuleCode { get; set; }
        public int ReviewOrder { get; set; }
        public string OperatorName { get; set; }
        public Nullable<bool> RuleItemIsUse { get; set; }
        public Nullable<bool> IsUse { get; set; }
        public string Trigger_Allow { get; set; }
        public string Trigger_Deny { get; set; }
        public System.Guid CompanyID { get; set; }
    }
}
