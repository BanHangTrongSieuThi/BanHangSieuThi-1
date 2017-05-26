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
    partial void InsertLoaiHang(LoaiHang instance);
    partial void UpdateLoaiHang(LoaiHang instance);
    partial void DeleteLoaiHang(LoaiHang instance);
    partial void InsertNhaCungCap(NhaCungCap instance);
    partial void UpdateNhaCungCap(NhaCungCap instance);
    partial void DeleteNhaCungCap(NhaCungCap instance);
    partial void InsertHang(Hang instance);
    partial void UpdateHang(Hang instance);
    partial void DeleteHang(Hang instance);
    #endregion
		
		public SieuThiDBDataContext() : 
				base(global::DAO.Properties.Settings.Default.SieuThiConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<LoaiHang> LoaiHangs
		{
			get
			{
				return this.GetTable<LoaiHang>();
			}
		}
		
		public System.Data.Linq.Table<NhaCungCap> NhaCungCaps
		{
			get
			{
				return this.GetTable<NhaCungCap>();
			}
		}
		
		public System.Data.Linq.Table<Hang> Hangs
		{
			get
			{
				return this.GetTable<Hang>();
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.LoaiHangGanNhat")]
		public int LoaiHangGanNhat([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaLoaiHang", DbType="Int")] ref System.Nullable<int> maLoaiHang)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maLoaiHang);
			maLoaiHang = ((System.Nullable<int>)(result.GetParameterValue(0)));
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
		
		private EntityRef<LoaiHang> _LoaiHang;
		
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
			this._LoaiHang = default(EntityRef<LoaiHang>);
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
					if (this._LoaiHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoaiHangMaChanging(value);
					this.SendPropertyChanging();
					this._LoaiHangMa = value;
					this.SendPropertyChanged("LoaiHangMa");
					this.OnLoaiHangMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiHang_GianHang", Storage="_LoaiHang", ThisKey="LoaiHangMa", OtherKey="MaLoaiHang", IsForeignKey=true)]
		public LoaiHang LoaiHang
		{
			get
			{
				return this._LoaiHang.Entity;
			}
			set
			{
				LoaiHang previousValue = this._LoaiHang.Entity;
				if (((previousValue != value) 
							|| (this._LoaiHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiHang.Entity = null;
						previousValue.GianHangs.Remove(this);
					}
					this._LoaiHang.Entity = value;
					if ((value != null))
					{
						value.GianHangs.Add(this);
						this._LoaiHangMa = value.MaLoaiHang;
					}
					else
					{
						this._LoaiHangMa = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiHang")]
	public partial class LoaiHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoaiHang;
		
		private string _TenLoaiHang;
		
		private EntitySet<GianHang> _GianHangs;
		
		private EntitySet<Hang> _Hangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiHangChanging(int value);
    partial void OnMaLoaiHangChanged();
    partial void OnTenLoaiHangChanging(string value);
    partial void OnTenLoaiHangChanged();
    #endregion
		
		public LoaiHang()
		{
			this._GianHangs = new EntitySet<GianHang>(new Action<GianHang>(this.attach_GianHangs), new Action<GianHang>(this.detach_GianHangs));
			this._Hangs = new EntitySet<Hang>(new Action<Hang>(this.attach_Hangs), new Action<Hang>(this.detach_Hangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLoaiHang
		{
			get
			{
				return this._MaLoaiHang;
			}
			set
			{
				if ((this._MaLoaiHang != value))
				{
					this.OnMaLoaiHangChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiHang = value;
					this.SendPropertyChanged("MaLoaiHang");
					this.OnMaLoaiHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiHang", DbType="NVarChar(50)")]
		public string TenLoaiHang
		{
			get
			{
				return this._TenLoaiHang;
			}
			set
			{
				if ((this._TenLoaiHang != value))
				{
					this.OnTenLoaiHangChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiHang = value;
					this.SendPropertyChanged("TenLoaiHang");
					this.OnTenLoaiHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiHang_GianHang", Storage="_GianHangs", ThisKey="MaLoaiHang", OtherKey="LoaiHangMa")]
		public EntitySet<GianHang> GianHangs
		{
			get
			{
				return this._GianHangs;
			}
			set
			{
				this._GianHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiHang_Hang", Storage="_Hangs", ThisKey="MaLoaiHang", OtherKey="MaLoaiHang")]
		public EntitySet<Hang> Hangs
		{
			get
			{
				return this._Hangs;
			}
			set
			{
				this._Hangs.Assign(value);
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
		
		private void attach_GianHangs(GianHang entity)
		{
			this.SendPropertyChanging();
			entity.LoaiHang = this;
		}
		
		private void detach_GianHangs(GianHang entity)
		{
			this.SendPropertyChanging();
			entity.LoaiHang = null;
		}
		
		private void attach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.LoaiHang = this;
		}
		
		private void detach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.LoaiHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaCungCap")]
	public partial class NhaCungCap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNCC;
		
		private string _TenNCC;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private string _Fax;
		
		private string _MaSoThue;
		
		private EntitySet<Hang> _Hangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNCCChanging(int value);
    partial void OnMaNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnMaSoThueChanging(string value);
    partial void OnMaSoThueChanged();
    #endregion
		
		public NhaCungCap()
		{
			this._Hangs = new EntitySet<Hang>(new Action<Hang>(this.attach_Hangs), new Action<Hang>(this.detach_Hangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(150)")]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(150)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(12)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="VarChar(12)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSoThue", DbType="VarChar(12)")]
		public string MaSoThue
		{
			get
			{
				return this._MaSoThue;
			}
			set
			{
				if ((this._MaSoThue != value))
				{
					this.OnMaSoThueChanging(value);
					this.SendPropertyChanging();
					this._MaSoThue = value;
					this.SendPropertyChanged("MaSoThue");
					this.OnMaSoThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_Hang", Storage="_Hangs", ThisKey="MaNCC", OtherKey="MaNCC")]
		public EntitySet<Hang> Hangs
		{
			get
			{
				return this._Hangs;
			}
			set
			{
				this._Hangs.Assign(value);
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
		
		private void attach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = this;
		}
		
		private void detach_Hangs(Hang entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hang")]
	public partial class Hang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHang;
		
		private string _TenHang;
		
		private string _DVT;
		
		private System.Nullable<int> _MaLoaiHang;
		
		private System.Nullable<int> _MaNCC;
		
		private string _GhiChu;
		
		private EntityRef<LoaiHang> _LoaiHang;
		
		private EntityRef<NhaCungCap> _NhaCungCap;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangChanging(string value);
    partial void OnMaHangChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnDVTChanging(string value);
    partial void OnDVTChanged();
    partial void OnMaLoaiHangChanging(System.Nullable<int> value);
    partial void OnMaLoaiHangChanged();
    partial void OnMaNCCChanging(System.Nullable<int> value);
    partial void OnMaNCCChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public Hang()
		{
			this._LoaiHang = default(EntityRef<LoaiHang>);
			this._NhaCungCap = default(EntityRef<NhaCungCap>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHang
		{
			get
			{
				return this._MaHang;
			}
			set
			{
				if ((this._MaHang != value))
				{
					this.OnMaHangChanging(value);
					this.SendPropertyChanging();
					this._MaHang = value;
					this.SendPropertyChanged("MaHang");
					this.OnMaHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(50)")]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DVT", DbType="NVarChar(15)")]
		public string DVT
		{
			get
			{
				return this._DVT;
			}
			set
			{
				if ((this._DVT != value))
				{
					this.OnDVTChanging(value);
					this.SendPropertyChanging();
					this._DVT = value;
					this.SendPropertyChanged("DVT");
					this.OnDVTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiHang", DbType="Int")]
		public System.Nullable<int> MaLoaiHang
		{
			get
			{
				return this._MaLoaiHang;
			}
			set
			{
				if ((this._MaLoaiHang != value))
				{
					if (this._LoaiHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiHangChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiHang = value;
					this.SendPropertyChanged("MaLoaiHang");
					this.OnMaLoaiHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", DbType="Int")]
		public System.Nullable<int> MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					if (this._NhaCungCap.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiHang_Hang", Storage="_LoaiHang", ThisKey="MaLoaiHang", OtherKey="MaLoaiHang", IsForeignKey=true)]
		public LoaiHang LoaiHang
		{
			get
			{
				return this._LoaiHang.Entity;
			}
			set
			{
				LoaiHang previousValue = this._LoaiHang.Entity;
				if (((previousValue != value) 
							|| (this._LoaiHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiHang.Entity = null;
						previousValue.Hangs.Remove(this);
					}
					this._LoaiHang.Entity = value;
					if ((value != null))
					{
						value.Hangs.Add(this);
						this._MaLoaiHang = value.MaLoaiHang;
					}
					else
					{
						this._MaLoaiHang = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_Hang", Storage="_NhaCungCap", ThisKey="MaNCC", OtherKey="MaNCC", IsForeignKey=true)]
		public NhaCungCap NhaCungCap
		{
			get
			{
				return this._NhaCungCap.Entity;
			}
			set
			{
				NhaCungCap previousValue = this._NhaCungCap.Entity;
				if (((previousValue != value) 
							|| (this._NhaCungCap.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhaCungCap.Entity = null;
						previousValue.Hangs.Remove(this);
					}
					this._NhaCungCap.Entity = value;
					if ((value != null))
					{
						value.Hangs.Add(this);
						this._MaNCC = value.MaNCC;
					}
					else
					{
						this._MaNCC = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhaCungCap");
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
