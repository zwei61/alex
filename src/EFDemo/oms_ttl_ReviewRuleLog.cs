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
    
    public partial class oms_ttl_ReviewRuleLog
    {
        public System.Guid ReviewRuleLogID { get; set; }
        public System.Guid ReviewDataID { get; set; }
        public System.Guid ReviewRuleID { get; set; }
        public System.Guid ReviewRuleItemID { get; set; }
        public string ReviewRuleTypeCode { get; set; }
        public string OrigStatusCode { get; set; }
        public string TargStatusCode { get; set; }
        public int ReviewResultCode { get; set; }
        public System.DateTime ReviewDate { get; set; }
        public Nullable<System.Guid> Submiter { get; set; }
        public System.Guid Reviewer { get; set; }
        public string Memo { get; set; }
        public System.Guid CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool IsObsoleted { get; set; }
        public Nullable<System.DateTime> CurrentReviewBeginTime { get; set; }
        public System.Guid CompanyID { get; set; }
    }
}
