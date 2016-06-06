﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace MaplinkTest.MaplinkAuth {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AuthenticationSoap", Namespace="http://webservices.maplink2.com.br")]
    public partial class Authentication : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getTokenOperationCompleted;
        
        private System.Threading.SendOrPostCallback validateTokenOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Authentication() {
            this.Url = global::MaplinkTest.Properties.Settings.Default.MaplinkTest_MaplinkAuth_Authentication;
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
        public event getTokenCompletedEventHandler getTokenCompleted;
        
        /// <remarks/>
        public event validateTokenCompletedEventHandler validateTokenCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://webservices.maplink2.com.br/getToken", RequestNamespace="http://webservices.maplink2.com.br", ResponseNamespace="http://webservices.maplink2.com.br", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getToken(string user, string pwd) {
            object[] results = this.Invoke("getToken", new object[] {
                        user,
                        pwd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTokenAsync(string user, string pwd) {
            this.getTokenAsync(user, pwd, null);
        }
        
        /// <remarks/>
        public void getTokenAsync(string user, string pwd, object userState) {
            if ((this.getTokenOperationCompleted == null)) {
                this.getTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTokenOperationCompleted);
            }
            this.InvokeAsync("getToken", new object[] {
                        user,
                        pwd}, this.getTokenOperationCompleted, userState);
        }
        
        private void OngetTokenOperationCompleted(object arg) {
            if ((this.getTokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTokenCompleted(this, new getTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://webservices.maplink2.com.br/validateToken", RequestNamespace="http://webservices.maplink2.com.br", ResponseNamespace="http://webservices.maplink2.com.br", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TokenValidated validateToken(string token, string productId) {
            object[] results = this.Invoke("validateToken", new object[] {
                        token,
                        productId});
            return ((TokenValidated)(results[0]));
        }
        
        /// <remarks/>
        public void validateTokenAsync(string token, string productId) {
            this.validateTokenAsync(token, productId, null);
        }
        
        /// <remarks/>
        public void validateTokenAsync(string token, string productId, object userState) {
            if ((this.validateTokenOperationCompleted == null)) {
                this.validateTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnvalidateTokenOperationCompleted);
            }
            this.InvokeAsync("validateToken", new object[] {
                        token,
                        productId}, this.validateTokenOperationCompleted, userState);
        }
        
        private void OnvalidateTokenOperationCompleted(object arg) {
            if ((this.validateTokenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.validateTokenCompleted(this, new validateTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.maplink2.com.br")]
    public partial class TokenValidated {
        
        private int idField;
        
        private int statusField;
        
        private string contratoField;
        
        private string tokenField;
        
        private string userField;
        
        private string passField;
        
        private string googleKeyField;
        
        private int clientTypeField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string contrato {
            get {
                return this.contratoField;
            }
            set {
                this.contratoField = value;
            }
        }
        
        /// <remarks/>
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
            }
        }
        
        /// <remarks/>
        public string googleKey {
            get {
                return this.googleKeyField;
            }
            set {
                this.googleKeyField = value;
            }
        }
        
        /// <remarks/>
        public int clientType {
            get {
                return this.clientTypeField;
            }
            set {
                this.clientTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getTokenCompletedEventHandler(object sender, getTokenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void validateTokenCompletedEventHandler(object sender, validateTokenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class validateTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal validateTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TokenValidated Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TokenValidated)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591