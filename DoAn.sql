create table Chovay
(
STT int IDENTITY(1,1) primary key,
NguoiVay Nvarchar(20),
SoTien int,
TaiKhoan Nvarchar(20),
MucDich Nvarchar(20),
DienGiai Nvarchar (50),
Ngay date,
)

create table Chitieu
(
STT int IDENTITY(1,1) primary key,
TenSP nvarchar(20),
SoLuong int,
SoTien int,
TaiKhoan Nvarchar(10),
MucDich Nvarchar(20),
Ngay date,
)
drop table ChiTieu
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/1/2015')
insert into ChiTieu values (N'Ăn trưa','1','20000','Ví',N'Ăn Uống','5/1/2015')
insert into ChiTieu values (N'Ăn toi','1','15000','Ví',N'Ăn Uống','5/1/2015')
insert into ChiTieu values (N'Xăng','1','40000','Ví',N'Đi Lại','5/1/2015')
insert into ChiTieu values (N'Nồi cơm điện','1','300000','Ví',N'Mua Sắm','5/1/2015')
insert into ChiTieu values (N'Ăn vặt','1','10000','ATM',N'Ăn Uống','5/1/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/2/2015')
insert into ChiTieu values (N'Ăn toi','1','15000','Ví',N'Ăn Uống','5/2/2015')
insert into ChiTieu values (N'Bịt xà phòng','1','20000','Ví',N'Mua Sắm','5/2/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/3/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/3/2015')
insert into ChiTieu values (N'Tiền nhà','1','400000','ATM',N'Phí','5/3/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/4/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/4/2015')
insert into ChiTieu values (N'Xăng','1','40000','Ví',N'Ăn Uống','5/4/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/5/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/5/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/6/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/6/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/7/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/7/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/8/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/8/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/9/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/9/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/10/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/10/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','ATM',N'Ăn Uống','5/11/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/11/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/12/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/12/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/13/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/13/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/14/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/14/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/15/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/15/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/16/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/16/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/17/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/17/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/18/2015')
insert into ChiTieu values (N'Xăng','1','50000','Ví',N'Đi Lại','5/18/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/18/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/19/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/19/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/20/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/20/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','ATM',N'Ăn Uống','5/21/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/21/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/22/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Khác',N'Ăn Uống','5/22/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','ATM',N'Ăn Uống','5/23/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Khác',N'Ăn Uống','5/23/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/24/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/24/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Sổ Tiết Kiệm',N'Ăn Uống','5/25/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/25/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/26/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/26/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/27/2015')
insert into ChiTieu values (N'Xăng','1','50000','Ví',N'Đi Lại','5/18/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/27/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/28/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/28/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/29/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/29/2015')
insert into ChiTieu values (N'Xăng','1','50000','Ví',N'Đi Lại','5/18/2015')
insert into ChiTieu values (N'Ăn tối','1','15000','Ví',N'Ăn Uống','5/30/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','ATM',N'Ăn Uống','5/30/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','5/31/2015')
insert into ChiTieu values (N'Vũng tàu','1','150000','Ví',N'Hưởng Thụ','6/1/2015')
insert into ChiTieu values (N'Quà','1','15000','Ví',N'Ăn Uống','6/1/2015')
insert into ChiTieu values (N'Khám Bệnh','1','55000','Ví',N'Sức Khỏe','6/2/2015')
insert into ChiTieu values (N'Ăn sáng','1','15000','Ví',N'Ăn Uống','6/2/2015')
insert into ChiTieu values (N'Mua sắm','1','800000','Ví',N'Mua Sắm','6/3/2015')

insert into Chovay values (N'Phạm Tuấn Anh','500000',N'Sổ Tiết Kiệm',N'Cho Vay','','5/5/2015')
insert into Chovay values (N'Trương Huy Cường','300000',N'Sổ Tiết Kiệm',N'Cho Vay','','5/17/2015')
insert into Chovay values (N'Huỳnh Thái Hòa','550000',N'Ví',N'Cho Vay','','6/1/2015')
insert into Chovay values (N'Nguyễn Thị Mỹ Linh','1000000',N'Sổ Tiết Kiệm',N'Cho Vay','','4/28/2015')
insert into Chovay values (N'Phạm Tấn Phát','900000',N'ATM',N'Cho Vay','','6/3/2015')

insert into Trano values (N'Nguyễn Thị Mỹ Linh','500000',N'Sổ Tiết Kiệm',N'Trả nợ','','5/6/2015')
insert into Trano values (N'Huỳnh Quốc Hiền','300000',N'Ví',N'Cho Vay','Trả nợ','','6/1/2015')
insert into Trano values (N'Phạm Tố Anh Đào','100000',N'Ví',N'Cho Vay','Trả nợ','','5/9/2015')

drop table Trano
drop table Chovay
CREATE TABLE DangNhap
(
	tendangnhap char(50),
	matkhau char(50) 
)

CREATE TABLE Trano
(
STT int IDENTITY(1,1) primary key,
NguoiChoVay Nvarchar(20),
SoTien int,
TaiKhoan Nvarchar(20),
MucDich Nvarchar(20),
DienGiai Nvarchar (50),
Ngay date,
)
CREATE TABLE Thuno
(
STT int IDENTITY(1,1) primary key,
NguoiVay Nvarchar(20),
SoTien int,
TaiKhoan Nvarchar(10),
MucDich Nvarchar(20),
DienGiai Nvarchar (50),
Ngay date,
)

Create table Divay
(
	STT int IDENTITY(1,1) primary key,
	NguoiChoVay Nvarchar(20),
	SoTien int,
	TaiKhoan Nvarchar(10),
	MucDich Nvarchar(20),
	DienGiai Nvarchar (50),
	Ngay date,
)

insert into DangNhap values ('admin','admin')
insert into DangNhap values ('mylinh','26252022')




