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
    
    public partial class oms_open_vt_PurchaseOrderTradeInfo
    {
        public System.Guid openPurchaseOrderTradeInfoID { get; set; }
        public System.Guid openPurchaseOrderID { get; set; }
        public System.Guid APPID { get; set; }
        public string o_id { get; set; }
        public string o_mainOrderId { get; set; }
        public string o_userId { get; set; }
        public string o_receiveUserName { get; set; }
        public string o_phone { get; set; }
        public string o_mobile { get; set; }
        public string o_email { get; set; }
        public string o_isDefault { get; set; }
        public string o_status { get; set; }
        public string o_provinceId { get; set; }
        public string o_province { get; set; }
        public string o_cityId { get; set; }
        public string o_city { get; set; }
        public string o_regionId { get; set; }
        public string o_region { get; set; }
        public string o_streetId { get; set; }
        public string o_street { get; set; }
        public string o_detail { get; set; }
        public string o_postcode { get; set; }
        public string o_company { get; set; }
        public Nullable<System.DateTime> o_createdAt { get; set; }
        public Nullable<System.DateTime> o_updateAt { get; set; }
        public System.Guid CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
    }
}
