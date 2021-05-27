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

namespace BaoCaoLTW.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ShopGiay")]
	public partial class ShopGiaydbContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLichSuMuaHang(LichSuMuaHang instance);
    partial void UpdateLichSuMuaHang(LichSuMuaHang instance);
    partial void DeleteLichSuMuaHang(LichSuMuaHang instance);
    partial void InsertNhaSanXuat(NhaSanXuat instance);
    partial void UpdateNhaSanXuat(NhaSanXuat instance);
    partial void DeleteNhaSanXuat(NhaSanXuat instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertMenu(Menu instance);
    partial void UpdateMenu(Menu instance);
    partial void DeleteMenu(Menu instance);
    #endregion
		
		public ShopGiaydbContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ShopGiayConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShopGiaydbContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopGiaydbContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopGiaydbContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopGiaydbContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LichSuMuaHang> LichSuMuaHangs
		{
			get
			{
				return this.GetTable<LichSuMuaHang>();
			}
		}
		
		public System.Data.Linq.Table<NhaSanXuat> NhaSanXuats
		{
			get
			{
				return this.GetTable<NhaSanXuat>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Menu> Menus
		{
			get
			{
				return this.GetTable<Menu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichSuMuaHang")]
	public partial class LichSuMuaHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _Email;
		
		private string _SoDienThoai;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    #endregion
		
		public LichSuMuaHang()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="VarChar(10)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LichSuMuaHang_User", Storage="_Users", ThisKey="MaDonHang", OtherKey="MaDonHang")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.LichSuMuaHang = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.LichSuMuaHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaSanXuat")]
	public partial class NhaSanXuat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhaSX;
		
		private string _TenNhaSX;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhaSXChanging(string value);
    partial void OnMaNhaSXChanged();
    partial void OnTenNhaSXChanging(string value);
    partial void OnTenNhaSXChanged();
    #endregion
		
		public NhaSanXuat()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhaSX", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhaSX
		{
			get
			{
				return this._MaNhaSX;
			}
			set
			{
				if ((this._MaNhaSX != value))
				{
					this.OnMaNhaSXChanging(value);
					this.SendPropertyChanging();
					this._MaNhaSX = value;
					this.SendPropertyChanged("MaNhaSX");
					this.OnMaNhaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhaSX", DbType="NVarChar(50)")]
		public string TenNhaSX
		{
			get
			{
				return this._TenNhaSX;
			}
			set
			{
				if ((this._TenNhaSX != value))
				{
					this.OnTenNhaSXChanging(value);
					this.SendPropertyChanging();
					this._TenNhaSX = value;
					this.SendPropertyChanged("TenNhaSX");
					this.OnTenNhaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaSanXuat_SanPham", Storage="_SanPhams", ThisKey="MaNhaSX", OtherKey="MaNhaSX")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaSanXuat = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaSanXuat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSanPham;
		
		private string _TenSanPham;
		
		private string _HinhAnh;
		
		private string _MaNhaSX;
		
		private string _TenNhaSX;
		
		private System.Nullable<int> _Gia;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<bool> _TinhTrang;
		
		private EntityRef<NhaSanXuat> _NhaSanXuat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(string value);
    partial void OnMaSanPhamChanged();
    partial void OnTenSanPhamChanging(string value);
    partial void OnTenSanPhamChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnMaNhaSXChanging(string value);
    partial void OnMaNhaSXChanged();
    partial void OnTenNhaSXChanging(string value);
    partial void OnTenNhaSXChanged();
    partial void OnGiaChanging(System.Nullable<int> value);
    partial void OnGiaChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public SanPham()
		{
			this._NhaSanXuat = default(EntityRef<NhaSanXuat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(50)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this.OnTenSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenSanPham = value;
					this.SendPropertyChanged("TenSanPham");
					this.OnTenSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(250)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhaSX", DbType="VarChar(20)")]
		public string MaNhaSX
		{
			get
			{
				return this._MaNhaSX;
			}
			set
			{
				if ((this._MaNhaSX != value))
				{
					if (this._NhaSanXuat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhaSXChanging(value);
					this.SendPropertyChanging();
					this._MaNhaSX = value;
					this.SendPropertyChanged("MaNhaSX");
					this.OnMaNhaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhaSX", DbType="NVarChar(50)")]
		public string TenNhaSX
		{
			get
			{
				return this._TenNhaSX;
			}
			set
			{
				if ((this._TenNhaSX != value))
				{
					this.OnTenNhaSXChanging(value);
					this.SendPropertyChanging();
					this._TenNhaSX = value;
					this.SendPropertyChanged("TenNhaSX");
					this.OnTenNhaSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int")]
		public System.Nullable<int> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaSanXuat_SanPham", Storage="_NhaSanXuat", ThisKey="MaNhaSX", OtherKey="MaNhaSX", IsForeignKey=true)]
		public NhaSanXuat NhaSanXuat
		{
			get
			{
				return this._NhaSanXuat.Entity;
			}
			set
			{
				NhaSanXuat previousValue = this._NhaSanXuat.Entity;
				if (((previousValue != value) 
							|| (this._NhaSanXuat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhaSanXuat.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._NhaSanXuat.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaNhaSX = value.MaNhaSX;
					}
					else
					{
						this._MaNhaSX = default(string);
					}
					this.SendPropertyChanged("NhaSanXuat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _Email;
		
		private string _SoDienThoai;
		
		private System.Nullable<int> _MaDonHang;
		
		private EntityRef<LichSuMuaHang> _LichSuMuaHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnMaDonHangChanging(System.Nullable<int> value);
    partial void OnMaDonHangChanged();
    #endregion
		
		public User()
		{
			this._LichSuMuaHang = default(EntityRef<LichSuMuaHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NVarChar(50)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="VarChar(10)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int")]
		public System.Nullable<int> MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					if (this._LichSuMuaHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LichSuMuaHang_User", Storage="_LichSuMuaHang", ThisKey="MaDonHang", OtherKey="MaDonHang", IsForeignKey=true)]
		public LichSuMuaHang LichSuMuaHang
		{
			get
			{
				return this._LichSuMuaHang.Entity;
			}
			set
			{
				LichSuMuaHang previousValue = this._LichSuMuaHang.Entity;
				if (((previousValue != value) 
							|| (this._LichSuMuaHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LichSuMuaHang.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._LichSuMuaHang.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._MaDonHang = value.MaDonHang;
					}
					else
					{
						this._MaDonHang = default(Nullable<int>);
					}
					this.SendPropertyChanged("LichSuMuaHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Menu")]
	public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Text;
		
		private string _Link;
		
		private System.Nullable<bool> _Status;
		
		private System.Nullable<int> _TypeID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnLinkChanging(string value);
    partial void OnLinkChanged();
    partial void OnStatusChanging(System.Nullable<bool> value);
    partial void OnStatusChanged();
    partial void OnTypeIDChanging(System.Nullable<int> value);
    partial void OnTypeIDChanged();
    #endregion
		
		public Menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(50)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Link", DbType="VarChar(50)")]
		public string Link
		{
			get
			{
				return this._Link;
			}
			set
			{
				if ((this._Link != value))
				{
					this.OnLinkChanging(value);
					this.SendPropertyChanging();
					this._Link = value;
					this.SendPropertyChanged("Link");
					this.OnLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Bit")]
		public System.Nullable<bool> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeID", DbType="Int")]
		public System.Nullable<int> TypeID
		{
			get
			{
				return this._TypeID;
			}
			set
			{
				if ((this._TypeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._TypeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
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