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
    
    public partial class oms_vt_DeliveryOrder
    {
        public System.Guid DeliveryOrderID { get; set; }
        public System.DateTime ExpetDeliveryDate { get; set; }
        public Nullable<System.DateTime> FactDeliveryDate { get; set; }
        public System.Guid SalesOrderID { get; set; }
        public System.Guid CompanyID { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> SalesOrderStatusCode { get; set; }
        public string SalesOrderStatusName { get; set; }
        public Nullable<int> SalesOrderMaterialType { get; set; }
        public string SalesOrderCode { get; set; }
        public Nullable<System.Guid> WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string SalesOrderMaterialTypeName { get; set; }
        public Nullable<int> ProjectType { get; set; }
        public string ProjectTypeName { get; set; }
        public Nullable<int> DeliveryOrderStatusCode { get; set; }
        public string DeliveryOrderStatusName { get; set; }
        public string HHName { get; set; }
        public string HHAddress { get; set; }
        public string DeliveryOrderCode { get; set; }
        public string ProductPackage { get; set; }
    }
}
