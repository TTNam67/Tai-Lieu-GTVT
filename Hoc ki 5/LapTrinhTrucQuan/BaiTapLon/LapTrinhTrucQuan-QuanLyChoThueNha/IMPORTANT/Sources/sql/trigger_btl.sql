use QLChoThueNha_BTL
---1. Trường Dathue trong bảng Danhmucnha được tự động cập nhật khi có khách thuê nhà và trả nhà
create or alter trigger Capnhatkhithue
on ThueNha
for insert, update
as begin
	update Danhmucnha set Dathue =1 from inserted
	where GETDATE() between inserted.NgayBD and inserted.NgayKT
	and Danhmucnha.Manha = inserted.Manha
end
select * from DanhMucNha where MaNha='MN001'
select * from ThueNha where MaNha='MN001'
update ThueNha set NgayKT= '2024-05-05 00:00:00.000' where MaSoThue= 'MT003'
----2024-05-05 00:00:00.000
select * from TraNha where MaSoThue = 'MT003' 
---2024-05-05 00:00:00.000
update TraNha set NgayTra = '2024-05-05 00:00:00.000' where MaSoThue = 'MT003'

create or alter trigger Capnhatkhitra
on TraNha
for insert, update
as begin
	declare @masothue nvarchar(10), @ngaytra datetime
	select @masothue = Masothue, @ngaytra = Ngaytra from inserted
	update Danhmucnha set Dathue =0 from inserted join Thuenha
	on Thuenha.Masothue = inserted.Masothue
	where GETDATE() > inserted.Ngaytra
	and Danhmucnha.Manha = Thuenha.Manha
	---------
	--update Danhmucnha set Dathue =1 from inserted join Thuenha
	--on Thuenha.Masothue = inserted.Masothue
	--where GETDATE() < inserted.Ngaytra
	--and Danhmucnha.Manha = Thuenha.Manha
end


--2. Manha trong bảng Thuenha chỉ hiển thị danh sách các danh mục nhà chưa được thuê.		
----cai nay trong combobox neu bon cua ThueNha
select MaNha from DanhMucNha where DaThue =0
--3. Trong bảng Thutiennha: Tongtien được tính bằng Số tháng * Đơn giá thuê;									
--(số tháng dựa vào hình thức thanh toán, Đơn giá thuê lấy trong bảng danh mục nhà)
create or alter trigger hoadon
on Thutiennha
for insert, update
as begin
	update ThuTienNha set TongTien = 
	(
	select
		(case   [TenHinhThucTT]
		when N'1 năm' then 12
		when N'1 tháng' then 1
		when N'3 tháng' then 3
		end 
		) * DanhMucNha.DonGiaThue
		from HinhThucThanhToan join Thuenha
		on Thuenha.MaHinhThucTT = HinhThucThanhToan.MaHinhThucTT
		join inserted on inserted.MaSoThue = Thuenha.Masothue
		join DanhMucNha on DanhMucNha.MaNha = ThueNha.MaNha
	)
	from inserted
	where ThuTienNha.MaSoThu = inserted.MaSoThu
end
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST111', N'MT007', N'12', N'2021', N'Nguyễn Thanh Toàn', CAST(N'2021-07-05T00:00:00.000' AS DateTime), NULL)

--4. Bảng Trả nhà chỉ hiển thị danh sách các mã số thuê chưa trả 
select * from TraNha where NgayTra > GETDATE()				
--Trigger
--1. Trường Dathue trong bảng Danhmucnha được tự động cập nhật khi có khách thuê nhà và trả nhà
 
