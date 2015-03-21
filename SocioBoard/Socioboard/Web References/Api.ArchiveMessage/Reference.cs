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

namespace Socioboard.Api.ArchiveMessage {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ArchiveMessageSoap", Namespace="http://tempuri.org/")]
    public partial class ArchiveMessage : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddArchiveMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckArchiveMessageExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteArchiveMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllArchiveMessagesDetailsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ArchiveMessage() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_ArchiveMessage_ArchiveMessage;
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
        public event AddArchiveMessageCompletedEventHandler AddArchiveMessageCompleted;
        
        /// <remarks/>
        public event CheckArchiveMessageExistsCompletedEventHandler CheckArchiveMessageExistsCompleted;
        
        /// <remarks/>
        public event DeleteArchiveMessageCompletedEventHandler DeleteArchiveMessageCompleted;
        
        /// <remarks/>
        public event GetAllArchiveMessagesDetailsCompletedEventHandler GetAllArchiveMessagesDetailsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddArchiveMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddArchiveMessage(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl) {
            this.Invoke("AddArchiveMessage", new object[] {
                        UserId,
                        ProfileId,
                        SocialGroup,
                        UserName,
                        MessageId,
                        Message,
                        CreatedDateTime,
                        ImgUrl});
        }
        
        /// <remarks/>
        public void AddArchiveMessageAsync(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl) {
            this.AddArchiveMessageAsync(UserId, ProfileId, SocialGroup, UserName, MessageId, Message, CreatedDateTime, ImgUrl, null);
        }
        
        /// <remarks/>
        public void AddArchiveMessageAsync(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl, object userState) {
            if ((this.AddArchiveMessageOperationCompleted == null)) {
                this.AddArchiveMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddArchiveMessageOperationCompleted);
            }
            this.InvokeAsync("AddArchiveMessage", new object[] {
                        UserId,
                        ProfileId,
                        SocialGroup,
                        UserName,
                        MessageId,
                        Message,
                        CreatedDateTime,
                        ImgUrl}, this.AddArchiveMessageOperationCompleted, userState);
        }
        
        private void OnAddArchiveMessageOperationCompleted(object arg) {
            if ((this.AddArchiveMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddArchiveMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckArchiveMessageExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckArchiveMessageExists(string userid, string messageid) {
            object[] results = this.Invoke("CheckArchiveMessageExists", new object[] {
                        userid,
                        messageid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckArchiveMessageExistsAsync(string userid, string messageid) {
            this.CheckArchiveMessageExistsAsync(userid, messageid, null);
        }
        
        /// <remarks/>
        public void CheckArchiveMessageExistsAsync(string userid, string messageid, object userState) {
            if ((this.CheckArchiveMessageExistsOperationCompleted == null)) {
                this.CheckArchiveMessageExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckArchiveMessageExistsOperationCompleted);
            }
            this.InvokeAsync("CheckArchiveMessageExists", new object[] {
                        userid,
                        messageid}, this.CheckArchiveMessageExistsOperationCompleted, userState);
        }
        
        private void OnCheckArchiveMessageExistsOperationCompleted(object arg) {
            if ((this.CheckArchiveMessageExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckArchiveMessageExistsCompleted(this, new CheckArchiveMessageExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteArchiveMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteArchiveMessage(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl) {
            this.Invoke("DeleteArchiveMessage", new object[] {
                        UserId,
                        ProfileId,
                        SocialGroup,
                        UserName,
                        MessageId,
                        Message,
                        CreatedDateTime,
                        ImgUrl});
        }
        
        /// <remarks/>
        public void DeleteArchiveMessageAsync(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl) {
            this.DeleteArchiveMessageAsync(UserId, ProfileId, SocialGroup, UserName, MessageId, Message, CreatedDateTime, ImgUrl, null);
        }
        
        /// <remarks/>
        public void DeleteArchiveMessageAsync(string UserId, string ProfileId, string SocialGroup, string UserName, string MessageId, string Message, string CreatedDateTime, string ImgUrl, object userState) {
            if ((this.DeleteArchiveMessageOperationCompleted == null)) {
                this.DeleteArchiveMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteArchiveMessageOperationCompleted);
            }
            this.InvokeAsync("DeleteArchiveMessage", new object[] {
                        UserId,
                        ProfileId,
                        SocialGroup,
                        UserName,
                        MessageId,
                        Message,
                        CreatedDateTime,
                        ImgUrl}, this.DeleteArchiveMessageOperationCompleted, userState);
        }
        
        private void OnDeleteArchiveMessageOperationCompleted(object arg) {
            if ((this.DeleteArchiveMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteArchiveMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllArchiveMessagesDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllArchiveMessagesDetails(string userid, string profileid) {
            object[] results = this.Invoke("GetAllArchiveMessagesDetails", new object[] {
                        userid,
                        profileid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllArchiveMessagesDetailsAsync(string userid, string profileid) {
            this.GetAllArchiveMessagesDetailsAsync(userid, profileid, null);
        }
        
        /// <remarks/>
        public void GetAllArchiveMessagesDetailsAsync(string userid, string profileid, object userState) {
            if ((this.GetAllArchiveMessagesDetailsOperationCompleted == null)) {
                this.GetAllArchiveMessagesDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllArchiveMessagesDetailsOperationCompleted);
            }
            this.InvokeAsync("GetAllArchiveMessagesDetails", new object[] {
                        userid,
                        profileid}, this.GetAllArchiveMessagesDetailsOperationCompleted, userState);
        }
        
        private void OnGetAllArchiveMessagesDetailsOperationCompleted(object arg) {
            if ((this.GetAllArchiveMessagesDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllArchiveMessagesDetailsCompleted(this, new GetAllArchiveMessagesDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void AddArchiveMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void CheckArchiveMessageExistsCompletedEventHandler(object sender, CheckArchiveMessageExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckArchiveMessageExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckArchiveMessageExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void DeleteArchiveMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void GetAllArchiveMessagesDetailsCompletedEventHandler(object sender, GetAllArchiveMessagesDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllArchiveMessagesDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllArchiveMessagesDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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