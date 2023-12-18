USE QuanLyHieuSach


INSERT INTO TACGIA(maTacGia, tenTacGia, quocTich, ngaySinh, gioiTinh)
VALUES ('TG01', N'Nguyễn Dữ', N'Việt Nam', '1949-09-01', 'Nam'),
('TG02', 'Tim Marshall', 'Anh', '1959-07-01', 'Nam'),
('TG03', 'John Green', N'Mỹ', '1977-08-24', 'Nam'),
('TG04', 'Ernst Gombrich', N'Áo', '1909-03-30', 'Nam'),
('TG05', 'Donna Tartt', N'Mỹ', '1963-12-23', N'Nữ'),
('TG06', 'Harper Lee', N'Mỹ', '1926-04-28', N'Nữ'),
('TG07', 'Marc Levy', N'Pháp', '1961-10-16', 'Nam'),
('TG08', 'Mario Puzo', N'Mỹ', '1920-10-15', 'Nam'),
('TG09', 'Francis Scott Key Fitzgerald', N'Mỹ', '1896-09-24', 'Nam'),
('TG10', 'Mary Shelley', 'Anh', '1797-08-30', N'Nữ'),
('TG11', 'Glendy Vanderah', N'Mỹ', '1983-02-02', N'Nữ'),
('TG12', N'Nguyễn Phương Mai', N'Việt Nam', '1976-11-27', N'Nữ');

INSERT INTO NHACUNGUNG(maNhaCungUng, tenNhaCungUng, doUyTin, soDienThoai, email)
VALUES ('SUP01', 'OmegaPlus', 9, '0976387466', 'omegaPlus@gmail.com'),   
	   ('SUP02', N'Nhã Nam', 10, '0918372712', 'nhaNamdz@gmail.com'),	
	   ('SUP03', 'Fahasa', 8, '0901827436', 'fahasa123@gmail.com');

INSERT INTO KHACHHANG(maKhachHang, ho, ten, soDienThoai)
VALUES ('C01', N'Thục Hữu', N'Hiệp', '0565968271'),
	   ('C02', N'Giáp Phúc', N'Sinh', '0965352169'),
	   ('C03', N'Bì Hiền', N'Chung', '0599087425'),
	   ('C04', N'Phạm Thanh', N'Hải', '0852604138'),
	   ('C05', N'Nguyễn Thế', N'Phương', '0371246896'),
	   ('C06', N'Ngô Quốc', N'Thắng', '0580624735'),
	   ('C07', N'Nguyễn Huy', N'Đức', '0989805261'),
	   ('C08', N'Ngô Quốc', N'Toàn', '0986142357'),
	   ('C09', N'Nguyễn Văn', N'Quyết', '0977001912'),
	   ('C10', N'Trịnh Kim', N'Oanh', '0882327165'),
	   ('C11', N'Nguyễn Yến', N'Vy', '0986365371'),
	   ('C12', N'Nguyễn Anh', N'Tuấn', '0866677975');

INSERT INTO NHANVIEN(maNhanVien, ho, ten, soDienThoai, luong)
VALUES ('1220', 'Nguy The', 'Quang', '0852271393', 4500000),
	   ('1221', 'Nguyen The', 'Quan', '0865712341', 4500000),
	   ('1222', 'Trinh Thanh', 'Nam', '0986118332', 6000000),
	   ('1223', 'Nguyen Vu Tuan', 'Anh', '0989877872', 4000000),
	   ('1224', 'Vu The', 'Nguyen', '0832351272', 4000000);

