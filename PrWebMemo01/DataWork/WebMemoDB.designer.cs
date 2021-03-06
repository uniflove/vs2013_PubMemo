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

namespace PrWebMemo01.DataWork
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebMemo")]
	public partial class WebMemoDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    partial void InsertPubMemo(PubMemo instance);
    partial void UpdatePubMemo(PubMemo instance);
    partial void DeletePubMemo(PubMemo instance);
    #endregion
		
		public WebMemoDBDataContext() : 
				base(global::PrWebMemo01.Properties.Settings.Default.WebMemoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebMemoDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMemoDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMemoDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMemoDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PubMemo> PubMemo
		{
			get
			{
				return this.GetTable<PubMemo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PubMemo")]
	public partial class PubMemo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _memo;
		
		private string _title;
		
		private string _category1;
		
		private string _category2;
		
		private string _category3;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmemoChanging(string value);
    partial void OnmemoChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void Oncategory1Changing(string value);
    partial void Oncategory1Changed();
    partial void Oncategory2Changing(string value);
    partial void Oncategory2Changed();
    partial void Oncategory3Changing(string value);
    partial void Oncategory3Changed();
    #endregion
		
		public PubMemo()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_memo", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string memo
		{
			get
			{
				return this._memo;
			}
			set
			{
				if ((this._memo != value))
				{
					this.OnmemoChanging(value);
					this.SendPropertyChanging();
					this._memo = value;
					this.SendPropertyChanged("memo");
					this.OnmemoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category1", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string category1
		{
			get
			{
				return this._category1;
			}
			set
			{
				if ((this._category1 != value))
				{
					this.Oncategory1Changing(value);
					this.SendPropertyChanging();
					this._category1 = value;
					this.SendPropertyChanged("category1");
					this.Oncategory1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category2", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string category2
		{
			get
			{
				return this._category2;
			}
			set
			{
				if ((this._category2 != value))
				{
					this.Oncategory2Changing(value);
					this.SendPropertyChanging();
					this._category2 = value;
					this.SendPropertyChanged("category2");
					this.Oncategory2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category3", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string category3
		{
			get
			{
				return this._category3;
			}
			set
			{
				if ((this._category3 != value))
				{
					this.Oncategory3Changing(value);
					this.SendPropertyChanging();
					this._category3 = value;
					this.SendPropertyChanged("category3");
					this.Oncategory3Changed();
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
