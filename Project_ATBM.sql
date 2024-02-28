--drop table phancong;
--drop table dangky;
--drop table khmo;
--drop table hocphan;
--alter table donvi drop constraint FK_DONVI_TRGDV;
--alter table nhansu drop constraint FK_NHANSU_MADV;
--drop table donvi;
--drop table nhansu;
--drop table sinhvien;
CREATE TABLE sys.NHANSU(
    MANV CHAR(5) NOT NULL,
    HOTEN NVARCHAR2(50) NOT NULL,
    PHAI CHAR(1) NOT NULL,
    NGSINH DATE,
    PHUCAP NUMBER,
    DT VARCHAR2(12),
    VAITRO NVARCHAR2(20) NOT NULL,
    MADV CHAR(5),
    CHECK (PHAI IN ('M','F')),
    PRIMARY KEY(MANV)
);

CREATE TABLE SYS.SINHVIEN(
    MASV CHAR(5) NOT NULL,
    HOTEN NVARCHAR2(50) NOT NULL,
    PHAI CHAR(1) NOT NULL,
    NGSINH DATE,
    DCHI NVARCHAR2(100),
    DT VARCHAR2(12),
    MACT VARCHAR(5) NOT NULL,
    MANGANH VARCHAR(5) NOT NULL,
    SOTCTL INTEGER NOT NULL,
    DTBTL NUMBER NOT NULL,
    CHECK (MACT IN ('CQ','CTTT','CLC','VP')),
    CHECK (PHAI IN ('M','F')),
    PRIMARY KEY(MASV)
);

CREATE TABLE SYS.DONVI(
    MADV CHAR(5) not null,
    TENDV NVARCHAR2(50) NOT NULL,
    TRGDV CHAR(5),
    PRIMARY KEY(MADV),
    CONSTRAINT FK_DONVI_TRGDV FOREIGN KEY (TRGDV) REFERENCES NHANSU (MANV)
);

CREATE TABLE SYS.HOCPHAN(
    MAHP CHAR(8) NOT NULL,
    TENHP NVARCHAR2(50) NOT NULL,
    SOTC INTEGER NOT NULL,
    STLT INTEGER NOT NULL,
    STTH INTEGER NOT NULL,
    SOSVTD INTEGER NOT NULL,
    MADV CHAR(5) NOT NULL,
    PRIMARY KEY(MAHP),
    CONSTRAINT FK_HOCPHAN_MADV FOREIGN KEY (MADV) REFERENCES DONVI (MADV)
);

CREATE TABLE SYS.KHMO(
    MAHP CHAR(8) NOT NULL,
    HK INTEGER NOT NULL,
    NAM INTEGER NOT NULL,
    MACT VARCHAR(4) NOT NULL,
    CHECK (MACT IN ('CQ','CTTT','CLC','VP')),
    PRIMARY KEY(MAHP, HK, NAM, MACT),
    CONSTRAINT FK_KHMO_MAHP FOREIGN KEY (MAHP) REFERENCES HOCPHAN (MAHP)
);

CREATE TABLE SYS.PHANCONG(
    MAGV CHAR(5) NOT NULL,
    MAHP CHAR(8) NOT NULL,
    HK INTEGER NOT NULL,
    NAM INTEGER NOT NULL,
    MACT VARCHAR(4) NOT NULL,
    PRIMARY KEY(MAGV, MAHP, HK, NAM, MACT),
    CONSTRAINT FK_PHANCONG_MAGV FOREIGN KEY (MAGV) REFERENCES NHANSU (MANV),
    CONSTRAINT FK_PHANCONG_KHMO FOREIGN KEY (MAHP, HK, NAM, MACT) 
    REFERENCES KHMO (MAHP, HK, NAM, MACT)
);

CREATE TABLE SYS.DANGKY(
    MASV CHAR(5) NOT NULL,
    MAHP CHAR(8) NOT NULL,
    HK INTEGER NOT NULL,
    NAM INTEGER NOT NULL,
    MACT VARCHAR(4) NOT NULL,
    DIEMTH NUMBER(2),
    DIEMQT NUMBER(2),
    DIEMCK NUMBER(2),
    DIEMTK NUMBER(2),
    PRIMARY KEY(MASV, MAHP, HK, NAM, MACT),
    CONSTRAINT FK_DANGKY_MASV FOREIGN KEY (MASV) REFERENCES SINHVIEN (MASV),
    CONSTRAINT FK_DANGKY_KHMO FOREIGN KEY (MAHP, HK, NAM, MACT) 
    REFERENCES KHMO (MAHP, HK, NAM, MACT)
);
alter table nhansu add CONSTRAINT FK_NHANSU_MADV FOREIGN KEY (MADV) REFERENCES DONVI (MADV)

