﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiChiTieu
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyChiTieu")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChovay(Chovay instance);
    partial void UpdateChovay(Chovay instance);
    partial void DeleteChovay(Chovay instance);
    partial void InsertChitieu(Chitieu instance);
    partial void UpdateChitieu(Chitieu instance);
    partial void DeleteChitieu(Chitieu instance);
    partial void InsertDivay(Divay instance);
    partial void UpdateDivay(Divay instance);
    partial void DeleteDivay(Divay instance);
    partial void InsertTrano(Trano instance);
    partial void UpdateTrano(Trano instance);
    partial void DeleteTrano(Trano instance);
    partial void InsertThuno(Thuno instance);
    partial void UpdateThuno(Thuno instance);
    partial void DeleteThuno(Thuno instance);
    partial void InsertThunhap(Thunhap instance);
    partial void UpdateThunhap(Thunhap instance);
    partial void DeleteThunhap(Thunhap instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::QuanLiChiTieu.Properties.Settings.Default.QuanLyChiTieuConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		public System.Data.Linq.Table<Chovay> Chovays
		{
			get
			{
				return this.GetTable<Chovay>();
			}
		}
		
		public System.Data.Linq.Table<Chitieu> Chitieus
		{
			get
			{
				return this.GetTable<Chitieu>();
			}
		}
		
		public System.Data.Linq.Table<Divay> Divays
		{
			get
			{
				return this.GetTable<Divay>();
			}
		}
		
		public System.Data.Linq.Table<Trano> Tranos
		{
			get
			{
				return this.GetTable<Trano>();
			}
		}
		
		public System.Data.Linq.Table<Thuno> Thunos
		{
			get
			{
				return this.GetTable<Thuno>();
			}
		}
		
		public System.Data.Linq.Table<Thunhap> Thunhaps
		{
			get
			{
				return this.GetTable<Thunhap>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap
	{
		
		private string _tendangnhap;
		
		private string _matkhau;
		
		public DangNhap()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendangnhap", DbType="Char(50)")]
		public string tendangnhap
		{
			get
			{
				return this._tendangnhap;
			}
			set
			{
				if ((this._tendangnhap != value))
				{
					this._tendangnhap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="Char(50)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this._matkhau = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Chovay")]
	public partial class Chovay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Người_Vay;
		
		private System.Nullable<int> _Số_Tiền;
		
		private string _Tài_Khoản;
		
		private string _Mục_Đích;
		
		private string _Diễn_Giải;
		
		private System.Nullable<System.DateTime> _Ngày;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNgười_VayChanging(string value);
    partial void OnNgười_VayChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnDiễn_GiảiChanging(string value);
    partial void OnDiễn_GiảiChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    #endregion
		
		public Chovay()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="NguoiVay", Storage="_Người_Vay", DbType="NVarChar(50)")]
		public string Người_Vay
		{
			get
			{
				return this._Người_Vay;
			}
			set
			{
				if ((this._Người_Vay != value))
				{
					this.OnNgười_VayChanging(value);
					this.SendPropertyChanging();
					this._Người_Vay = value;
					this.SendPropertyChanged("Người_Vay");
					this.OnNgười_VayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DienGiai", Storage="_Diễn_Giải", DbType="NVarChar(50)")]
		public string Diễn_Giải
		{
			get
			{
				return this._Diễn_Giải;
			}
			set
			{
				if ((this._Diễn_Giải != value))
				{
					this.OnDiễn_GiảiChanging(value);
					this.SendPropertyChanging();
					this._Diễn_Giải = value;
					this.SendPropertyChanged("Diễn_Giải");
					this.OnDiễn_GiảiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Chitieu")]
	public partial class Chitieu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Tên_SP;
		
		private System.Nullable<int> _Số_Lượng;
		
		private System.Nullable<int> _Số_Tiền;
		
		private string _Tài_Khoản;
		
		private string _Mục_Đích;
		
		private System.Nullable<System.DateTime> _Ngày;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTên_SPChanging(string value);
    partial void OnTên_SPChanged();
    partial void OnSố_LượngChanging(System.Nullable<int> value);
    partial void OnSố_LượngChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    #endregion
		
		public Chitieu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TenSP", Storage="_Tên_SP", DbType="NVarChar(20)")]
		public string Tên_SP
		{
			get
			{
				return this._Tên_SP;
			}
			set
			{
				if ((this._Tên_SP != value))
				{
					this.OnTên_SPChanging(value);
					this.SendPropertyChanging();
					this._Tên_SP = value;
					this.SendPropertyChanged("Tên_SP");
					this.OnTên_SPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoLuong", Storage="_Số_Lượng", DbType="Int")]
		public System.Nullable<int> Số_Lượng
		{
			get
			{
				return this._Số_Lượng;
			}
			set
			{
				if ((this._Số_Lượng != value))
				{
					this.OnSố_LượngChanging(value);
					this.SendPropertyChanging();
					this._Số_Lượng = value;
					this.SendPropertyChanged("Số_Lượng");
					this.OnSố_LượngChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Divay")]
	public partial class Divay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Người_Cho_Vay;
		
		private System.Nullable<int> _Số_Tiền;
		
		private string _Tài_Khoản;
		
		private string _Mục_Đích;
		
		private string _Diễn_Giải;
		
		private System.Nullable<System.DateTime> _Ngày;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNgười_Cho_VayChanging(string value);
    partial void OnNgười_Cho_VayChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnDiễn_GiảiChanging(string value);
    partial void OnDiễn_GiảiChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    #endregion
		
		public Divay()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="NguoiChoVay", Storage="_Người_Cho_Vay", DbType="NVarChar(50)")]
		public string Người_Cho_Vay
		{
			get
			{
				return this._Người_Cho_Vay;
			}
			set
			{
				if ((this._Người_Cho_Vay != value))
				{
					this.OnNgười_Cho_VayChanging(value);
					this.SendPropertyChanging();
					this._Người_Cho_Vay = value;
					this.SendPropertyChanged("Người_Cho_Vay");
					this.OnNgười_Cho_VayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DienGiai", Storage="_Diễn_Giải", DbType="NVarChar(50)")]
		public string Diễn_Giải
		{
			get
			{
				return this._Diễn_Giải;
			}
			set
			{
				if ((this._Diễn_Giải != value))
				{
					this.OnDiễn_GiảiChanging(value);
					this.SendPropertyChanging();
					this._Diễn_Giải = value;
					this.SendPropertyChanged("Diễn_Giải");
					this.OnDiễn_GiảiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Trano")]
	public partial class Trano : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Người_Cho_Vay;
		
		private System.Nullable<int> _Số_Tiền;
		
		private string _Tài_Khoản;
		
		private string _Mục_Đích;
		
		private string _Diễn_Giải;
		
		private System.Nullable<System.DateTime> _Ngày;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNgười_Cho_VayChanging(string value);
    partial void OnNgười_Cho_VayChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnDiễn_GiảiChanging(string value);
    partial void OnDiễn_GiảiChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    #endregion
		
		public Trano()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="NguoiChoVay", Storage="_Người_Cho_Vay", DbType="NVarChar(50)")]
		public string Người_Cho_Vay
		{
			get
			{
				return this._Người_Cho_Vay;
			}
			set
			{
				if ((this._Người_Cho_Vay != value))
				{
					this.OnNgười_Cho_VayChanging(value);
					this.SendPropertyChanging();
					this._Người_Cho_Vay = value;
					this.SendPropertyChanged("Người_Cho_Vay");
					this.OnNgười_Cho_VayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DienGiai", Storage="_Diễn_Giải", DbType="NVarChar(50)")]
		public string Diễn_Giải
		{
			get
			{
				return this._Diễn_Giải;
			}
			set
			{
				if ((this._Diễn_Giải != value))
				{
					this.OnDiễn_GiảiChanging(value);
					this.SendPropertyChanging();
					this._Diễn_Giải = value;
					this.SendPropertyChanged("Diễn_Giải");
					this.OnDiễn_GiảiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Thuno")]
	public partial class Thuno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Người_Vay;
		
		private System.Nullable<int> _Số_Tiền;
		
		private string _Tài_Khoản;
		
		private string _Mục_Đích;
		
		private string _Diễn_Giải;
		
		private System.Nullable<System.DateTime> _Ngày;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNgười_VayChanging(string value);
    partial void OnNgười_VayChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnDiễn_GiảiChanging(string value);
    partial void OnDiễn_GiảiChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    #endregion
		
		public Thuno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="NguoiVay", Storage="_Người_Vay", DbType="NVarChar(50)")]
		public string Người_Vay
		{
			get
			{
				return this._Người_Vay;
			}
			set
			{
				if ((this._Người_Vay != value))
				{
					this.OnNgười_VayChanging(value);
					this.SendPropertyChanging();
					this._Người_Vay = value;
					this.SendPropertyChanged("Người_Vay");
					this.OnNgười_VayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DienGiai", Storage="_Diễn_Giải", DbType="NVarChar(50)")]
		public string Diễn_Giải
		{
			get
			{
				return this._Diễn_Giải;
			}
			set
			{
				if ((this._Diễn_Giải != value))
				{
					this.OnDiễn_GiảiChanging(value);
					this.SendPropertyChanging();
					this._Diễn_Giải = value;
					this.SendPropertyChanged("Diễn_Giải");
					this.OnDiễn_GiảiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Thunhap")]
	public partial class Thunhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Mục_Đích;
		
		private System.Nullable<int> _Số_Tiền;
		
		private System.Nullable<System.DateTime> _Ngày;
		
		private string _Tài_Khoản;
		
		private string _Diễn_Giải;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMục_ĐíchChanging(string value);
    partial void OnMục_ĐíchChanged();
    partial void OnSố_TiềnChanging(System.Nullable<int> value);
    partial void OnSố_TiềnChanged();
    partial void OnNgàyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgàyChanged();
    partial void OnTài_KhoảnChanging(string value);
    partial void OnTài_KhoảnChanged();
    partial void OnDiễn_GiảiChanging(string value);
    partial void OnDiễn_GiảiChanged();
    #endregion
		
		public Thunhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="STT", Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MucDich", Storage="_Mục_Đích", DbType="NVarChar(20)")]
		public string Mục_Đích
		{
			get
			{
				return this._Mục_Đích;
			}
			set
			{
				if ((this._Mục_Đích != value))
				{
					this.OnMục_ĐíchChanging(value);
					this.SendPropertyChanging();
					this._Mục_Đích = value;
					this.SendPropertyChanged("Mục_Đích");
					this.OnMục_ĐíchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="SoTien", Storage="_Số_Tiền", DbType="Int")]
		public System.Nullable<int> Số_Tiền
		{
			get
			{
				return this._Số_Tiền;
			}
			set
			{
				if ((this._Số_Tiền != value))
				{
					this.OnSố_TiềnChanging(value);
					this.SendPropertyChanging();
					this._Số_Tiền = value;
					this.SendPropertyChanged("Số_Tiền");
					this.OnSố_TiềnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ngay", Storage="_Ngày", DbType="Date")]
		public System.Nullable<System.DateTime> Ngày
		{
			get
			{
				return this._Ngày;
			}
			set
			{
				if ((this._Ngày != value))
				{
					this.OnNgàyChanging(value);
					this.SendPropertyChanging();
					this._Ngày = value;
					this.SendPropertyChanged("Ngày");
					this.OnNgàyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="TaiKhoan", Storage="_Tài_Khoản", DbType="NVarChar(20)")]
		public string Tài_Khoản
		{
			get
			{
				return this._Tài_Khoản;
			}
			set
			{
				if ((this._Tài_Khoản != value))
				{
					this.OnTài_KhoảnChanging(value);
					this.SendPropertyChanging();
					this._Tài_Khoản = value;
					this.SendPropertyChanged("Tài_Khoản");
					this.OnTài_KhoảnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DienGiai", Storage="_Diễn_Giải", DbType="NVarChar(50)")]
		public string Diễn_Giải
		{
			get
			{
				return this._Diễn_Giải;
			}
			set
			{
				if ((this._Diễn_Giải != value))
				{
					this.OnDiễn_GiảiChanging(value);
					this.SendPropertyChanging();
					this._Diễn_Giải = value;
					this.SendPropertyChanged("Diễn_Giải");
					this.OnDiễn_GiảiChanged();
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
