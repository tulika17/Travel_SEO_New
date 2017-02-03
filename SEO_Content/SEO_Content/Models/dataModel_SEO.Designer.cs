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
namespace SEO_Content.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Travel_SEOContentEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Travel_SEOContentEntities object using the connection string found in the 'Travel_SEOContentEntities' section of the application configuration file.
        /// </summary>
        public Travel_SEOContentEntities() : base("name=Travel_SEOContentEntities", "Travel_SEOContentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Travel_SEOContentEntities object.
        /// </summary>
        public Travel_SEOContentEntities(string connectionString) : base(connectionString, "Travel_SEOContentEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Travel_SEOContentEntities object.
        /// </summary>
        public Travel_SEOContentEntities(EntityConnection connection) : base(connection, "Travel_SEOContentEntities")
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
        public ObjectSet<country> countries
        {
            get
            {
                if ((_countries == null))
                {
                    _countries = base.CreateObjectSet<country>("countries");
                }
                return _countries;
            }
        }
        private ObjectSet<country> _countries;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<state> states
        {
            get
            {
                if ((_states == null))
                {
                    _states = base.CreateObjectSet<state>("states");
                }
                return _states;
            }
        }
        private ObjectSet<state> _states;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<City> Cities
        {
            get
            {
                if ((_Cities == null))
                {
                    _Cities = base.CreateObjectSet<City>("Cities");
                }
                return _Cities;
            }
        }
        private ObjectSet<City> _Cities;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the countries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocountries(country country)
        {
            base.AddObject("countries", country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the states EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostates(state state)
        {
            base.AddObject("states", state);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Cities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCities(City city)
        {
            base.AddObject("Cities", city);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Travel_SEOContentModel", Name="City")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class City : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new City object.
        /// </summary>
        /// <param name="city_id">Initial value of the city_id property.</param>
        public static City CreateCity(global::System.Int32 city_id)
        {
            City city = new City();
            city.city_id = city_id;
            return city;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 city_id
        {
            get
            {
                return _city_id;
            }
            set
            {
                if (_city_id != value)
                {
                    Oncity_idChanging(value);
                    ReportPropertyChanging("city_id");
                    _city_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("city_id");
                    Oncity_idChanged();
                }
            }
        }
        private global::System.Int32 _city_id;
        partial void Oncity_idChanging(global::System.Int32 value);
        partial void Oncity_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String city_name
        {
            get
            {
                return _city_name;
            }
            set
            {
                Oncity_nameChanging(value);
                ReportPropertyChanging("city_name");
                _city_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("city_name");
                Oncity_nameChanged();
            }
        }
        private global::System.String _city_name;
        partial void Oncity_nameChanging(global::System.String value);
        partial void Oncity_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> state_id
        {
            get
            {
                return _state_id;
            }
            set
            {
                Onstate_idChanging(value);
                ReportPropertyChanging("state_id");
                _state_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("state_id");
                Onstate_idChanged();
            }
        }
        private Nullable<global::System.Int32> _state_id;
        partial void Onstate_idChanging(Nullable<global::System.Int32> value);
        partial void Onstate_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String whether
        {
            get
            {
                return _whether;
            }
            set
            {
                OnwhetherChanging(value);
                ReportPropertyChanging("whether");
                _whether = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("whether");
                OnwhetherChanged();
            }
        }
        private global::System.String _whether;
        partial void OnwhetherChanging(global::System.String value);
        partial void OnwhetherChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String best_time_to_visit
        {
            get
            {
                return _best_time_to_visit;
            }
            set
            {
                Onbest_time_to_visitChanging(value);
                ReportPropertyChanging("best_time_to_visit");
                _best_time_to_visit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("best_time_to_visit");
                Onbest_time_to_visitChanged();
            }
        }
        private global::System.String _best_time_to_visit;
        partial void Onbest_time_to_visitChanging(global::System.String value);
        partial void Onbest_time_to_visitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String places_to_visit
        {
            get
            {
                return _places_to_visit;
            }
            set
            {
                Onplaces_to_visitChanging(value);
                ReportPropertyChanging("places_to_visit");
                _places_to_visit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("places_to_visit");
                Onplaces_to_visitChanged();
            }
        }
        private global::System.String _places_to_visit;
        partial void Onplaces_to_visitChanging(global::System.String value);
        partial void Onplaces_to_visitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc1
        {
            get
            {
                return _desc1;
            }
            set
            {
                Ondesc1Changing(value);
                ReportPropertyChanging("desc1");
                _desc1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc1");
                Ondesc1Changed();
            }
        }
        private global::System.String _desc1;
        partial void Ondesc1Changing(global::System.String value);
        partial void Ondesc1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc2
        {
            get
            {
                return _desc2;
            }
            set
            {
                Ondesc2Changing(value);
                ReportPropertyChanging("desc2");
                _desc2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc2");
                Ondesc2Changed();
            }
        }
        private global::System.String _desc2;
        partial void Ondesc2Changing(global::System.String value);
        partial void Ondesc2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc3
        {
            get
            {
                return _desc3;
            }
            set
            {
                Ondesc3Changing(value);
                ReportPropertyChanging("desc3");
                _desc3 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc3");
                Ondesc3Changed();
            }
        }
        private global::System.String _desc3;
        partial void Ondesc3Changing(global::System.String value);
        partial void Ondesc3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc4
        {
            get
            {
                return _desc4;
            }
            set
            {
                Ondesc4Changing(value);
                ReportPropertyChanging("desc4");
                _desc4 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc4");
                Ondesc4Changed();
            }
        }
        private global::System.String _desc4;
        partial void Ondesc4Changing(global::System.String value);
        partial void Ondesc4Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc5
        {
            get
            {
                return _desc5;
            }
            set
            {
                Ondesc5Changing(value);
                ReportPropertyChanging("desc5");
                _desc5 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc5");
                Ondesc5Changed();
            }
        }
        private global::System.String _desc5;
        partial void Ondesc5Changing(global::System.String value);
        partial void Ondesc5Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc6
        {
            get
            {
                return _desc6;
            }
            set
            {
                Ondesc6Changing(value);
                ReportPropertyChanging("desc6");
                _desc6 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc6");
                Ondesc6Changed();
            }
        }
        private global::System.String _desc6;
        partial void Ondesc6Changing(global::System.String value);
        partial void Ondesc6Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc7
        {
            get
            {
                return _desc7;
            }
            set
            {
                Ondesc7Changing(value);
                ReportPropertyChanging("desc7");
                _desc7 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc7");
                Ondesc7Changed();
            }
        }
        private global::System.String _desc7;
        partial void Ondesc7Changing(global::System.String value);
        partial void Ondesc7Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc8
        {
            get
            {
                return _desc8;
            }
            set
            {
                Ondesc8Changing(value);
                ReportPropertyChanging("desc8");
                _desc8 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc8");
                Ondesc8Changed();
            }
        }
        private global::System.String _desc8;
        partial void Ondesc8Changing(global::System.String value);
        partial void Ondesc8Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc9
        {
            get
            {
                return _desc9;
            }
            set
            {
                Ondesc9Changing(value);
                ReportPropertyChanging("desc9");
                _desc9 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc9");
                Ondesc9Changed();
            }
        }
        private global::System.String _desc9;
        partial void Ondesc9Changing(global::System.String value);
        partial void Ondesc9Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String desc10
        {
            get
            {
                return _desc10;
            }
            set
            {
                Ondesc10Changing(value);
                ReportPropertyChanging("desc10");
                _desc10 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("desc10");
                Ondesc10Changed();
            }
        }
        private global::System.String _desc10;
        partial void Ondesc10Changing(global::System.String value);
        partial void Ondesc10Changed();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Travel_SEOContentModel", Name="country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new country object.
        /// </summary>
        /// <param name="country_id">Initial value of the country_id property.</param>
        public static country Createcountry(global::System.Int16 country_id)
        {
            country country = new country();
            country.country_id = country_id;
            return country;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 country_id
        {
            get
            {
                return _country_id;
            }
            set
            {
                if (_country_id != value)
                {
                    Oncountry_idChanging(value);
                    ReportPropertyChanging("country_id");
                    _country_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("country_id");
                    Oncountry_idChanged();
                }
            }
        }
        private global::System.Int16 _country_id;
        partial void Oncountry_idChanging(global::System.Int16 value);
        partial void Oncountry_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String country_name
        {
            get
            {
                return _country_name;
            }
            set
            {
                Oncountry_nameChanging(value);
                ReportPropertyChanging("country_name");
                _country_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("country_name");
                Oncountry_nameChanged();
            }
        }
        private global::System.String _country_name;
        partial void Oncountry_nameChanging(global::System.String value);
        partial void Oncountry_nameChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Travel_SEOContentModel", Name="state")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class state : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new state object.
        /// </summary>
        /// <param name="state_id">Initial value of the state_id property.</param>
        public static state Createstate(global::System.Int32 state_id)
        {
            state state = new state();
            state.state_id = state_id;
            return state;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 state_id
        {
            get
            {
                return _state_id;
            }
            set
            {
                if (_state_id != value)
                {
                    Onstate_idChanging(value);
                    ReportPropertyChanging("state_id");
                    _state_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("state_id");
                    Onstate_idChanged();
                }
            }
        }
        private global::System.Int32 _state_id;
        partial void Onstate_idChanging(global::System.Int32 value);
        partial void Onstate_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String state_name
        {
            get
            {
                return _state_name;
            }
            set
            {
                Onstate_nameChanging(value);
                ReportPropertyChanging("state_name");
                _state_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("state_name");
                Onstate_nameChanged();
            }
        }
        private global::System.String _state_name;
        partial void Onstate_nameChanging(global::System.String value);
        partial void Onstate_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> country_id
        {
            get
            {
                return _country_id;
            }
            set
            {
                Oncountry_idChanging(value);
                ReportPropertyChanging("country_id");
                _country_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("country_id");
                Oncountry_idChanged();
            }
        }
        private Nullable<global::System.Int16> _country_id;
        partial void Oncountry_idChanging(Nullable<global::System.Int16> value);
        partial void Oncountry_idChanged();

        #endregion

    
    }

    #endregion

    
}