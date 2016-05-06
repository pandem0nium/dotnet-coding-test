﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDo.MVC.ToDoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ToDoItemContract", Namespace="http://schemas.datacontract.org/2004/07/ToDo.WCF.Contract")]
    [System.SerializableAttribute()]
    public partial class ToDoItemContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CompleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Complete {
            get {
                return this.CompleteField;
            }
            set {
                if ((this.CompleteField.Equals(value) != true)) {
                    this.CompleteField = value;
                    this.RaisePropertyChanged("Complete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ToDoService.IToDoService")]
    public interface IToDoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDoService/GetToDoItems", ReplyAction="http://tempuri.org/IToDoService/GetToDoItemsResponse")]
        ToDo.MVC.ToDoService.ToDoItemContract[] GetToDoItems(string idFilter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToDoService/SaveToDoItem", ReplyAction="http://tempuri.org/IToDoService/SaveToDoItemResponse")]
        string SaveToDoItem(ToDo.MVC.ToDoService.ToDoItemContract toDoItem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToDoServiceChannel : ToDo.MVC.ToDoService.IToDoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToDoServiceClient : System.ServiceModel.ClientBase<ToDo.MVC.ToDoService.IToDoService>, ToDo.MVC.ToDoService.IToDoService {
        
        public ToDoServiceClient() {
        }
        
        public ToDoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToDoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToDoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToDoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ToDo.MVC.ToDoService.ToDoItemContract[] GetToDoItems(string idFilter) {
            return base.Channel.GetToDoItems(idFilter);
        }
        
        public string SaveToDoItem(ToDo.MVC.ToDoService.ToDoItemContract toDoItem) {
            return base.Channel.SaveToDoItem(toDoItem);
        }
    }
}
