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
    
    public partial class oms_tm_QAManager
    {
        public System.Guid QAManagerID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string Department { get; set; }
        public string DepartmentTeam { get; set; }
        public string SystemGroup { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Duties { get; set; }
        public string WorkKind { get; set; }
        public string CustomerViewJurisdiction { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
    }
}