﻿--1 Cho biết danh sách các đối tác cung cấp hàng cho công ty
Select MACONGTY, TENCONGTY
from NHACUNGCAP

--2 Mã hàng, tên hàng và số lượng hiện có trong công ty
Select MAHANG, TENHANG, SOLUONG
from MATHANG

--3 Địa chỉ, số điện thoại của nhà cung cấp có tên giao dịch VINAMILK là gì?
Select DIACHI, DIENTHOAI
from NHACUNGCAP
where TENGIAODICH = 'VINAMILK'

--4 Cho biết mã và tên các mặt hàng có giá lơn hơn 100000 và số lượng hiện có ít hơn 50
Select MAHANG, TENHANG 
from MATHANG
where SOLUONG < 50 and GIAHANG > 100000

--5 Đơn đặt hàng số 1 do ai đặt, do nhân viên nào lập, thời gian và địa điểm giao hàng ở đâu?
Select DONDATHANG.NGAYGIAOHANG, DONDATHANG.NOIGIAOHANG, KHACHHANG.MAKHACHHANG, KHACHHANG.TENCONGTY, NHANVIEN.MANHANVIEN, NHANVIEN.HO, NHANVIEN.TEN
from ((KHACHHANG INNER JOIN DONDATHANG 
     ON KHACHHANG.MAKHACHHANG = DONDATHANG.MAKHACHHANG) INNER JOIN NHANVIEN
     ON DONDATHANG.MANHANVIEN = NHANVIEN.MANHANVIEN)
WHERE SOHOADON = 1

--6 Hiển thị những nhân viên có lương cơ bản cao nhất công ty
Select MANHANVIEN, HO, TEN
From NHANVIEN 
where LUONGCOBAN = (Select Max(LUONGCOBAN) from NHANVIEN);

--7 Nhân viên nào trong công ty bán được nhiều hàng nhất và số lượng bán được là bao nhiêu?
SELECT TOP 1 n.HO, n.TEN, SUM(c.SOLUONG) AS TONGSOLUONGBAN
FROM DONDATHANG d
JOIN NHANVIEN n ON d.MANHANVIEN = n.MANHANVIEN
JOIN CHITIETDATHANG c ON d.SOHOADON = c.SOHOADON
GROUP BY n.HO, n.TEN
ORDER BY TONGSOLUONGBAN DESC;

--8 Hãy cho biết tổng số hàng của mỗi loại hàng
SELECT MAHANG, SUM(SOLUONG) as TONG_SOLUONG
FROM MATHANG
GROUP BY MAHANG;

--9 Tăng lương lên 50% cho những nhân viên bán được số lượng hàng >=100 trong năm 2023
SELECT NHANVIEN.MANHANVIEN,NHANVIEN.LUONGCOBAN, SUM(TONGSL) AS TONGSP INTO CHECK1 
FROM NHANVIEN,
	(SELECT CHITIETDATHANG.SOHOADON, SUM(SOLUONG) AS TONGSL,DONDATHANG.MANHANVIEN 
		FROM CHITIETDATHANG, DONDATHANG
	WHERE CHITIETDATHANG.SOHOADON = DONDATHANG.SOHOADON
	GROUP BY CHITIETDATHANG.SOHOADON, DONDATHANG.MANHANVIEN) t
	WHERE NHANVIEN.MANHANVIEN = T.MANHANVIEN
	GROUP BY NHANVIEN.MANHANVIEN,NHANVIEN.LUONGCOBAN
	HAVING SUM(TONGSL)>=100;
---SELECT * FROM CHECK1
UPDATE NHANVIEN
SET NHANVIEN.LUONGCOBAN = NHANVIEN.LUONGCOBAN * 1.5
FROM NHANVIEN FULL JOIN CHECK1
ON NHANVIEN.MANHANVIEN = (SELECT MANHANVIEN FROM CHECK1);

Select *
from NHANVIEN

--11 Xóa khỏi bảng NHANVIEN những nhân viên đã làm việc cho công ty trên 40 năm
Delete from NHANVIEN
where Datediff(day, NGAYLAMVIEC, Getdate()) > 14600

Select *
from NHANVIEN

--12 Xóa những đơn hàng có ngày đặt hàng trước năm 2020 ra khỏi CSDL
BEGIN TRANSACTION;
DELETE FROM CHITIETDATHANG WHERE SOHOADON IN (SELECT SOHOADON FROM DONDATHANG WHERE NGAYDATHANG < '2020-01-01');
DELETE FROM DONDATHANG WHERE NGAYDATHANG < '2020-01-01';
COMMIT;

Select *
from DONDATHANG