//SINHVIEN
insert into sinhvien values ('SV001',N'Lê Nhất Tiến','M',DATE '2003-05-03',N'106 Thoại Ngọc Hầu, Hoà Thanh, Tân Phú','0936472835','CLC','HTTT',45,7.43);
insert into sinhvien values ('SV002',N'Phan Phước Thiện','M',DATE '2002-01-12',N'95 Lê Ngân, Phường 12, Tân Bình','0767569845','CLC','CNTT',51,6.57);
insert into sinhvien values ('SV003',N'Nguyễn Ðông Vy','F',DATE '2004-04-22',N'112 Đ. Hà Thị Đát, Tân Sơn Nhì, Tân Phú','0918654825','CLC','KHMT',47,7.75);
insert into sinhvien values ('SV004',N'Hồ Minh Yến','F',DATE '2003-02-13',N'283 Lý Thường Kiệt, Phường 15, Quận 11','0973564864','CQ','CNPM',46,5.43);
insert into sinhvien values ('SV005',N'Đoàn Huy Anh','M',DATE '2003-03-25',N'306B Đ. Điện Biên Phủ, Phường 4, Quận 3','0756856157','CQ','TGMT',41,7.23);
insert into sinhvien values ('SV006',N'Đỗ Tiến Ðức','M',DATE '2002-06-07',N'173 Đ. Cao Thắng, Phường 12, Quận 10','0896532647','VP','MTT',49,8.12);
insert into sinhvien values ('SV007',N'Tống Hà Thanh','F',DATE '2004-09-09',N'224 Đ. Thành Thái, Phường 14, Quận 10','0798635214','VP','HTTT',52,8.22);
insert into sinhvien values ('SV008',N'Châu Nhật Dũng','M',DATE '2002-10-21',N'316 Đ. An Dương Vương, Phường 4, Quận 5','0458635269','VP','CNTT',40,6.26);
insert into sinhvien values ('SV009',N'Cao Phúc Hòa','M',DATE '2001-11-19',N'594 Đ. 3 Tháng 2, Phường 14, Quận 10','0846352175','CTTT','CNPM',46,8.78);
insert into sinhvien values ('SV010',N'Trần Thảo My','F',DATE '2002-12-25',N'523 Đ. Âu Cơ, Phú Trung, Tân Phú','0919154685','CTTT','TGMT',49,9.12);

//NHANSU
insert into nhansu values ('NV001','Lê Bảo Tín','M',DATE '1990-07-18',1000,'0986514365',N'Trưởng khoa',null);

insert into nhansu values ('NV002','Nguyễn Khải Tâm','M',DATE '1991-02-11',500,'0768568452',N'Trưởng đơn vị',null);
insert into nhansu values ('NV003','Đoàn Thiên An','M',DATE '1989-07-17',400,'0987654321',N'Trưởng đơn vị',null);
insert into nhansu values ('NV004','Huỳnh Trà My','F',DATE '1988-11-05',600,'0968547123',N'Trưởng đơn vị',null);

insert into nhansu values ('NV005','Đặng Thanh Hà','F',DATE '1988-10-07',700,'0857469321',N'Giáo vụ',null);
insert into nhansu values ('NV006','Võ Khánh Hải','M',DATE '1987-12-03',500,'0569832147',N'Giáo vụ',null);

insert into nhansu values ('NV007','Nguyễn Phú Ân','M',DATE '1985-04-21',400,'0654823971',N'Nhân viên cơ bản',null);
insert into nhansu values ('NV015','Đỗ Duy Bảo','M',DATE '1987-01-11',400,'0489654231',N'Nhân viên cơ bản',null);

