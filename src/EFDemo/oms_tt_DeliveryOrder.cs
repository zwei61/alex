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
    
    public partial class oms_tt_DeliveryOrder
    {
        public System.Guid DeliveryOrderID { get; set; }
        public System.Guid CompanyID { get; set; }
        public System.Guid SalesOrderID { get; set; }
        public Nullable<int> DeliveryOrderStatusCode { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public System.DateTime ExpetDeliveryDate { get; set; }
        public Nullable<System.DateTime> FactDeliveryDate { get; set; }
        public Nullable<bool> WaitSyncVss_Delivery { get; set; }
        public Nullable<int> SyncVssNum_Delivery { get; set; }
        public Nullable<System.DateTime> SyncVssDate_Delivery { get; set; }
        public string SyncVssFlag { get; set; }
        public string DeliveryOrderCode { get; set; }
    }
}
