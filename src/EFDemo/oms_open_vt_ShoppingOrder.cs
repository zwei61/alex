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
    
    public partial class oms_open_vt_ShoppingOrder
    {
        public System.Guid openShoppingOrderID { get; set; }
        public System.Guid APPID { get; set; }
        public System.Guid openPurchaseOrderID { get; set; }
        public string o_mainOrderId { get; set; }
        public Nullable<System.DateTime> o_time { get; set; }
        public Nullable<System.Guid> openShipmentOrderID { get; set; }
        public System.Guid CompanyID { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsObsoleted { get; set; }
        public System.Guid WarehouseIOID { get; set; }
        public string o_buyerName { get; set; }
        public string o_buyerId { get; set; }
        public Nullable<int> openShopOrderStatusCode { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string o_buyerCompanyId { get; set; }
        public string o_buyerCompanyName { get; set; }
        public string o_buyerCompanyPid { get; set; }
        public string o_agentId { get; set; }
        public string o_agentName { get; set; }
        public string o_supplierId { get; set; }
        public string SupplierCode { get; set; }
        public string o_supplierName { get; set; }
        public string o_shipFee { get; set; }
        public string o_refundFee { get; set; }
        public string o_fee { get; set; }
        public string o_originFee { get; set; }
        public string o_installFee { get; set; }
        public string o_remainInstallFee { get; set; }
        public string o_finishFee { get; set; }
        public string o_paidFee { get; set; }
        public string o_payAdvance { get; set; }
        public string o_agreementNo { get; set; }
        public string o_agreementId { get; set; }
        public string o_payGuarantee { get; set; }
        public string o_paySettlement { get; set; }
        public string o_remainAdvance { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseTypeName { get; set; }
        public string SupplierName { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseIOCode { get; set; }
        public string WarehouseIOTypeName { get; set; }
        public string WarehouseIOStatusName { get; set; }
        public string Consignee { get; set; }
        public string ConsigneePhone { get; set; }
        public string ConsigneeAddress { get; set; }
        public Nullable<int> ConsigneeCityID { get; set; }
        public string ConsigneeCity { get; set; }
        public string Memo { get; set; }
        public string ExpectionMemo { get; set; }
        public Nullable<System.DateTime> WarehouseConfirmDate { get; set; }
        public string o_shopOrderId { get; set; }
        public string openShopOrderStatusName { get; set; }
        public string task_info { get; set; }
    }
}