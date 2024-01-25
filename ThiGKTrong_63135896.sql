create table TINH_THANHPHO(
	Matinh varchar(10) primary key,
	Tentinh nvarchar(10),
	Ghichu nvarchar(20),
);

create table DIEMDULICH(
	Madiemdl varchar(10) primary key,
	Tendiemdl nvarchar(20),
	Ngaycapnhat Date,
	Mota nvarchar(20),
	Anhdaidien nvarchar(max),
	Matinh_Thanhpho varchar(10) foreign key references TINH_THANHPHO(Matinh),
);