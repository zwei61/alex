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
    
    public partial class oms_open_tm_ISV
    {
        public System.Guid ISVID { get; set; }
        public string ISVCode { get; set; }
        public string ISVName { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool IsObsoleted { get; set; }
    }
}