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

namespace WindowsFormsApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IMS")]
	public partial class DataClasses4DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses4DataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.IMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses4DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Registration> Registrations
		{
			get
			{
				return this.GetTable<Registration>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Registration")]
	public partial class Registration
	{
		
		private System.Nullable<int> _customerid;
		
		private string _email;
		
		private string _passwords;
		
		public Registration()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerid", DbType="Int")]
		public System.Nullable<int> customerid
		{
			get
			{
				return this._customerid;
			}
			set
			{
				if ((this._customerid != value))
				{
					this._customerid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(20)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwords", DbType="VarChar(20)")]
		public string passwords
		{
			get
			{
				return this._passwords;
			}
			set
			{
				if ((this._passwords != value))
				{
					this._passwords = value;
				}
			}
		}
	}
}
#pragma warning restore 1591