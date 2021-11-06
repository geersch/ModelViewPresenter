﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 9/12/2008 14:32:32
namespace Database
{
    
    /// <summary>
    /// There are no comments for SouthwindEntities in the schema.
    /// </summary>
    public partial class SouthwindEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new SouthwindEntities object using the connection string found in the 'SouthwindEntities' section of the application configuration file.
        /// </summary>
        public SouthwindEntities() : 
                base("name=SouthwindEntities", "SouthwindEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SouthwindEntities object.
        /// </summary>
        public SouthwindEntities(string connectionString) : 
                base(connectionString, "SouthwindEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new SouthwindEntities object.
        /// </summary>
        public SouthwindEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "SouthwindEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Customer> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<Customer>("[Customers]");
                }
                return this._Customers;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Customer> _Customers;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    }
    /// <summary>
    /// There are no comments for SouthwindModel.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="SouthwindModel", Name="Customer")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Customer : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="firstname">Initial value of Firstname.</param>
        /// <param name="lastname">Initial value of Lastname.</param>
        public static Customer CreateCustomer(global::System.Guid id, string firstname, string lastname)
        {
            Customer customer = new Customer();
            customer.Id = id;
            customer.Firstname = firstname;
            customer.Lastname = lastname;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Firstname in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname
        {
            get
            {
                return this._Firstname;
            }
            set
            {
                this.OnFirstnameChanging(value);
                this.ReportPropertyChanging("Firstname");
                this._Firstname = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Firstname");
                this.OnFirstnameChanged();
            }
        }
        private string _Firstname;
        partial void OnFirstnameChanging(string value);
        partial void OnFirstnameChanged();
        /// <summary>
        /// There are no comments for Property Lastname in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname
        {
            get
            {
                return this._Lastname;
            }
            set
            {
                this.OnLastnameChanging(value);
                this.ReportPropertyChanging("Lastname");
                this._Lastname = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Lastname");
                this.OnLastnameChanged();
            }
        }
        private string _Lastname;
        partial void OnLastnameChanging(string value);
        partial void OnLastnameChanged();
    }
}
