﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace ISCommon.LicenseManagerService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LicenseManagerSoap", Namespace="http://tempuri.org/")]
    public partial class LicenseManager : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback checkKeyOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkTrialOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkMacTrialOperationCompleted;
        
        private System.Threading.SendOrPostCallback activeKeyOperationCompleted;
        
        private System.Threading.SendOrPostCallback activeTrialOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTrialOperationCompleted;
        
        private System.Threading.SendOrPostCallback getLicenseOperationCompleted;
        
        private System.Threading.SendOrPostCallback getInfoServerOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LicenseManager() {
            this.Url = global::ISCommon.Properties.Settings.Default.ISCommon_LicenseManagerService_LicenseManager;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event checkKeyCompletedEventHandler checkKeyCompleted;
        
        /// <remarks/>
        public event checkTrialCompletedEventHandler checkTrialCompleted;
        
        /// <remarks/>
        public event checkMacTrialCompletedEventHandler checkMacTrialCompleted;
        
        /// <remarks/>
        public event activeKeyCompletedEventHandler activeKeyCompleted;
        
        /// <remarks/>
        public event activeTrialCompletedEventHandler activeTrialCompleted;
        
        /// <remarks/>
        public event getTrialCompletedEventHandler getTrialCompleted;
        
        /// <remarks/>
        public event getLicenseCompletedEventHandler getLicenseCompleted;
        
        /// <remarks/>
        public event getInfoServerCompletedEventHandler getInfoServerCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkKey", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkKey(string macAddress) {
            object[] results = this.Invoke("checkKey", new object[] {
                        macAddress});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkKeyAsync(string macAddress) {
            this.checkKeyAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void checkKeyAsync(string macAddress, object userState) {
            if ((this.checkKeyOperationCompleted == null)) {
                this.checkKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckKeyOperationCompleted);
            }
            this.InvokeAsync("checkKey", new object[] {
                        macAddress}, this.checkKeyOperationCompleted, userState);
        }
        
        private void OncheckKeyOperationCompleted(object arg) {
            if ((this.checkKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkKeyCompleted(this, new checkKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkTrial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkTrial(string macAddress) {
            object[] results = this.Invoke("checkTrial", new object[] {
                        macAddress});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkTrialAsync(string macAddress) {
            this.checkTrialAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void checkTrialAsync(string macAddress, object userState) {
            if ((this.checkTrialOperationCompleted == null)) {
                this.checkTrialOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckTrialOperationCompleted);
            }
            this.InvokeAsync("checkTrial", new object[] {
                        macAddress}, this.checkTrialOperationCompleted, userState);
        }
        
        private void OncheckTrialOperationCompleted(object arg) {
            if ((this.checkTrialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkTrialCompleted(this, new checkTrialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/checkMacTrial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool checkMacTrial(string macAddress) {
            object[] results = this.Invoke("checkMacTrial", new object[] {
                        macAddress});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void checkMacTrialAsync(string macAddress) {
            this.checkMacTrialAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void checkMacTrialAsync(string macAddress, object userState) {
            if ((this.checkMacTrialOperationCompleted == null)) {
                this.checkMacTrialOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckMacTrialOperationCompleted);
            }
            this.InvokeAsync("checkMacTrial", new object[] {
                        macAddress}, this.checkMacTrialOperationCompleted, userState);
        }
        
        private void OncheckMacTrialOperationCompleted(object arg) {
            if ((this.checkMacTrialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkMacTrialCompleted(this, new checkMacTrialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/activeKey", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool activeKey(string macAddress, string company, string key) {
            object[] results = this.Invoke("activeKey", new object[] {
                        macAddress,
                        company,
                        key});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void activeKeyAsync(string macAddress, string company, string key) {
            this.activeKeyAsync(macAddress, company, key, null);
        }
        
        /// <remarks/>
        public void activeKeyAsync(string macAddress, string company, string key, object userState) {
            if ((this.activeKeyOperationCompleted == null)) {
                this.activeKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnactiveKeyOperationCompleted);
            }
            this.InvokeAsync("activeKey", new object[] {
                        macAddress,
                        company,
                        key}, this.activeKeyOperationCompleted, userState);
        }
        
        private void OnactiveKeyOperationCompleted(object arg) {
            if ((this.activeKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.activeKeyCompleted(this, new activeKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/activeTrial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool activeTrial(string macAddress, string company, string email, string phone) {
            object[] results = this.Invoke("activeTrial", new object[] {
                        macAddress,
                        company,
                        email,
                        phone});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void activeTrialAsync(string macAddress, string company, string email, string phone) {
            this.activeTrialAsync(macAddress, company, email, phone, null);
        }
        
        /// <remarks/>
        public void activeTrialAsync(string macAddress, string company, string email, string phone, object userState) {
            if ((this.activeTrialOperationCompleted == null)) {
                this.activeTrialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnactiveTrialOperationCompleted);
            }
            this.InvokeAsync("activeTrial", new object[] {
                        macAddress,
                        company,
                        email,
                        phone}, this.activeTrialOperationCompleted, userState);
        }
        
        private void OnactiveTrialOperationCompleted(object arg) {
            if ((this.activeTrialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.activeTrialCompleted(this, new activeTrialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getTrial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CTrial getTrial(string macAddress) {
            object[] results = this.Invoke("getTrial", new object[] {
                        macAddress});
            return ((CTrial)(results[0]));
        }
        
        /// <remarks/>
        public void getTrialAsync(string macAddress) {
            this.getTrialAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void getTrialAsync(string macAddress, object userState) {
            if ((this.getTrialOperationCompleted == null)) {
                this.getTrialOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTrialOperationCompleted);
            }
            this.InvokeAsync("getTrial", new object[] {
                        macAddress}, this.getTrialOperationCompleted, userState);
        }
        
        private void OngetTrialOperationCompleted(object arg) {
            if ((this.getTrialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTrialCompleted(this, new getTrialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getLicense", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CLicense getLicense(string macAddress) {
            object[] results = this.Invoke("getLicense", new object[] {
                        macAddress});
            return ((CLicense)(results[0]));
        }
        
        /// <remarks/>
        public void getLicenseAsync(string macAddress) {
            this.getLicenseAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void getLicenseAsync(string macAddress, object userState) {
            if ((this.getLicenseOperationCompleted == null)) {
                this.getLicenseOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLicenseOperationCompleted);
            }
            this.InvokeAsync("getLicense", new object[] {
                        macAddress}, this.getLicenseOperationCompleted, userState);
        }
        
        private void OngetLicenseOperationCompleted(object arg) {
            if ((this.getLicenseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLicenseCompleted(this, new getLicenseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getInfoServer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DB_ISALARY getInfoServer(string macAddress) {
            object[] results = this.Invoke("getInfoServer", new object[] {
                        macAddress});
            return ((DB_ISALARY)(results[0]));
        }
        
        /// <remarks/>
        public void getInfoServerAsync(string macAddress) {
            this.getInfoServerAsync(macAddress, null);
        }
        
        /// <remarks/>
        public void getInfoServerAsync(string macAddress, object userState) {
            if ((this.getInfoServerOperationCompleted == null)) {
                this.getInfoServerOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInfoServerOperationCompleted);
            }
            this.InvokeAsync("getInfoServer", new object[] {
                        macAddress}, this.getInfoServerOperationCompleted, userState);
        }
        
        private void OngetInfoServerOperationCompleted(object arg) {
            if ((this.getInfoServerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInfoServerCompleted(this, new getInfoServerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CTrial {
        
        private string eMAILField;
        
        private string pHONEField;
        
        private System.DateTime tRAIL_TIMEField;
        
        private System.DateTime eXPIRY_DATEField;
        
        private string cOMPANYField;
        
        /// <remarks/>
        public string EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
            }
        }
        
        /// <remarks/>
        public string PHONE {
            get {
                return this.pHONEField;
            }
            set {
                this.pHONEField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TRAIL_TIME {
            get {
                return this.tRAIL_TIMEField;
            }
            set {
                this.tRAIL_TIMEField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EXPIRY_DATE {
            get {
                return this.eXPIRY_DATEField;
            }
            set {
                this.eXPIRY_DATEField = value;
            }
        }
        
        /// <remarks/>
        public string COMPANY {
            get {
                return this.cOMPANYField;
            }
            set {
                this.cOMPANYField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class DB_ISALARY {
        
        private int idField;
        
        private string dBNAMEField;
        
        private string uSERNAMEField;
        
        private string pASSWORDField;
        
        private System.DateTime cREATE_TIMEField;
        
        private string cOMPANYField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string DBNAME {
            get {
                return this.dBNAMEField;
            }
            set {
                this.dBNAMEField = value;
            }
        }
        
        /// <remarks/>
        public string USERNAME {
            get {
                return this.uSERNAMEField;
            }
            set {
                this.uSERNAMEField = value;
            }
        }
        
        /// <remarks/>
        public string PASSWORD {
            get {
                return this.pASSWORDField;
            }
            set {
                this.pASSWORDField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CREATE_TIME {
            get {
                return this.cREATE_TIMEField;
            }
            set {
                this.cREATE_TIMEField = value;
            }
        }
        
        /// <remarks/>
        public string COMPANY {
            get {
                return this.cOMPANYField;
            }
            set {
                this.cOMPANYField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CLicense {
        
        private string cOMPANYField;
        
        private System.DateTime cREATE_TIMEField;
        
        private System.DateTime eXPIRY_DATEField;
        
        /// <remarks/>
        public string COMPANY {
            get {
                return this.cOMPANYField;
            }
            set {
                this.cOMPANYField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CREATE_TIME {
            get {
                return this.cREATE_TIMEField;
            }
            set {
                this.cREATE_TIMEField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EXPIRY_DATE {
            get {
                return this.eXPIRY_DATEField;
            }
            set {
                this.eXPIRY_DATEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkKeyCompletedEventHandler(object sender, checkKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkTrialCompletedEventHandler(object sender, checkTrialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkTrialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkTrialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void checkMacTrialCompletedEventHandler(object sender, checkMacTrialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkMacTrialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkMacTrialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void activeKeyCompletedEventHandler(object sender, activeKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class activeKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal activeKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void activeTrialCompletedEventHandler(object sender, activeTrialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class activeTrialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal activeTrialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getTrialCompletedEventHandler(object sender, getTrialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTrialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTrialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CTrial Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CTrial)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getLicenseCompletedEventHandler(object sender, getLicenseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLicenseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLicenseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CLicense Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CLicense)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getInfoServerCompletedEventHandler(object sender, getInfoServerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInfoServerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getInfoServerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DB_ISALARY Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DB_ISALARY)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591