insert into nhansu values ('NV008','Bùi Chí Bảo','M',DATE '1992-01-25',300,'0485697123',N'Giảng viên',null);
insert into nhansu values ('NV009','Lý Mỹ Huệ','F',DATE '1991-02-19',500,'0563289471',N'Giảng viên',null);
insert into nhansu values ('NV010','Nguyễn Thu Loan','F',DATE '1993-05-09',500,'0876495312',N'Giảng viên',null);
insert into nhansu values ('NV011','Nguyễn Bảo Thái','M',DATE '1992-11-17',500,'0549763128',N'Giảng viên',null);
insert into nhansu values ('NV012','Bùi Quang Triều','M',DATE '1987-01-11',400,'0546798312',N'Giảng viên',null);
insert into nhansu values ('NV013','Nguyễn Bảo Thoa','F',DATE '1986-08-15',500,'0316427895',N'Giảng viên',null);
insert into nhansu values ('NV014','Ngô Chí Nam','M',DATE '1981-03-16',400,'0549768255',N'Giảng viên',null);

//DONVI
insert into donvi values ('VPK',N'Văn phòng khoa','NV001');
insert into donvi values ('HTTT',N'Bộ môn HTTT','NV002');
insert into donvi values ('CNPM',N'Bộ môn CNPM','NV003');
insert into donvi values ('KHMT',N'Bộ môn KHMT',null);
insert into donvi values ('CNTT',N'Bộ môn CNTT','NV004');
insert into donvi values ('TGMT',N'Bộ môn TGMT',null);
insert into donvi values ('MMT',N'Bộ môn MMT và Viễn thông',null);

//update NHANSU
update nhansu set MADV='VPK' where MANV in ('NV001','NV005','NV006','NV008');
update nhansu set MADV='HTTT' where MANV in ('NV002','NV009');
update nhansu set MADV='CNPM' where MANV in ('NV003','NV010');
update nhansu set MADV='KHMT' where MANV in ('NV011','NV007');
update nhansu set MADV='CNTT' where MANV in ('NV012','NV004');
update nhansu set MADV='TGMT' where MANV in ('NV013');
update nhansu set MADV='MMT' where MANV in ('NV014','NV015');

//HOCPHAN
insert into hocphan values ('CSC12002',N'Cơ sở dữ liệu nâng cao',4,45,30,45,'HTTT');
insert into hocphan values ('CSC12003',N'Hệ quản trị cơ sở dữ liệu',4,45,30,45,'HTTT');
insert into hocphan values ('CSC12004',N'Phân tích thiết kế hệ thống thông tin',4,45,30,45,'HTTT');

insert into hocphan values ('CSC13003',N'Kiểm thử phần mềm',4,45,30,45,'CNPM');
insert into hocphan values ('CSC13006',N'Quản lý dự án phần mềm',4,45,30,45,'CNPM');
insert into hocphan values ('CSC13008',N'Phát triển ứng dụng web',4,45,30,45,'CNPM');

insert into hocphan values ('CSC14002',N'Các hệ cơ sở tri thức',4,45,30,45,'KHMT');
insert into hocphan values ('CSC14004',N'Khai thác dữ liệu và ứng dụng',4,45,30,45,'KHMT');
insert into hocphan values ('CSC14101',N'Ẩn dữ liệu và chia sẻ thông tin',4,45,30,45,'KHMT');

insert into hocphan values ('CSC16001',N'Đồ họa máy tính',4,45,30,45,'TGMT');
insert into hocphan values ('CSC16003',N'Phân tích thống kê dữ liệu nhiều biến',4,45,30,45,'TGMT');
insert into hocphan values ('CSC16004',N'Thị giác máy tính',4,45,30,45,'TGMT');

insert into hocphan values ('CSC11004',N'Mạng máy tính nâng cao',4,45,30,45,'CNTT');
insert into hocphan values ('CSC14119',N'Nhập môn khoa học dữ liệu',4,45,30,45,'CNTT');
insert into hocphan values ('CSC15004',N'Học thống kê',4,45,30,45,'CNTT');

insert into hocphan values ('CSC11115',N'An ninh mạng',4,45,30,45,'MMT');
insert into hocphan values ('CSC11005',N'Thực tập mạng máy tính',4,45,30,45,'MMT');
insert into hocphan values ('CSC11002',N'Hệ thống viễn thông',4,45,30,45,'MMT');

