﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18408.
// 
#pragma warning disable 1591

namespace Socioboard.Api.TwitterAccount {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TwitterAccountSoap", Namespace="http://tempuri.org/")]
    public partial class TwitterAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTwitterAccountDetailsByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteTwitterAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllTwitterAccountsOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllAccountDetailsByProfileIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTwitterAccountsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TwitterAccount() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TwitterAccount_TwitterAccount;
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
        public event GetTwitterAccountDetailsByIdCompletedEventHandler GetTwitterAccountDetailsByIdCompleted;
        
        /// <remarks/>
        public event DeleteTwitterAccountCompletedEventHandler DeleteTwitterAccountCompleted;
        
        /// <remarks/>
        public event getAllTwitterAccountsOfUserCompletedEventHandler getAllTwitterAccountsOfUserCompleted;
        
        /// <remarks/>
        public event GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventHandler GetAllTwitterAccountsByUserIdAndGroupIdCompleted;
        
        /// <remarks/>
        public event GetAllAccountDetailsByProfileIdCompletedEventHandler GetAllAccountDetailsByProfileIdCompleted;
        
        /// <remarks/>
        public event getUserInformationCompletedEventHandler getUserInformationCompleted;
        
        /// <remarks/>
        public event GetAllTwitterAccountsCompletedEventHandler GetAllTwitterAccountsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterAccountDetailsById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterAccountDetailsById(string UserId, string ProfileId) {
            object[] results = this.Invoke("GetTwitterAccountDetailsById", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterAccountDetailsByIdAsync(string UserId, string ProfileId) {
            this.GetTwitterAccountDetailsByIdAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void GetTwitterAccountDetailsByIdAsync(string UserId, string ProfileId, object userState) {
            if ((this.GetTwitterAccountDetailsByIdOperationCompleted == null)) {
                this.GetTwitterAccountDetailsByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterAccountDetailsByIdOperationCompleted);
            }
            this.InvokeAsync("GetTwitterAccountDetailsById", new object[] {
                        UserId,
                        ProfileId}, this.GetTwitterAccountDetailsByIdOperationCompleted, userState);
        }
        
        private void OnGetTwitterAccountDetailsByIdOperationCompleted(object arg) {
            if ((this.GetTwitterAccountDetailsByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterAccountDetailsByIdCompleted(this, new GetTwitterAccountDetailsByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteTwitterAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteTwitterAccount(string UserId, string ProfileId, string GroupId) {
            object[] results = this.Invoke("DeleteTwitterAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteTwitterAccountAsync(string UserId, string ProfileId, string GroupId) {
            this.DeleteTwitterAccountAsync(UserId, ProfileId, GroupId, null);
        }
        
        /// <remarks/>
        public void DeleteTwitterAccountAsync(string UserId, string ProfileId, string GroupId, object userState) {
            if ((this.DeleteTwitterAccountOperationCompleted == null)) {
                this.DeleteTwitterAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteTwitterAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteTwitterAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId}, this.DeleteTwitterAccountOperationCompleted, userState);
        }
        
        private void OnDeleteTwitterAccountOperationCompleted(object arg) {
            if ((this.DeleteTwitterAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteTwitterAccountCompleted(this, new DeleteTwitterAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllTwitterAccountsOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllTwitterAccountsOfUser(string UserId) {
            object[] results = this.Invoke("getAllTwitterAccountsOfUser", new object[] {
                        UserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllTwitterAccountsOfUserAsync(string UserId) {
            this.getAllTwitterAccountsOfUserAsync(UserId, null);
        }
        
        /// <remarks/>
        public void getAllTwitterAccountsOfUserAsync(string UserId, object userState) {
            if ((this.getAllTwitterAccountsOfUserOperationCompleted == null)) {
                this.getAllTwitterAccountsOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllTwitterAccountsOfUserOperationCompleted);
            }
            this.InvokeAsync("getAllTwitterAccountsOfUser", new object[] {
                        UserId}, this.getAllTwitterAccountsOfUserOperationCompleted, userState);
        }
        
        private void OngetAllTwitterAccountsOfUserOperationCompleted(object arg) {
            if ((this.getAllTwitterAccountsOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllTwitterAccountsOfUserCompleted(this, new getAllTwitterAccountsOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTwitterAccountsByUserIdAndGroupId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTwitterAccountsByUserIdAndGroupId(string userid, string groupid) {
            object[] results = this.Invoke("GetAllTwitterAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTwitterAccountsByUserIdAndGroupIdAsync(string userid, string groupid) {
            this.GetAllTwitterAccountsByUserIdAndGroupIdAsync(userid, groupid, null);
        }
        
        /// <remarks/>
        public void GetAllTwitterAccountsByUserIdAndGroupIdAsync(string userid, string groupid, object userState) {
            if ((this.GetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted == null)) {
                this.GetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted);
            }
            this.InvokeAsync("GetAllTwitterAccountsByUserIdAndGroupId", new object[] {
                        userid,
                        groupid}, this.GetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted, userState);
        }
        
        private void OnGetAllTwitterAccountsByUserIdAndGroupIdOperationCompleted(object arg) {
            if ((this.GetAllTwitterAccountsByUserIdAndGroupIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTwitterAccountsByUserIdAndGroupIdCompleted(this, new GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllAccountDetailsByProfileId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllAccountDetailsByProfileId(string profileid, string userid) {
            object[] results = this.Invoke("GetAllAccountDetailsByProfileId", new object[] {
                        profileid,
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllAccountDetailsByProfileIdAsync(string profileid, string userid) {
            this.GetAllAccountDetailsByProfileIdAsync(profileid, userid, null);
        }
        
        /// <remarks/>
        public void GetAllAccountDetailsByProfileIdAsync(string profileid, string userid, object userState) {
            if ((this.GetAllAccountDetailsByProfileIdOperationCompleted == null)) {
                this.GetAllAccountDetailsByProfileIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllAccountDetailsByProfileIdOperationCompleted);
            }
            this.InvokeAsync("GetAllAccountDetailsByProfileId", new object[] {
                        profileid,
                        userid}, this.GetAllAccountDetailsByProfileIdOperationCompleted, userState);
        }
        
        private void OnGetAllAccountDetailsByProfileIdOperationCompleted(object arg) {
            if ((this.GetAllAccountDetailsByProfileIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllAccountDetailsByProfileIdCompleted(this, new GetAllAccountDetailsByProfileIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getUserInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getUserInformation(string TwtUserId) {
            object[] results = this.Invoke("getUserInformation", new object[] {
                        TwtUserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUserInformationAsync(string TwtUserId) {
            this.getUserInformationAsync(TwtUserId, null);
        }
        
        /// <remarks/>
        public void getUserInformationAsync(string TwtUserId, object userState) {
            if ((this.getUserInformationOperationCompleted == null)) {
                this.getUserInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserInformationOperationCompleted);
            }
            this.InvokeAsync("getUserInformation", new object[] {
                        TwtUserId}, this.getUserInformationOperationCompleted, userState);
        }
        
        private void OngetUserInformationOperationCompleted(object arg) {
            if ((this.getUserInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserInformationCompleted(this, new getUserInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTwitterAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTwitterAccounts() {
            object[] results = this.Invoke("GetAllTwitterAccounts", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTwitterAccountsAsync() {
            this.GetAllTwitterAccountsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllTwitterAccountsAsync(object userState) {
            if ((this.GetAllTwitterAccountsOperationCompleted == null)) {
                this.GetAllTwitterAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTwitterAccountsOperationCompleted);
            }
            this.InvokeAsync("GetAllTwitterAccounts", new object[0], this.GetAllTwitterAccountsOperationCompleted, userState);
        }
        
        private void OnGetAllTwitterAccountsOperationCompleted(object arg) {
            if ((this.GetAllTwitterAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTwitterAccountsCompleted(this, new GetAllTwitterAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetTwitterAccountDetailsByIdCompletedEventHandler(object sender, GetTwitterAccountDetailsByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterAccountDetailsByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterAccountDetailsByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DeleteTwitterAccountCompletedEventHandler(object sender, DeleteTwitterAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteTwitterAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteTwitterAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getAllTwitterAccountsOfUserCompletedEventHandler(object sender, getAllTwitterAccountsOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllTwitterAccountsOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllTwitterAccountsOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventHandler(object sender, GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTwitterAccountsByUserIdAndGroupIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAllAccountDetailsByProfileIdCompletedEventHandler(object sender, GetAllAccountDetailsByProfileIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllAccountDetailsByProfileIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllAccountDetailsByProfileIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getUserInformationCompletedEventHandler(object sender, getUserInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAllTwitterAccountsCompletedEventHandler(object sender, GetAllTwitterAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTwitterAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTwitterAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591