INSERT INTO DAUSACH(maSach, tenSach, giaBia, theLoai, ngayXuatBan, soLuongTonKho, soTrang)
VALUES ('TV01', N'Truyền kì mạn lục giải âm', 179000, N'Tản văn', '2010-03-08', 12, 576),	-- Omega
	   ('TV02', N'Những tù nhân của địa lý', 210000, N'Kiến thức tổng hợp', '2020-12-11', 76, 430), -- Nha Nam
	   ('TV03', N'Chia rẽ', 200000, N'Kiến thức tổng hợp', '2021-03-01', 18, 396), --Nha Nam
	   ('TV04', N'The Story of Art - Câu chuyện nghệ thuật', 1199000, N'Nghệ thuật', '2020-09-15', 54, 692), -- Omega
	   ('TV05', N'Giết con chim nhại', 150000, N'Trinh Thám', '2018-12-01', 34, 419), -- Nha Nam
	   ('TV06', N'Mạnh Hơn Sợ Hãi', 195000, N'Tiểu thuyết', '2018-02-28', 49, 358), -- Nha Nam
	   ('TV07', 'Ghost In love', 125000, N'Ngôn Tình', '2020-08-18', 121, 328), -- Nha Nam
	   ('TV08', N'Nơi khu rừng chạm tới những vì sao', 325000, N'Phiêu lưu', '2020-11-01', 50, 508), -- Nha Nam

	   ('TA01', 'The Fault In Our Stars', 240000, N'Tình cảm', '2013-01-04', 27, 336), -- Fahasha
	   ('TA02', 'The Goldfinch', 470000, N'Văn học', '2015-10-19', 16, 880), -- 
	   ('TA03', 'The Godfather', 325000, N'Giả tưởng hình sự', '2009-07-22', 20, 595), -- Fahasha
	   ('TA04', 'The Great Gatsby', 150000, N'Văn học', '2001-11-07', 39, 112), -- Fahasha
	   ('TA05', 'Frankenstein', 345000, N'Kinh dị giả tưởng', '1818-01-01', 100, 352); -- Fahasha

INSERT INTO HOADONBAN(maHoaDonBan, maKhachHang, maNhanVien, ngayGiaoDich, giaDonHang)
VALUES ('HN01', 'C10', '1220', '2022-05-10', 300000),
	   ('HN02', 'C03', '1220', '2022-07-04', 820000),
	   ('HN03', 'C07', '1223', '2022-08-29', 1640000),
	   ('HN04', 'C01', '1220', '2022-09-22', 410000),
	   ('HN05', 'C09', '1222', '2022-12-05', 470000),
	   ('HN06', 'C06', '1220', '2023-01-19', 1199000),
	   ('HN07', 'C02', '1221', '2023-01-18', 569000),
	   ('HN08', 'C08', '1221', '2023-01-27', 1185000),
	   ('HN09', 'C03', '1224', '2023-03-09', 345000),
	   ('HN10', 'C12', '1222', '2023-03-22', 450000),
	   ('HN11', 'C04', '1223', '2023-02-28', 945000),
	   ('HN12', 'C05', '1224', '2023-03-22', 1873000);

INSERT INTO HOADONMUA(maHoaDonMua, maNhaCungUng, ngayGiaoDich, giaDonHang)
VALUES ('HNB01', 'SUP01', '2021-09-22', 57750000), -- Omega: Goldflinch
	   ('HNB02', 'SUP01', '2021-09-22', 100000000), -- Omega: Truyền kì mạn lục
	   ('HNB03', 'SUP01', '2021-09-22', 24000000), -- Omega: The Story of Art
	   ('HNB04', 'SUP02', '2021-09-22', 50000000), -- Nhã Nam: Ghost In love
	   ('HNB05', 'SUP02', '2021-11-14', 87500000), -- Nhã Nam: Giết con chim nhại
	   ('HNB06', 'SUP02', '2021-11-14', 45000000), -- Nhã Nam: Những tù nhân của địa lý
	   ('HNB07', 'SUP03', '2021-11-14', 25000000), -- Fahasha: Frankenstein
	   ('HNB08', 'SUP03', '2021-11-14', 60000000), -- Fahasha: The Godfather
	   ('HNB09', 'SUP02', '2022-02-19', 105000000), -- Nhã Nam: Chia rẽ
	   ('HNB10', 'SUP03', '2022-02-19', 45000000), -- Fahasha: The Great Gatsby
	   ('HNB11', 'SUP03', '2022-02-19', 40000000), -- Fahasha: The Fault In Our Stars
	   ('HNB12', 'SUP02', '2022-02-19', 67500000); -- Nhã Nam: Mạnh Hơn Sợ Hãi




