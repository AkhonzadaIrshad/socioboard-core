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

namespace Socioboard.Api.GroupProfile {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="GroupProfileSoap", Namespace="http://tempuri.org/")]
    public partial class GroupProfile : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllProfilesConnectedWithGroupOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddProfileToGroupOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteProfileFromGroupOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GroupProfile() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_GroupProfile_GroupProfile;
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
        public event GetAllProfilesConnectedWithGroupCompletedEventHandler GetAllProfilesConnectedWithGroupCompleted;
        
        /// <remarks/>
        public event AddProfileToGroupCompletedEventHandler AddProfileToGroupCompleted;
        
        /// <remarks/>
        public event DeleteProfileFromGroupCompletedEventHandler DeleteProfileFromGroupCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllProfilesConnectedWithGroup", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllProfilesConnectedWithGroup(string UserId, string GroupId) {
            object[] results = this.Invoke("GetAllProfilesConnectedWithGroup", new object[] {
                        UserId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllProfilesConnectedWithGroupAsync(string UserId, string GroupId) {
            this.GetAllProfilesConnectedWithGroupAsync(UserId, GroupId, null);
        }
        
        /// <remarks/>
        public void GetAllProfilesConnectedWithGroupAsync(string UserId, string GroupId, object userState) {
            if ((this.GetAllProfilesConnectedWithGroupOperationCompleted == null)) {
                this.GetAllProfilesConnectedWithGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllProfilesConnectedWithGroupOperationCompleted);
            }
            this.InvokeAsync("GetAllProfilesConnectedWithGroup", new object[] {
                        UserId,
                        GroupId}, this.GetAllProfilesConnectedWithGroupOperationCompleted, userState);
        }
        
        private void OnGetAllProfilesConnectedWithGroupOperationCompleted(object arg) {
            if ((this.GetAllProfilesConnectedWithGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllProfilesConnectedWithGroupCompleted(this, new GetAllProfilesConnectedWithGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddProfileToGroup", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddProfileToGroup(string profileid, string network, string groupid, string userid) {
            object[] results = this.Invoke("AddProfileToGroup", new object[] {
                        profileid,
                        network,
                        groupid,
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddProfileToGroupAsync(string profileid, string network, string groupid, string userid) {
            this.AddProfileToGroupAsync(profileid, network, groupid, userid, null);
        }
        
        /// <remarks/>
        public void AddProfileToGroupAsync(string profileid, string network, string groupid, string userid, object userState) {
            if ((this.AddProfileToGroupOperationCompleted == null)) {
                this.AddProfileToGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddProfileToGroupOperationCompleted);
            }
            this.InvokeAsync("AddProfileToGroup", new object[] {
                        profileid,
                        network,
                        groupid,
                        userid}, this.AddProfileToGroupOperationCompleted, userState);
        }
        
        private void OnAddProfileToGroupOperationCompleted(object arg) {
            if ((this.AddProfileToGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddProfileToGroupCompleted(this, new AddProfileToGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteProfileFromGroup", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteProfileFromGroup(string profileid, string groupid, string userid) {
            object[] results = this.Invoke("DeleteProfileFromGroup", new object[] {
                        profileid,
                        groupid,
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteProfileFromGroupAsync(string profileid, string groupid, string userid) {
            this.DeleteProfileFromGroupAsync(profileid, groupid, userid, null);
        }
        
        /// <remarks/>
        public void DeleteProfileFromGroupAsync(string profileid, string groupid, string userid, object userState) {
            if ((this.DeleteProfileFromGroupOperationCompleted == null)) {
                this.DeleteProfileFromGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteProfileFromGroupOperationCompleted);
            }
            this.InvokeAsync("DeleteProfileFromGroup", new object[] {
                        profileid,
                        groupid,
                        userid}, this.DeleteProfileFromGroupOperationCompleted, userState);
        }
        
        private void OnDeleteProfileFromGroupOperationCompleted(object arg) {
            if ((this.DeleteProfileFromGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteProfileFromGroupCompleted(this, new DeleteProfileFromGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetAllProfilesConnectedWithGroupCompletedEventHandler(object sender, GetAllProfilesConnectedWithGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllProfilesConnectedWithGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllProfilesConnectedWithGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void AddProfileToGroupCompletedEventHandler(object sender, AddProfileToGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddProfileToGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddProfileToGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteProfileFromGroupCompletedEventHandler(object sender, DeleteProfileFromGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteProfileFromGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteProfileFromGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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