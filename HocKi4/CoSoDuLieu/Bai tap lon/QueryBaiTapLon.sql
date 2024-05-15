use QuanLyHieuSach

TRUNCATE TABLE TACGIA;
TRUNCATE TABLE CHITIETHOADONBAN;
TRUNCATE TABLE CHITIETHOADONMUA;

TRUNCATE TABLE NHACUNGUNG;
TRUNCATE TABLE KHACHHANG;
TRUNCATE TABLE NHANVIEN;
TRUNCATE TABLE DAUSACH;

TRUNCATE TABLE HOADONBAN;
TRUNCATE TABLE HOADONMUA;

-- Xóa bảng
DROP TABLE IF EXISTS CHITIETHOADONMUA;
DROP TABLE IF EXISTS CHITIETHOADONBAN;
DROP TABLE IF EXISTS HOADONMUA;
DROP TABLE IF EXISTS HOADONBAN;
DROP TABLE IF EXISTS BIENSOAN;

DROP TABLE IF EXISTS DAUSACH;
DROP TABLE IF EXISTS NHANVIEN;
DROP TABLE IF EXISTS KHACHHANG;
DROP TABLE IF EXISTS NHACUNGUNG;
DROP TABLE IF EXISTS TACGIA;


SELECT * FROM TACGIA;
SELECT * FROM NHACUNGUNG
SELECT * FROM KHACHHANG
SELECT * FROM NHANVIEN
SELECT * FROM DAUSACH
SELECT * FROM BIENSOAN
SELECT * FROM HOADONBAN
SELECT * FROM HOADONMUA
SELECT * FROM CHITIETHOADONBAN
SELECT * FROM CHITIETHOADONMUA

--1: Đưa ra thông tin của các đầu sách có số lượng tồn > 20
Select * 
From DAUSACH
Where soLuongTonKho > 20

--2: Đưa ra mã sách, tên sách có giá bìa > 200000
Select maSach, tenSach
From DAUSACH
Where giaBia > 200000

--3: Đưa ra tên khách hàng mua hàng ngày 22/3/2023
Select concat(ho, ' ', ten) as hoTen
From (KHACHHANG Inner Join HOADONBAN On HOADONBAN.maKhachHang = KHACHHANG.maKhachHang)
Where ngayGiaoDich = '2023-03-22'

--4: Đưa ra tên tác giả có đầu sách xuất bản năm 2020
SELECT DISTINCT TACGIA.tenTacGia
FROM TACGIA
INNER JOIN BIENSOAN ON TACGIA.maTacGia = BIENSOAN.maTacGia
INNER JOIN DAUSACH ON BIENSOAN.maSach = DAUSACH.maSach
WHERE YEAR(DAUSACH.ngayXuatBan) >= 2020;

--5: Đưa ra thông tin về sách của tác giả Marc Levy
SELECT DAUSACH.tenSach, DAUSACH.maSach, DAUSACH.giaBia
FROM DAUSACH 
INNER JOIN BIENSOAN ON DAUSACH.maSach = BIENSOAN.maSach 
INNER JOIN TACGIA ON BIENSOAN.maTacGia = TACGIA.maTacGia 
WHERE TACGIA.tenTacGia = 'Marc Levy';

--6: Đưa ra danh sách khách hàng và số lượng hóa đơn khách hàng đó đã mua
SELECT maKhachHang, COUNT(maHoaDonBan) as hoaDonCount
FROM HOADONBAN
WHERE maKhachHang IN (SELECT maKhachHang FROM HOADONBAN)
GROUP BY maKhachHang;


--7: Đưa ra danh sách các đầu sách và số lượng đã bán
SELECT d.maSach, d.tenSach, COUNT(*) as soLuongBan
FROM DAUSACH d
JOIN CHITIETHOADONBAN c ON d.maSach = c.maSach
GROUP BY d.maSach, d.tenSach
ORDER BY soLuongBan DESC;

