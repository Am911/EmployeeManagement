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

namespace EmployeeManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HRMS")]
	public partial class DesignationListDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DesignationListDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HRMSConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DesignationListDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DesignationListDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DesignationListDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DesignationListDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GET_Degeneration")]
		public ISingleResult<GET_DegenerationResult> GET_Degeneration()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GET_DegenerationResult>)(result.ReturnValue));
		}
	}
	
	public partial class GET_DegenerationResult
	{
		
		private int _Pk_DegId;
		
		private string _Degeneration;
		
		public GET_DegenerationResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pk_DegId", DbType="Int NOT NULL")]
		public int Pk_DegId
		{
			get
			{
				return this._Pk_DegId;
			}
			set
			{
				if ((this._Pk_DegId != value))
				{
					this._Pk_DegId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Degeneration", DbType="VarChar(100)")]
		public string Degeneration
		{
			get
			{
				return this._Degeneration;
			}
			set
			{
				if ((this._Degeneration != value))
				{
					this._Degeneration = value;
				}
			}
		}
	}
}
#pragma warning restore 1591