insert into hocphan values ('BAA00004',N'Pháp luật đại cương',3,45,0,90,'VPK');
insert into hocphan values ('BAA00021',N'Thể dục 1',2,15,30,45,'VPK');
insert into hocphan values ('BAA00101',N'Triết học Mác – Lênin',3,45,0,90,'VPK');

//KHMO
insert into KHMO values ('CSC12002',1,2023,'CLC');
insert into KHMO values ('CSC11004',2,2023,'CLC');
insert into KHMO values ('CSC11005',3,2023,'CLC');
insert into KHMO values ('CSC14004',1,2023,'CLC');
insert into KHMO values ('BAA00021',2,2023,'CLC');
insert into KHMO values ('CSC12003',3,2023,'CLC');

insert into KHMO values ('CSC13006',1,2023,'CQ');
insert into KHMO values ('BAA00021',1,2023,'CQ');
insert into KHMO values ('CSC16001',2,2023,'CQ');
insert into KHMO values ('CSC11115',2,2023,'CQ');
insert into KHMO values ('CSC12003',3,2023,'CQ');
insert into KHMO values ('CSC13003',3,2023,'CQ');

insert into KHMO values ('BAA00021',1,2023,'VP');
insert into KHMO values ('CSC13003',1,2023,'VP');
insert into KHMO values ('CSC16001',2,2023,'VP');
insert into KHMO values ('CSC11004',2,2023,'VP');
insert into KHMO values ('CSC11002',3,2023,'VP');
insert into KHMO values ('BAA00101',3,2023,'VP');

insert into KHMO values ('CSC15004',1,2023,'CTTT');
insert into KHMO values ('CSC12004',1,2023,'CTTT');
insert into KHMO values ('CSC14002',2,2023,'CTTT');
insert into KHMO values ('BAA00004',2,2023,'CTTT');
insert into KHMO values ('BAA00021',3,2023,'CTTT');
insert into KHMO values ('CSC16004',3,2023,'CTTT');

//DANGKI
insert into dangky values ('SV001','CSC12002',1,2023,'CLC',null,null,null,null);
insert into dangky values ('SV002','CSC12002',1,2023,'CLC',6.2,7.5,8.1,7.4);
insert into dangky values ('SV003','CSC12002',1,2023,'CLC',5.2,8.5,4.2,5.1);
insert into dangky values ('SV004','CSC13006',1,2023,'CQ',7.5,7.6,8.1,7.8);
insert into dangky values ('SV005','CSC11115',2,2023,'CQ',6.7,7.5,6.2,6.9);
insert into dangky values ('SV006','CSC16001',2,2023,'VP',8.6,9.1,8.5,8.8);
insert into dangky values ('SV007','BAA00021',1,2023,'VP',null,null,null,null);
insert into dangky values ('SV008','CSC11002',3,2023,'VP',7.6,6.2,6.2,6.8);
insert into dangky values ('SV009','CSC12004',1,2023,'CTTT',4.5,6.5,7.5,6.5);
insert into dangky values ('SV010','BAA00004',2,2023,'CTTT',7.5,7.4,7.2,7.3);
insert into dangky values ('SV003','CSC12003',3,2023,'CLC',8.1,8.5,6.5,7.4);
insert into dangky values ('SV007','CSC16001',2,2023,'VP',null,null,null,null);

//PHANCONG
insert into phancong values ('NV008','BAA00004',2,2023,'CTTT');
insert into phancong values ('NV008','BAA00101',3,2023,'VP');

insert into phancong values ('NV009','CSC12002',1,2023,'CLC');
insert into phancong values ('NV009','CSC12003',3,2023,'CQ');

insert into phancong values ('NV010','CSC13003',1,2023,'VP');
insert into phancong values ('NV010','CSC13003',3,2023,'CQ');

insert into phancong values ('NV011','CSC14004',1,2023,'CLC');
insert into phancong values ('NV011','CSC14002',2,2023,'CTTT');

insert into phancong values ('NV012','CSC11004',2,2023,'VP');
insert into phancong values ('NV012','CSC15004',1,2023,'CTTT');

insert into phancong values ('NV013','CSC16001',2,2023,'VP');
insert into phancong values ('NV013','CSC16004',3,2023,'CTTT');

insert into phancong values ('NV014','CSC11002',3,2023,'VP');
insert into phancong values ('NV014','CSC11005',3,2023,'CLC');
