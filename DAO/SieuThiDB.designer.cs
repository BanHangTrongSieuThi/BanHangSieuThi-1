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

namespace DAO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SieuThiDB")]
	public partial class SieuThiDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertGianHang(GianHang instance);
    partial void UpdateGianHang(GianHang instance);
    partial void DeleteGianHang(GianHang instance);
    partial void InsertDangNhap(DangNhap instance);
    partial void UpdateDangNhap(DangNhap instance);
    partial void DeleteDangNhap(DangNhap instance);
    #endregion
		
		public SieuThiDBDataContext() : 
				base(global::DAO.Properties.Settings.Default.SieuThiDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SieuThiDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SieuThiDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SieuThiDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SieuThiDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<GianHang> GianHangs
		{
			get
			{
				return this.GetTable<GianHang>();
			}
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ManvNext")]
		public int ManvNext([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> manv)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), manv);
			manv = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GianHangNext")]
		public int GianHangNext([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaGianHang", DbType="Int")] ref System.Nullable<int> maGianHang)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maGianHang);
			maGianHang = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _TenNV;
		
		private string _DienThoaiLH;
		
		private string _MoTaKhac;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnDienThoaiLHChanging(string value);
    partial void OnDienThoaiLHChanged();
    partial void OnMoTaKhacChanging(string value);
    partial void OnMoTaKhacChanged();
    #endregion
		
		public NhanVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoaiLH", DbType="VarChar(12)")]
		public string DienThoaiLH
		{
			get
			{
				return this._DienThoaiLH;
			}
			set
			{
				if ((this._DienThoaiLH != value))
				{
					this.OnDienThoaiLHChanging(value);
					this.SendPropertyChanging();
					this._DienThoaiLH = value;
					this.SendPropertyChanged("DienThoaiLH");
					this.OnDienThoaiLHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTaKhac", DbType="NVarChar(250)")]
		public string MoTaKhac
		{
			get
			{
				return this._MoTaKhac;
			}
			set
			{
				if ((this._MoTaKhac != value))
				{
					this.OnMoTaKhacChanging(value);
					this.SendPropertyChanging();
					this._MoTaKhac = value;
					this.SendPropertyChanged("MoTaKhac");
					this.OnMoTaKhacChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GianHang")]
	public partial class GianHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaGianHang;
		
		private string _TenGianHang;
		
		private System.Nullable<int> _LoaiHangMa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaGianHangChanging(int value);
    partial void OnMaGianHangChanged();
    partial void OnTenGianHangChanging(string value);
    partial void OnTenGianHangChanged();
    partial void OnLoaiHangMaChanging(System.Nullable<int> value);
    partial void OnLoaiHangMaChanged();
    #endregion
		
		public GianHang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGianHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaGianHang
		{
			get
			{
				return this._MaGianHang;
			}
			set
			{
				if ((this._MaGianHang != value))
				{
					this.OnMaGianHangChanging(value);
					this.SendPropertyChanging();
					this._MaGianHang = value;
					this.SendPropertyChanged("MaGianHang");
					this.OnMaGianHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenGianHang", DbType="NVarChar(50)")]
		public string TenGianHang
		{
			get
			{
				return this._TenGianHang;
			}
			set
			{
				if ((this._TenGianHang != value))
				{
					this.OnTenGianHangChanging(value);
					this.SendPropertyChanging();
					this._TenGianHang = value;
					this.SendPropertyChanged("TenGianHang");
					this.OnTenGianHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiHangMa", DbType="Int")]
		public System.Nullable<int> LoaiHangMa
		{
			get
			{
				return this._LoaiHangMa;
			}
			set
			{
				if ((this._LoaiHangMa != value))
				{
					this.OnLoaiHangMaChanging(value);
					this.SendPropertyChanging();
					this._LoaiHangMa = value;
					this.SendPropertyChanged("LoaiHangMa");
					this.OnLoaiHangMaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public DangNhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
