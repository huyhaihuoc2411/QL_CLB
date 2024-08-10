create database QLHOATDONG_CLB
go

use QLHOATDONG_CLB
go

create table BAN
(
	MaBan varchar(10) not null,
	TenBan nvarchar(50),
	primary key(MaBan)
)

create table THANHVIEN
(
	MaThanhVien varchar(10) not null,
	TenThanhVien nvarchar(50),
	NgaySinh Date,
	GioiTinh nvarchar(10),
	QueQuan nvarchar(50),
	Email varchar(50),
	SDT int,
	MaBan varchar(10) not null
	primary key(MaThanhVien)
)

alter table THANHVIEN alter column SDT varchar(11)

alter table THANHVIEN
add constraint fk_THANHVIEN_BAN foreign key (MaBan)
references BAN(MaBan)

create table HOATDONG
(
	MaHoatDong varchar(10) not null,
	TenHoatDong nvarchar(50),
	DiaDiem nvarchar(50),
	MaBan varchar(10) not null,
	primary key(MaHoatDong)
)

alter table HOATDONG
add constraint fk_HOATDONG_BAN foreign key (MaBan)
references BAN(MaBan)

create table CHITIEU
(
	MaBill varchar(10) not null,
	MaHoatDong varchar(10) not null,
	SoTienCanChi money,
	SoTienConLai money,
	primary key (MaBill, MaHoatdong)
)

alter table CHITIEU
add constraint fk_CHITIEU_HOATDONG foreign key (MaHoatDong)
references HOATDONG(MaHoatDong)

insert into BAN
values
('HC',N'Ban hậu cần'),
('SK',N'Ban tổ chức sự kiện'),
('NS',N'Ban nhân sự'),
('TT',N'Ban htruyền thông')

select * from BAN

set dateformat dmy

insert into THANHVIEN
values
('TV001',N'Nguyễn Văn Chiến','12/12/1999',N'Nam',N'Hà Tĩnh','egefgfgwf@gmail.com','0446556545','HC'),
('TV002',N'Lê Chí Khanh','15/02/1994',N'Nam',N'Tây Nguyên','sfswefefefew@gmail.com','0465441655','HC'),
('TV003',N'Huỳnh Công Hậu','04/02/2000',N'Nam',N'Hồ Chí Minh','rfgergreggg@gmail.com','0455444578','HC'),
('TV004',N'Lê Văn Hải','23/5/2002',N'Nam',N'Hải Phòng','dgrgrgtrhtht@gmail.com','0126589625','HC'),
('TV005',N'Nguyễn Hữu Đạt','27/6/2000',N'Nam',N'Hải Dương','dfrfefregfdvf@gmail.com','0255654586','HC'),
('TV006',N'Nguyễn Quốc Dũng','07/02/2000',N'Nam',N'Bình Định','efwefefwrfsgfe@gmail.com','0662568593','SK'),
('TV007',N'Nguyễn Thị Thanh Thùy','20/10/2002',N'Nữ',N'Hải Phòng','5yrey5tru65u@gmail.com','0222325456','SK'),
('TV008',N'Nguyễn Tiến Dũng','08/02/2000',N'Nam',N'Bình Thuận','geregergtrgbv@gmail.com','0666996795','SK'),
('TV009',N'Trần Anh Tuấn','09/02/2000',N'Nam',N'Đồng Nai','afewefwefeg@gmail.com','0533123578','SK'),
('TV010',N'Đỗ Anh Hào','17/2/2003',N'Nam',N'Tây Ninh','dfgergrththtyhtf@gmail.com','04556677889','SK'),
('TV011',N'Bùi Thiên Hạo','30/5/2001',N'Nam',N'Hồ Chí Minh','dgghthrergerg@gmail.com','0112233554','NS'),
('TV012',N'Nguyễn Văn Nguyên','28/12/1998',N'Nam',N'Hà Nội','rvgt456uuuu5@gmail.com','0588855678','NS'),
('TV013',N'Nguyễn Quốc Thắng','23/11/1997',N'Nam',N'Hà Nội','yy45ry6t6yhr@gmail.com','0231578946','NS'),
('TV014',N'Vũ Ngọc Dương','10/10/2001',N'Nam',N'Thanh Hóa','trgy5ytru56yter@gmail.com','0125489632','NS'),
('TV015',N'Hoàng Anh Tuấn','12/09/1996',N'Nam',N'Bình Định','4t4t6t54y65y@gmail.com','0456789213','NS'),
('TV016',N'Trần Thị Diễm Mi','15/9/1996',N'Nữ',N'Hải Dương','464tyty5h6thrtgert3@gmail.com','0465622456','TT'),
('TV017',N'Nguyễn Ngọc Tiền','23/11/2001',N'Nữ',N'Thanh Hóa','eregery45y54y@gmail.com','0232278945','TT'),
('TV018',N'Nguyễn Ngọc Quỳnh','06/07/1998',N'Nữ',N'Bình Định','efgwigfqgfwf@gmail.com','0559652656','TT'),
('TV019',N'Nguyễn Chí Toàn','17/7/2002',N'Nam',N'Bình Thuận','re89tu3489tu@gmail.com','0659859665','TT'),
('TV020',N'Dương Văn An','17/4/2003',N'Nam',N'Huế','hdcfefheif@gmail.com','0488956266','TT')

select * from THANHVIEN

insert into HOATDONG
values
('OLP23',N'Olympic 2023',N'Hà Nội', 'HC'),
('WC01',N'World Cup lần 5',N'Brazil','SK'),
('FF01',N'FIFA',N'Nga','NS'),
('AC01',N'AFC Cup',N'Hà Nội','TT')

select * from HOATDONG

insert into CHITIEU
values
('BL01','OLP23','20000000','120000000'),
('BL02','WC01','50000000','200000000'),
('BL03','FF01','30000000','190000000'),
('BL04','AC01','20000000','120000000')

select * from CHITIEU