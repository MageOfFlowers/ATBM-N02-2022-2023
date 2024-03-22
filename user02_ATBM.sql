show CON_NAME

--alter table DONVI drop constraint FK_DONVI_TRGDV;
--alter table NHANSU drop constraint FK_NHANSU_MADV;
--alter table HOCPHAN drop constraint FK_HOCPHAN_MADV;
--alter table KHMO drop constraint FK_KHMO_MAHP;
--alter table PHANCONG drop constraint FK_PHANCONG_KHMO;
--alter table PHANCONG drop constraint FK_PHANCONG_MAGV;
--alter table DANGKY drop constraint FK_DANGKY_MASV;
--alter table DANGKY drop constraint FK_DANGKY_KHMO;
--drop table DONVI;
--drop table NHANSU;
--drop table HOCPHAN;
--drop table KHMO;
--drop table SINHVIEN;
--drop table PHANCONG;
--drop table DANGKY;

CREATE TABLE ADMIN_OLS1.NHANSU(
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

CREATE TABLE ADMIN_OLS1.SINHVIEN(
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

CREATE TABLE ADMIN_OLS1.DONVI(
    MADV CHAR(5) not null,
    TENDV NVARCHAR2(50) NOT NULL,
    TRGDV CHAR(5),
    PRIMARY KEY(MADV),
    CONSTRAINT FK_DONVI_TRGDV FOREIGN KEY (TRGDV) REFERENCES NHANSU (MANV)
);

CREATE TABLE ADMIN_OLS1.HOCPHAN(
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

CREATE TABLE ADMIN_OLS1.KHMO(
    MAHP CHAR(8) NOT NULL,
    HK INTEGER NOT NULL,
    NAM INTEGER NOT NULL,
    MACT VARCHAR(4) NOT NULL,
    CHECK (MACT IN ('CQ','CTTT','CLC','VP')),
    PRIMARY KEY(MAHP, HK, NAM, MACT),
    CONSTRAINT FK_KHMO_MAHP FOREIGN KEY (MAHP) REFERENCES HOCPHAN (MAHP)
);

CREATE TABLE ADMIN_OLS1.PHANCONG(
    MAGV CHAR(5) NOT NULL,
    MAHP CHAR(8) NOT NULL,
    HK INTEGER NOT NULL,
    NAM INTEGER NOT NULL,
    MACT VARCHAR(4) NOT NULL,
    PRIMARY KEY(MAGV, MAHP, HK, NAM, MACT),
    CONSTRAINT FK_PHANCONG_MAGV FOREIGN KEY (MAGV) REFERENCES NHANSU (MANV),
    CONSTRAINT FK_PHANCONG_KHMO FOREIGN KEY (MAHP, HK, NAM, MACT) REFERENCES KHMO (MAHP, HK, NAM, MACT)
);

CREATE TABLE ADMIN_OLS1.DANGKY(
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
    CONSTRAINT FK_DANGKY_KHMO FOREIGN KEY (MAHP, HK, NAM, MACT) REFERENCES KHMO (MAHP, HK, NAM, MACT)
);
alter table NHANSU add CONSTRAINT FK_NHANSU_MADV FOREIGN KEY (MADV) REFERENCES DONVI (MADV);

//SINHVIEN
insert into sinhvien values ('SV001','Le Nhat Tien','M',DATE '2003-05-03','106 Thoai Ngoc Hau, Hoa Thanh, Tan Phu','0936472835','CLC','HTTT',45,7.43);
insert into sinhvien values ('SV002','Phan Phuoc Thien','M',DATE '2002-01-12','95 Le Ngan, Phuong 12, Tan Binh','0767569845','CLC','CNTT',51,6.57);
insert into sinhvien values ('SV003','Nguyen Dong Vy','F',DATE '2004-04-22','112 D. Ha Thi Dat, Tan Son Nhi, Tan Phu','0918654825','CLC','KHMT',47,7.75);
insert into sinhvien values ('SV004','Ho Minh Yen','F',DATE '2003-02-13','283 Ly Thuong Kiet, Phuong 15, Quan 11','0973564864','CQ','CNPM',46,5.43);
insert into sinhvien values ('SV005','Doan Huy Anh','M',DATE '2003-03-25','306B D. Dien Bien Phu, Phuong 4, Quan 3','0756856157','CQ','TGMT',41,7.23);
insert into sinhvien values ('SV006','Do Tien Duc','M',DATE '2002-06-07','173 D. Cao Thang, Phuong 12, Quan 10','0896532647','VP','MTT',49,8.12);
insert into sinhvien values ('SV007','Tong Ha Thanh','F',DATE '2004-09-09','224 D. Thanh Thai, Phuong 14, Quan 10','0798635214','VP','HTTT',52,8.22);
insert into sinhvien values ('SV008','Chau Nhat Dung','M',DATE '2002-10-21','316 D. An Duong Vuong, Phuong 4, Quan 5','0458635269','VP','CNTT',40,6.26);
insert into sinhvien values ('SV009','Cao Phuc Hoa','M',DATE '2001-11-19','594 D. 3 Thang 2, Phuong 14, Quan 10','0846352175','CTTT','CNPM',46,8.78);
insert into sinhvien values ('SV010','Tran Thao My','F',DATE '2002-12-25','523 D. Au Co, Phu Trung, Tan Phu','0919154685','CTTT','TGMT',49,9.12);

//NHANSU
insert into nhansu values ('NV001','Le Bao Tin','M',DATE '1990-07-18',1000,'0986514365','Truong khoa',null);
insert into nhansu values ('NV002','Nguyen Khai Tam','M',DATE '1991-02-11',500,'0768568452','Truong don vi',null);
insert into nhansu values ('NV003','Doan Thien An','M',DATE '1989-07-17',400,'0987654321','Truong don vi',null);
insert into nhansu values ('NV004','Huynh Tra My','F',DATE '1988-11-05',600,'0968547123','Truong don vi',null);
insert into nhansu values ('NV005','Dang Thanh Ha','F',DATE '1988-10-07',700,'0857469321','Giao vu',null);
insert into nhansu values ('NV006','Vo Khanh Hai','M',DATE '1987-12-03',500,'0569832147','Giao vu',null);
insert into nhansu values ('NV007','Nguyen Phu An','M',DATE '1985-04-21',400,'0654823971','Nhan vien co ban',null);
insert into nhansu values ('NV015','Do Duy Bao','M',DATE '1987-01-11',400,'0489654231','Nhan vien co ban',null);
insert into nhansu values ('NV008','Bui Chi Bao','M',DATE '1992-01-25',300,'0485697123','Giang vien',null);
insert into nhansu values ('NV009','Ly My Hue','F',DATE '1991-02-19',500,'0563289471','Giang vien',null);
insert into nhansu values ('NV010','Nguyen Thu Loan','F',DATE '1993-05-09',500,'0876495312','Giang vien',null);
insert into nhansu values ('NV011','Nguyen Bao Thai','M',DATE '1992-11-17',500,'0549763128','Giang vien',null);
insert into nhansu values ('NV012','Bui Quang Trieu','M',DATE '1987-01-11',400,'0546798312','Giang vien',null);
insert into nhansu values ('NV013','Nguyen Bao Thoa','F',DATE '1986-08-15',500,'0316427895','Giang vien',null);
insert into nhansu values ('NV014','Ngo Chi Nam','M',DATE '1981-03-16',400,'0549768255','Giang vien',null);

//DONVI
insert into donvi values ('VPK',N'Van phong khoa','NV001');
insert into donvi values ('HTTT',N'Bo mon HTTT','NV002');
insert into donvi values ('CNPM',N'Bo mon CNPM','NV003');
insert into donvi values ('KHMT',N'Bo mon KHMT',null);
insert into donvi values ('CNTT',N'Bo mon CNTT','NV004');
insert into donvi values ('TGMT',N'Bo mon TGMT',null);
insert into donvi values ('MMT',N'Bo mon MMT va Vien thong',null);

//update NHANSU
update nhansu set MADV='VPK' where MANV in ('NV001','NV005','NV006','NV008');
update nhansu set MADV='HTTT' where MANV in ('NV002','NV009');
update nhansu set MADV='CNPM' where MANV in ('NV003','NV010');
update nhansu set MADV='KHMT' where MANV in ('NV011','NV007');
update nhansu set MADV='CNTT' where MANV in ('NV012','NV004');
update nhansu set MADV='TGMT' where MANV in ('NV013');
update nhansu set MADV='MMT' where MANV in ('NV014','NV015');

//HOCPHAN
insert into hocphan values ('CSC12002',N'Co so du lieu nang cao',4,45,30,45,'HTTT');
insert into hocphan values ('CSC12003',N'He quan tri co so du lieu',4,45,30,45,'HTTT');
insert into hocphan values ('CSC12004',N'Phan tich thiet ke he thong thong tin',4,45,30,45,'HTTT');
insert into hocphan values ('CSC13003',N'Kiem thu phan mem',4,45,30,45,'CNPM');
insert into hocphan values ('CSC13006',N'Quan ly du an phan mem',4,45,30,45,'CNPM');
insert into hocphan values ('CSC13008',N'Phat trien ung dung web',4,45,30,45,'CNPM');
insert into hocphan values ('CSC14002',N'Cac he co so tri thuc',4,45,30,45,'KHMT');
insert into hocphan values ('CSC14004',N'Khai thac du lieu va ung dung',4,45,30,45,'KHMT');
insert into hocphan values ('CSC14101',N'An du lieu va chia se thong tin',4,45,30,45,'KHMT');
insert into hocphan values ('CSC16001',N'Do hoa may tinh',4,45,30,45,'TGMT');
insert into hocphan values ('CSC16003',N'Phan tich thong ke du lieu nhieu bien',4,45,30,45,'TGMT');
insert into hocphan values ('CSC16004',N'Thi giao may tinh',4,45,30,45,'TGMT');
insert into hocphan values ('CSC11004',N'Mang may tinh nang cao',4,45,30,45,'CNTT');
insert into hocphan values ('CSC14119',N'Nhap mon khoa hoc du lieu',4,45,30,45,'CNTT');
insert into hocphan values ('CSC15004',N'Hoc thong ke',4,45,30,45,'CNTT');
insert into hocphan values ('CSC11115',N'An ninh mang',4,45,30,45,'MMT');
insert into hocphan values ('CSC11005',N'Thuc tap mang may tinh',4,45,30,45,'MMT');
insert into hocphan values ('CSC11002',N'He thong vien thong',4,45,30,45,'MMT');
insert into hocphan values ('BAA00004',N'Phap luat dai cuong',3,45,0,90,'VPK');
insert into hocphan values ('BAA00021',N'The duc 1',2,15,30,45,'VPK');
insert into hocphan values ('BAA00101',N'Triet hoc Mac – Lenin',3,45,0,90,'VPK');

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

//DANGKY
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
