USE QuanLyHieuSach

CREATE TABLE NHACUNGUNG
(
     maNhaCungUng NVARCHAR(10) PRIMARY KEY NOT NULL,
	 tenNhaCungUng NVARCHAR(40) NOT NULL,
	 doUyTin INT,
	 soDienThoai NVARCHAR(15) CHECK(soDienThoai LIKE '0[0-9]%' AND LEN(soDienThoai) = 10),
	 email NVARCHAR(40) NOT NULL
);

CREATE TABLE KHACHHANG
(
     maKhachHang NVARCHAR(10) PRIMARY KEY NOT NULL,
	 ho NVARCHAR(20) NOT NULL,
	 ten NVARCHAR(10) NOT NULL,
	 soDienThoai NVARCHAR(15) CHECK(soDienThoai LIKE '0[0-9]%' AND LEN(soDienThoai) = 10)
);



-- RB4.1: Lương của nhân viên không được nhỏ hơn 3.000.000 (miền giá trị)
/*RB4.2 ma nhan vien la khoa chinh
thi mac dinh no la duy nhat*/
CREATE TABLE NHANVIEN
(
     maNhanVien NVARCHAR(10) PRIMARY KEY NOT NULL,
	 ho NVARCHAR(20) NOT NULL,
	 ten NVARCHAR(10) NOT NULL,
	 soDienThoai NVARCHAR(15)CHECK(soDienThoai LIKE '0[0-9]%' AND LEN(soDienThoai) = 10),
	 luong INT CHECK(luong >= 3000000)
);

--RB4.5:  Mỗi đầu sách trong kho khi được lưu lại, phải có số lượng > 0 (miền giá trị)
CREATE TABLE DAUSACH
(
     maSach NVARCHAR(10) PRIMARY KEY NOT NULL,
	 tenSach NVARCHAR(40) NOT NULL,
	 giaBia INT,
	 theLoai NVARCHAR(30),
	 ngayXuatBan DATETIME,
	 soLuongTonKho SMALLINT CHECK(soLuongTonKho > 0),
	 soTrang INT
);

CREATE TABLE TACGIA
(
     maTacGia NVARCHAR(10) PRIMARY KEY NOT NULL,
	 tenTacGia NVARCHAR(40) NOT NULL,
	 quocTich NVARCHAR(12),
	 ngaySinh DATETIME,
	 gioiTinh NVARCHAR(4)
);

CREATE TABLE BIENSOAN (
  maTacGia NVARCHAR(10),
  maSach NVARCHAR(10),
  PRIMARY KEY (maTacGia, maSach),
  FOREIGN KEY (maTacGia) REFERENCES TACGIA(maTacGia),
  FOREIGN KEY (maSach) REFERENCES DAUSACH(maSach)
);

CREATE TABLE HOADONBAN
(
     maHoaDonBan NVARCHAR(10) PRIMARY KEY NOT NULL,
	 maKhachHang NVARCHAR(10) FOREIGN KEY REFERENCES KHACHHANG(maKhachHang),
	 maNhanVien NVARCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(maNhanVien),
	 ngayGiaoDich DATETIME,
	 giaDonHang INT
);

CREATE TABLE HOADONMUA
(
     maHoaDonMua NVARCHAR(10) PRIMARY KEY NOT NULL,
	 maNhaCungUng NVARCHAR(10) FOREIGN KEY REFERENCES NHACUNGUNG(maNhaCungUng),
	 maNhanVien NVARCHAR(10) FOREIGN KEY REFERENCES NHANVIEN(maNhanVien),
	 ngayGiaoDich DATETIME,
	 giaDonHang INT
);

CREATE TABLE CHITIETHOADONBAN
(
     PRIMARY KEY(maHoaDonBan, maSach),
     maHoaDonBan NVARCHAR(10) FOREIGN KEY REFERENCES HOADONBAN(maHoaDonBan) NOT NULL,
	 maSach NVARCHAR(10) FOREIGN KEY REFERENCES DAUSACH(maSach) NOT NULL,
	 soLuong SMALLINT,
	 donGia INT
);

--RB4.6: Mỗi mã sách trong hoá đơn phải giống với mã sách của đầu sách (Tham chiếu)
ALTER TABLE CHITIETHOADONBAN
ADD CONSTRAINT fk_maSach
FOREIGN KEY (maSach) REFERENCES DAUSACH(maSach)


CREATE TABLE CHITIETHOADONMUA
(
     PRIMARY KEY(maHoaDonMua, maSach),
	 maHoaDonMua NVARCHAR(10) FOREIGN KEY REFERENCES HOADONMUA(maHoaDonMua) NOT NULL,
	 maSach NVARCHAR(10) FOREIGN KEY REFERENCES DAUSACH(maSach) NOT NULL,
	 soLuong SMALLINT,
	 donGia INT
);