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
    
    public partial class oms_vl_InterfaceFeedback_LackOfMaterialLog
    {
        public System.Guid SalesOrderItemID { get; set; }
        public Nullable<int> OOSQuantity { get; set; }
        public string CompanyCode { get; set; }
        public System.Guid CompanyID { get; set; }
        public string SalesOrderCode { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public Nullable<int> SyncVssNum_OOS { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}