INSERT INTO BIENSOAN(maTacGia, maSach)
VALUES ('TG01', 'TV01'),
	   ('TG02', 'TV02'),
	   ('TG02', 'TV03'),
	   ('TG03', 'TA01'),
	   ('TG04', 'TV04'),
	   ('TG05', 'TA02'),
	   ('TG06', 'TV05'),
	   ('TG07', 'TV06'),
	   ('TG07', 'TV07'),
	   ('TG08', 'TA03'),
	   ('TG09', 'TA04'),
	   ('TG10', 'TA05'),
	   ('TG11', 'TV08');

INSERT INTO CHITIETHOADONBAN(maHoaDonBan, maSach, soLuong, donGia)
VALUES ('HN01', 'TA04', 1, 150000),
	   ('HN01', 'TV05', 1, 150000),
	   ('HN02', 'TA05', 1, 345000),
	   ('HN02', 'TA04', 1, 150000),
	   ('HN02', 'TA03', 1, 325000),
	   ('HN03', 'TV02', 4, 200000),
	   ('HN03', 'TV03', 4, 210000),
	   ('HN04', 'TV02', 1, 210000),
	   ('HN04', 'TV03', 1, 200000),
	   ('HN05', 'TA02', 1, 470000),
	   ('HN06', 'TV04', 1, 1199000),
	   ('HN07', 'TV01', 1, 179000),
	   ('HN07', 'TA01', 1, 200000),
	   ('HN07', 'TA04', 1, 150000),
	   ('HN08', 'TA01', 1, 240000),
	   ('HN08', 'TA02', 1, 470000),
	   ('HN08', 'TA03', 1, 325000),
	   ('HN08', 'TA04', 1, 150000),
	   ('HN09', 'TA05', 1, 345000),
	   ('HN10', 'TV07', 1, 125000),
	   ('HN10', 'TA03', 1, 325000),
	   ('HN11', 'TV06', 1, 195000),
	   ('HN11', 'TV07', 1, 125000),
	   ('HN11', 'TA04', 1, 150000),
	   ('HN11', 'TV08', 1, 325000),
	   ('HN11', 'TV05', 1, 150000),
	   ('HN12', 'TA05', 1, 345000),
	   ('HN12', 'TV01', 1, 179000),
	   ('HN12', 'TV04', 1, 1199000),
	   ('HN12', 'TV05', 1, 150000);

INSERT INTO CHITIETHOADONMUA(maHoaDonMua, maSach, soLuong, donGia)
VALUES ('HNB01', 'TA02', 165, 350000), -- Omega: Goldflinch
       ('HNB02', 'TV01', 250, 400000), -- Omega: Truyền kì mạn lục
       ('HNB03', 'TV04', 120, 200000), -- Omega: The Story of Art
       ('HNB04', 'TV07', 200, 250000), -- Nhã Nam: Ghost In love
       ('HNB05', 'TV05', 250, 350000), -- Nhã Nam: Giết con chim nhại
       ('HNB06', 'TV02', 300, 150000), -- Nhã Nam: Những tù nhân của địa lý
       ('HNB07', 'TA05', 100, 250000), -- Fahasha: Frankenstein
       ('HNB08', 'TA03', 200, 300000), -- Fahasha: The Godfather
       ('HNB09', 'TV03', 300, 200000), -- Nhã Nam: Chia rẽ
       ('HNB10', 'TA04', 300, 350000), -- Fahasha: The Great Gatsby
       ('HNB11', 'TA01', 200, 200000), -- Fahasha: The Fault In Our Stars
       ('HNB12', 'TV06', 150, 450000); -- Nhã Nam: Mạnh Hơn Sợ Hãi



