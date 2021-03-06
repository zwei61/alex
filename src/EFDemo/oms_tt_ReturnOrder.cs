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
    
    public partial class oms_tt_ReturnOrder
    {
        public System.Guid ReturnOrderID { get; set; }
        public System.Guid CompanyID { get; set; }
        public string ReturnOrderCode { get; set; }
        public string ReturnOrderStatusCode { get; set; }
        public System.Guid SalesOrderID { get; set; }
        public System.Guid WarehouseID { get; set; }
        public string Returner { get; set; }
        public string ReturnerPhone { get; set; }
        public string ReturnerAddress { get; set; }
        public Nullable<int> ReturnerCityID { get; set; }
        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string ConsigneeAddress { get; set; }
        public Nullable<int> ConsigneeCityID { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> WarehousedDate { get; set; }
        public Nullable<System.Guid> Rejecter { get; set; }
        public Nullable<System.DateTime> RejectDate { get; set; }
        public string RejectReason { get; set; }
        public Nullable<int> ReturnModeCode { get; set; }
        public bool Recaption { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public Nullable<bool> IsSync { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public Nullable<bool> WaitSyncVss_Rejecter { get; set; }
        public Nullable<int> SyncVssNum_Rejecter { get; set; }
        public Nullable<System.DateTime> SyncVssDate_Rejecter { get; set; }
        public Nullable<bool> WaitSyncVss_WarehouseIn { get; set; }
        public Nullable<int> SyncVssNum_WarehouseIn { get; set; }
        public Nullable<System.DateTime> SyncVssDate_WarehouseIn { get; set; }
    }
}