--8: Đưa ra tên đầu sách được bán ngày 27/1/2023
SELECT c.maSach, d.tenSach, c.soLuong
FROM CHITIETHOADONBAN c
JOIN HOADONBAN h ON c.maHoaDonBan = h.maHoaDonBan
JOIN DAUSACH d ON c.maSach = d.maSach
WHERE CONVERT(date, h.ngayGiaoDich) = '2023-01-27'

--9: Đưa ra thông tin về đầu sách nằm trong đơn mua có giá đơn hàng >1.000.000
SELECT DISTINCT DS.maSach, DS.tenSach, DS.giaBia, DS.theLoai, CT.maSach, CT.maHoaDonBan
FROM DAUSACH DS
JOIN CHITIETHOADONBAN CT ON DS.maSach = CT.maSach
JOIN HOADONBAN HB ON CT.maHoaDonBan = HB.maHoaDonBan
WHERE HB.giaDonHang > 1000000;

--10: Mã khách chưa từng mua hàng từ ngày 12/11/2022
SELECT k.*
FROM KHACHHANG k
LEFT JOIN HOADONBAN h ON k.maKhachHang = h.maKhachHang
WHERE h.maHoaDonBan IS NULL OR h.ngayGiaoDich > '2023-01-01';

--11: Hiển thị thông tin của những đầu sách được bán nhiều nhất bởi nhân viên có mã là "1222"
SELECT ds.maSach, ds.tenSach, SUM(ct.soLuong) AS soLuongBan
FROM DAUSACH ds
JOIN CHITIETHOADONBAN ct ON ds.maSach = ct.maSach
JOIN HOADONBAN hd ON ct.maHoaDonBan = hd.maHoaDonBan
WHERE hd.maNhanVien = '1222'
GROUP BY ds.maSach, ds.tenSach
ORDER BY soLuongBan DESC

--12: Đưa ra tổng số tiền mà vị khách có mã "C03" đã chi để mua sách
SELECT SUM(CHITIETHOADONBAN.soLuong * CHITIETHOADONBAN.donGia) as TongTien
FROM HOADONBAN
JOIN KHACHHANG ON HOADONBAN.maKhachHang = KHACHHANG.maKhachHang
JOIN CHITIETHOADONBAN ON HOADONBAN.maHoaDonBan = CHITIETHOADONBAN.maHoaDonBan
WHERE KHACHHANG.maKhachHang = 'C03'

--13: Đưa ra thông tin về những đầu sách nhập từ nhà cung ứng có độ uy tín cao nhất vào ngày  22/9/2021
SELECT DAUSACH.maSach, DAUSACH.tenSach, DAUSACH.theLoai, NHACUNGUNG.tenNhaCungUng
FROM HOADONMUA
JOIN NHACUNGUNG ON HOADONMUA.maNhaCungUng = NHACUNGUNG.maNhaCungUng
JOIN CHITIETHOADONMUA ON HOADONMUA.maHoaDonMua = CHITIETHOADONMUA.maHoaDonMua
JOIN DAUSACH ON CHITIETHOADONMUA.maSach = DAUSACH.maSach
WHERE NHACUNGUNG.doUyTin = (SELECT MAX(doUyTin) FROM NHACUNGUNG)
AND HOADONMUA.ngayGiaoDich = '2021-09-22'

--14: Sắp xếp mã tác giả theo thứ tự giảm dần các lọai sách xuất bản
SELECT TACGIA.maTacGia
FROM TACGIA
JOIN BIENSOAN ON BIENSOAN.maTacGia = TACGIA.maTacGia
JOIN DAUSACH ON DAUSACH.maSach = BIENSOAN.maSach

GROUP BY TACGIA.maTacGia
ORDER BY COUNT(DAUSACH.maSach) DESC

--15: Hiển thị số điện thoại của nhân viên thực hiện giao dịch vào ngày “27/1/2023” cho khách hàng có mã “C08”
SELECT nhanvien.soDienThoai, concat(nhanvien.ho, ' ', nhanvien.ten) as hoTen, nhanvien.maNhanVien
FROM NHANVIEN nhanvien
JOIN HOADONBAN hdb ON hdb.maNhanVien = nhanvien.maNhanVien
WHERE hdb.ngayGiaoDich = '2023-01-27' AND hdb.maKhachHang = 'C08'


