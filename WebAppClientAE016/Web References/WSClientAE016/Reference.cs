﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebAppClientAE016.WSClientAE016 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_Client_Invoice_AE016Soap", Namespace="http://WS_Client_Invoice_AE016/")]
    public partial class WS_Client_Invoice_AE016 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CustomersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_Client_Invoice_AE016() {
            this.Url = global::WebAppClientAE016.Properties.Settings.Default.WebAppClientAE016_WSClientAE016_WS_Client_Invoice_AE016;
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
        public event CustomersCompletedEventHandler CustomersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://WS_Client_Invoice_AE016/Customers", RequestNamespace="http://WS_Client_Invoice_AE016/", ResponseNamespace="http://WS_Client_Invoice_AE016/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Customers(string Id, string Name, string Adress, string Age, string Phone, string NIE, string Opc, bool Status) {
            object[] results = this.Invoke("Customers", new object[] {
                        Id,
                        Name,
                        Adress,
                        Age,
                        Phone,
                        NIE,
                        Opc,
                        Status});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void CustomersAsync(string Id, string Name, string Adress, string Age, string Phone, string NIE, string Opc, bool Status) {
            this.CustomersAsync(Id, Name, Adress, Age, Phone, NIE, Opc, Status, null);
        }
        
        /// <remarks/>
        public void CustomersAsync(string Id, string Name, string Adress, string Age, string Phone, string NIE, string Opc, bool Status, object userState) {
            if ((this.CustomersOperationCompleted == null)) {
                this.CustomersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCustomersOperationCompleted);
            }
            this.InvokeAsync("Customers", new object[] {
                        Id,
                        Name,
                        Adress,
                        Age,
                        Phone,
                        NIE,
                        Opc,
                        Status}, this.CustomersOperationCompleted, userState);
        }
        
        private void OnCustomersOperationCompleted(object arg) {
            if ((this.CustomersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CustomersCompleted(this, new CustomersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CustomersCompletedEventHandler(object sender, CustomersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CustomersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CustomersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591