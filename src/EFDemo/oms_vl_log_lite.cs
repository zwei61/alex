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
    
    public partial class oms_vl_log_lite
    {
        public System.Guid logID { get; set; }
        public bool error { get; set; }
        public Nullable<bool> result_failure { get; set; }
        public string work_name { get; set; }
        public Nullable<System.DateTime> begin_date { get; set; }
        public System.DateTime create_date { get; set; }
        public Nullable<decimal> consuming_time { get; set; }
        public bool is_obsoleted { get; set; }
    }
}
