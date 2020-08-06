﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Client
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SAFood")]
	public partial class DataClassesFoodDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    #endregion
		
		public DataClassesFoodDataContext() : 
				base(global::Food_Client.Properties.Settings.Default.SAFoodConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFoodDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFoodDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFoodDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFoodDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Items")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Food_ID;
		
		private string _Name_Food;
		
		private string _Detail;
		
		private int _Price;
		
		private int _Quantity;
		
		private string _Unit;
		
		private string _Seller_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFood_IDChanging(string value);
    partial void OnFood_IDChanged();
    partial void OnName_FoodChanging(string value);
    partial void OnName_FoodChanged();
    partial void OnDetailChanging(string value);
    partial void OnDetailChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    partial void OnSeller_IDChanging(string value);
    partial void OnSeller_IDChanged();
    #endregion
		
		public Item()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Food_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Food_ID
		{
			get
			{
				return this._Food_ID;
			}
			set
			{
				if ((this._Food_ID != value))
				{
					this.OnFood_IDChanging(value);
					this.SendPropertyChanging();
					this._Food_ID = value;
					this.SendPropertyChanged("Food_ID");
					this.OnFood_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name_Food", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name_Food
		{
			get
			{
				return this._Name_Food;
			}
			set
			{
				if ((this._Name_Food != value))
				{
					this.OnName_FoodChanging(value);
					this.SendPropertyChanging();
					this._Name_Food = value;
					this.SendPropertyChanged("Name_Food");
					this.OnName_FoodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detail", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Detail
		{
			get
			{
				return this._Detail;
			}
			set
			{
				if ((this._Detail != value))
				{
					this.OnDetailChanging(value);
					this.SendPropertyChanging();
					this._Detail = value;
					this.SendPropertyChanged("Detail");
					this.OnDetailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seller_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Seller_ID
		{
			get
			{
				return this._Seller_ID;
			}
			set
			{
				if ((this._Seller_ID != value))
				{
					this.OnSeller_IDChanging(value);
					this.SendPropertyChanging();
					this._Seller_ID = value;
					this.SendPropertyChanged("Seller_ID");
					this.OnSeller_IDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
