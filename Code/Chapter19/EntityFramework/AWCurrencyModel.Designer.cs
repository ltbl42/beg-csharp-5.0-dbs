﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace EntityFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AWCurrencyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AWCurrencyEntities object using the connection string found in the 'AWCurrencyEntities' section of the application configuration file.
        /// </summary>
        public AWCurrencyEntities() : base("name=AWCurrencyEntities", "AWCurrencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AWCurrencyEntities object.
        /// </summary>
        public AWCurrencyEntities(string connectionString) : base(connectionString, "AWCurrencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AWCurrencyEntities object.
        /// </summary>
        public AWCurrencyEntities(EntityConnection connection) : base(connection, "AWCurrencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Currency> Currencies
        {
            get
            {
                if ((_Currencies == null))
                {
                    _Currencies = base.CreateObjectSet<Currency>("Currencies");
                }
                return _Currencies;
            }
        }
        private ObjectSet<Currency> _Currencies;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Currencies EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCurrencies(Currency currency)
        {
            base.AddObject("Currencies", currency);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksModel", Name="Currency")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Currency : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Currency object.
        /// </summary>
        /// <param name="currencyCode">Initial value of the CurrencyCode property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Currency CreateCurrency(global::System.String currencyCode, global::System.String name, global::System.DateTime modifiedDate)
        {
            Currency currency = new Currency();
            currency.CurrencyCode = currencyCode;
            currency.Name = name;
            currency.ModifiedDate = modifiedDate;
            return currency;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CurrencyCode
        {
            get
            {
                return _CurrencyCode;
            }
            set
            {
                if (_CurrencyCode != value)
                {
                    OnCurrencyCodeChanging(value);
                    ReportPropertyChanging("CurrencyCode");
                    _CurrencyCode = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CurrencyCode");
                    OnCurrencyCodeChanged();
                }
            }
        }
        private global::System.String _CurrencyCode;
        partial void OnCurrencyCodeChanging(global::System.String value);
        partial void OnCurrencyCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion

    
    }

    #endregion

    
}