--Querry
--1. Tìm nhà trọ theo:
--- Ko có gì
--- Loại nhà
--- Loại đối tượng
--- Địa chỉ
--2. Tìm kiếm khách hàng theo:
--- Tên khách
--- Địa chỉ
--- Nghề nghiệp
--3. Báo cáo tổng tiền đã thu được theo từng mã nhà
select ThueNha.MaNha, sum(ThuTienNha.TongTien) as tongtien from ThuTienNha join ThueNha
on ThueNha.MaSoThue = ThuTienNha.MaSoThue 
group by ThueNha.MaNha
--4. Báo cáo danh sách các nhà chưa thanh toán tiền thuê trong tháng hiện tại
---tim cac ma nha va masothue hien tai dang thue
select Manha from Danhmucnha where Dathue=1
---b1 : tính so thang tu ngay bat dau den hien tai
--5. Tổng doanh thu theo tháng (Bao gồm cột tiền nhận và tiền chi)
----tach rieng 2 cot ra di m tinh chung k biet lam
SELECT 
isnull(sum(case month (NgayThu) when 1 then ThuTienNha.TongTien end),0) AS Thang1,
isnull(sum(case month (NgayThu) when 2 then ThuTienNha.TongTien end),0) AS Thang2,
isnull(sum(case month (NgayThu) when 3 then ThuTienNha.TongTien end),0) AS Thang3,
isnull(sum(case month (NgayThu) when 4 then ThuTienNha.TongTien end),0) AS Thang4,
isnull(sum(case month (NgayThu) when 5 then ThuTienNha.TongTien end),0) AS Thang5,
isnull(sum(case month (NgayThu) when 6 then ThuTienNha.TongTien end),0) AS Thang6,
isnull(sum(case month (NgayThu) when 7 then ThuTienNha.TongTien end),0) AS Thang7,
isnull(sum(case month (NgayThu) when 8 then ThuTienNha.TongTien end),0) AS Thang8,
isnull(sum(case month (NgayThu) when 9 then ThuTienNha.TongTien end),0) AS Thang9,
isnull(sum(case month (NgayThu) when 10 then ThuTienNha.TongTien end),0) AS Thang10,
isnull(sum(case month (NgayThu) when 11 then ThuTienNha.TongTien end),0) AS Thang11,
isnull(sum(case month (NgayThu) when 12 then ThuTienNha.TongTien end),0) AS Thang12,
isnull(sum(ThuTienNha.TongTien),0) AS Canam
FROM ThuTienNha
SELECT 
isnull(sum(case month (NgayTra) when 1 then Tranha.TongTien end),0) AS Thang1,
isnull(sum(case month (NgayTra) when 2 then Tranha.TongTien end),0) AS Thang2,
isnull(sum(case month (NgayTra) when 3 then Tranha.TongTien end),0) AS Thang3,
isnull(sum(case month (NgayTra) when 4 then Tranha.TongTien end),0) AS Thang4,
isnull(sum(case month (NgayTra) when 5 then Tranha.TongTien end),0) AS Thang5,
isnull(sum(case month (NgayTra) when 6 then Tranha.TongTien end),0) AS Thang6,
isnull(sum(case month (NgayTra) when 7 then Tranha.TongTien end),0) AS Thang7,
isnull(sum(case month (NgayTra) when 8 then Tranha.TongTien end),0) AS Thang8,
isnull(sum(case month (NgayTra) when 9 then Tranha.TongTien end),0) AS Thang9,
isnull(sum(case month (NgayTra) when 10 then Tranha.TongTien end),0) AS Thang10,
isnull(sum(case month (NgayTra) when 11 then Tranha.TongTien end),0) AS Thang11,
isnull(sum(case month (NgayTra) when 12 then Tranha.TongTien end),0) AS Thang12,
isnull(sum(Tranha.TongTien),0) AS Canam
FROM Tranha
select * from Tranha


--6. Tổng doanh thu theo năm (Bao gồm cột tiền nhận và tiền chi)
---tien chi = tranha.tong tien = tiendatcoc(neu tra nha truoc thoi han thi =0) - sum(tranha_mattaisan.thanhtien(soluong+giatri))
---trigger tu dong cap nhat cot thanh tien
create or alter trigger thanhtien_matts 
on TraNha_MatTaiSan
for insert, update
as begin
	update TraNha_MatTaiSan set ThanhTien = SoLuong* GiaTri
end
---trigger tu dong cap nhat cot tong tien
create or alter trigger Tongtien_tranha
on TraNha_MatTaiSan
for insert, update, delete
as begin
	declare @masothue1 [nvarchar](10), @mats1 [nvarchar](10),
	@masothue2 [nvarchar](10), @mats2 [nvarchar](10), @tongtien int

	select @masothue1 = MaSoThue, @mats1= MaTaiSan from inserted
	select @masothue2 = MaSoThue, @mats2= MaTaiSan from deleted

	select @tongtien = sum(TraNha_MatTaiSan.ThanhTien
	+ 
	(case
		when ThueNha.NgayKT> TraNha.NgayTra then 0
		else ThueNha.TienDatCoc
	end
	)
	) from TraNha_MatTaiSan
	join ThueNha on ThueNha.MaSoThue = TraNha_MatTaiSan.MaSoThue
	join TraNha on TraNha.MaSoThue = TraNha_MatTaiSan.MaSoThue
	where TraNha_MatTaiSan.MaSoThue = isnull(@masothue1,@masothue2)

	update TraNha set TongTien = @tongtien where TraNha.MaSoThue = isnull(@masothue1,@masothue2)

end
INSERT [dbo].[TraNha_MatTaiSan] ([MaSoThue], [MaTaiSan], [SoLuong], [GiaTri], [ThanhTien]) VALUES (N'MT001', N'TS010', 2, 6000000.00, 6000000.00)
update TraNha_MatTaiSan set SoLuong = 3 where MaSoThue = 'MT001' and MaTaiSan = 'TS010'
select * from TraNha
select * from TraNha_MatTaiSan where MaSoThue='MT001'

-----doanh thu theo nam
select B.Nam, A.tiennhan, B.tienchi
from
(select year(ThuTienNha.NgayThu) as Nam, sum(ThuTienNha.TongTien) as tiennhan from ThuTienNha
group by year(ThuTienNha.NgayThu))A
full join(
select YEAR(TraNha.NgayTra) as Nam, sum(isnull(Tranha.TongTien,0)) as tienchi from TraNha
group by YEAR(TraNha.NgayTra))B
on A.Nam = B.Nam
