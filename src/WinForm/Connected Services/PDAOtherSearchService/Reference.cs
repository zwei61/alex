﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForm.PDAOtherSearchService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PDAOtherSearchService.OtherSearchServiceSoap")]
    public interface OtherSearchServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Execup_SelStoragePDA", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseM))]
        System.Data.DataTable Execup_SelStoragePDA(WinForm.PDAOtherSearchService.OtherSearchM model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Execup_SelStoragePDA", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Execup_SelStoragePDAAsync(WinForm.PDAOtherSearchService.OtherSearchM model);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class OtherSearchM : BaseM {
        
        private string sqlWhereField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SqlWhere {
            get {
                return this.sqlWhereField;
            }
            set {
                this.sqlWhereField = value;
                this.RaisePropertyChanged("SqlWhere");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSearchM))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseM : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string warehouseNameField;
        
        private int warehouseIdField;
        
        private string keyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string WarehouseName {
            get {
                return this.warehouseNameField;
            }
            set {
                this.warehouseNameField = value;
                this.RaisePropertyChanged("WarehouseName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int WarehouseId {
            get {
                return this.warehouseIdField;
            }
            set {
                this.warehouseIdField = value;
                this.RaisePropertyChanged("WarehouseId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("Key");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OtherSearchServiceSoapChannel : WinForm.PDAOtherSearchService.OtherSearchServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OtherSearchServiceSoapClient : System.ServiceModel.ClientBase<WinForm.PDAOtherSearchService.OtherSearchServiceSoap>, WinForm.PDAOtherSearchService.OtherSearchServiceSoap {
        
        public OtherSearchServiceSoapClient() {
        }
        
        public OtherSearchServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OtherSearchServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OtherSearchServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OtherSearchServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable Execup_SelStoragePDA(WinForm.PDAOtherSearchService.OtherSearchM model) {
            return base.Channel.Execup_SelStoragePDA(model);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Execup_SelStoragePDAAsync(WinForm.PDAOtherSearchService.OtherSearchM model) {
            return base.Channel.Execup_SelStoragePDAAsync(model);
        }
    }
}
