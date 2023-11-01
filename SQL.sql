create database Net
go

--use master
--go
--drop database Shop
--go

use Net
go


create table PhieuNhap
(
	MaPhieuNhap varchar(10) PRIMARY KEY not null,
	NgayNhap date not null,	
	Nhacungcap nvarchar(1000) not null,
	ThanhTien int not null
)
go

create table ChiTietPhieuNhap
(
MaSanPham nvarchar(500) PRIMARY KEY not null,
MaPhieuNhap varchar(10) not null,
DonGia int not null,
SoLuong int not null,
constraint FK_ChiTietPhieuNhap_PhieuNhap foreign key (MaPhieuNhap) references PhieuNhap(MaPhieuNhap)
)
go


INSERT INTO PhieuNhap (MaPhieuNhap, NgayNhap, Nhacungcap, ThanhTien)
VALUES 
('PN00000000', '03-01-2002', 'Điện mánh xanh', 1000000);



INSERT INTO ChiTietPhieuNhap (MaSanPham, MaPhieuNhap, DonGia, SoLuong)
VALUES 