﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordHelperForm01.DataWork
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Password")]
	public partial class PasswordDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    partial void Insertpwd(pwd instance);
    partial void Updatepwd(pwd instance);
    partial void Deletepwd(pwd instance);
    #endregion
		
		public PasswordDBDataContext() : 
				base(global::PasswordHelperForm01.Properties.Settings.Default.PasswordConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PasswordDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PasswordDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PasswordDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PasswordDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<pwd> pwd
		{
			get
			{
				return this.GetTable<pwd>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pwd")]
	public partial class pwd : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _site;
		
		private string _subInfo;
		
		private string _loginId;
		
		private string _password;
		
		private string _hint;
		
		private string _description;
		
		private string _tag;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnsiteChanging(string value);
    partial void OnsiteChanged();
    partial void OnsubInfoChanging(string value);
    partial void OnsubInfoChanged();
    partial void OnloginIdChanging(string value);
    partial void OnloginIdChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnhintChanging(string value);
    partial void OnhintChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OntagChanging(string value);
    partial void OntagChanged();
    #endregion
		
		public pwd()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_site", DbType="NVarChar(128)")]
		public string site
		{
			get
			{
				return this._site;
			}
			set
			{
				if ((this._site != value))
				{
					this.OnsiteChanging(value);
					this.SendPropertyChanging();
					this._site = value;
					this.SendPropertyChanged("site");
					this.OnsiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subInfo", DbType="NVarChar(128)")]
		public string subInfo
		{
			get
			{
				return this._subInfo;
			}
			set
			{
				if ((this._subInfo != value))
				{
					this.OnsubInfoChanging(value);
					this.SendPropertyChanging();
					this._subInfo = value;
					this.SendPropertyChanged("subInfo");
					this.OnsubInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loginId", DbType="NVarChar(128)")]
		public string loginId
		{
			get
			{
				return this._loginId;
			}
			set
			{
				if ((this._loginId != value))
				{
					this.OnloginIdChanging(value);
					this.SendPropertyChanging();
					this._loginId = value;
					this.SendPropertyChanged("loginId");
					this.OnloginIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(128)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hint", DbType="NVarChar(128)")]
		public string hint
		{
			get
			{
				return this._hint;
			}
			set
			{
				if ((this._hint != value))
				{
					this.OnhintChanging(value);
					this.SendPropertyChanging();
					this._hint = value;
					this.SendPropertyChanged("hint");
					this.OnhintChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(2048)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tag", DbType="NVarChar(128)")]
		public string tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if ((this._tag != value))
				{
					this.OntagChanging(value);
					this.SendPropertyChanging();
					this._tag = value;
					this.SendPropertyChanged("tag");
					this.OntagChanged();
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
