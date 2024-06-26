--Hoc Phan
create or replace procedure lay_ds_hoc_phan(c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    select * from admin_ols1.hocphan;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure lay_thong_tin_hoc_phan(pMAHP in varchar2, c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select tenhp, sotc, stlt, stth, sosvtd, madv
    from admin_ols1.hocphan 
    where MAHP = pMAHP;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure dang_ky_hoc_phan(m_masv varchar2, m_mahp varchar2, m_hk number, m_nam number, m_mact varchar2)
authid current_user
as
begin
    insert into admin_ols1.dangky values (m_masv,m_mahp,m_hk,m_nam,m_mact, null, null, null, null);
end;
/

create or replace procedure huy_dang_ky_hoc_phan(m_masv varchar2, m_mahp varchar2, m_hk number, m_nam number)
authid current_user
as
begin
    execute immediate 'delete from admin_ols1.dangky where masv = ''' || m_masv || ''' and mahp = ''' || m_mahp || ''' and hk = ' || m_hk || 'and nam = ' || m_nam;
end;
/

create or replace procedure them_hoc_phan(m_mahp in char, m_tenhp in nvarchar2, m_sotc in int, m_stlt in int, m_stth in int, m_sosvtd in int, m_madv in char)
authid current_user
as
begin
    update admin_ols1.hocphan set tenhp=m_tenhp, sotc=m_sotc, stlt=m_stlt, stth=m_stth, sosvtd=m_sosvtd, madv=m_madv
    where mahp=m_mahp;
end;
/

create or replace procedure cap_nhat_hoc_phan(m_mahp in char, m_tenhp in nvarchar2, m_sotc in int, m_stlt in int, m_stth in int, m_sosvtd in int, m_madv in char)
authid current_user
as
begin
    update admin_ols1.hocphan set tenhp=m_tenhp, sotc=m_sotc, stlt=m_stlt, stth=m_stth, sosvtd=m_sosvtd, madv=m_madv
    where mahp=m_mahp;
end;
/
grant execute on lay_ds_hoc_phan to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;
grant execute on lay_thong_tin_hoc_phan to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on dang_ky_hoc_phan to role_sinhvien;
grant execute on huy_dang_ky_hoc_phan to role_sinhvien, role_giaovu;
grant execute on them_hoc_phan to role_giaovu;
grant execute on cap_nhat_hoc_phan to role_giaovu;
/


--Lop
create or replace procedure lay_ds_lop(c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select dk.MAHP, hp.TENHP, dk.HK, dk.NAM, dk.MACT
    from admin_ols1.khmo dk join admin_ols1.hocphan hp on dk.MAHP = hp.MAHP;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure lay_thong_tin_lop_hoc(pMAHP in varchar2, pHK in number, pNAM in number, pMACT in varchar2, c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select dk.masv, sv.hoten, sv.phai, dk.diemth, dk.diemqt, dk.diemck, dk.diemtk
    from admin_ols1.dangky dk join admin_ols1.sinhvien sv on dk.masv = sv.masv
    where dk.MAHP = pMAHP and dk.HK = pHK and dk.NAM = pNAM and dk.MACT = pMACT;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure cap_nhat_diem(pMAHP in varchar2, pHK in number, pNAM in number,pMACT in varchar2, pMASV in varchar2, 
                        pTH in number , pQT in number, pCK in number, pTK in number)
authid current_user
as
begin
update admin_ols1.dangky
set DIEMTH = pTH, DIEMQT = pQT, DIEMCK = pCK, DIEMTK = pTK
where MASV = pMASV and MAHP = pMAHP and HK = pHK and NAM = pNAM and MACT = pMACT;
end;
/

grant execute on lay_ds_lop to role_sinhvien, role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on lay_thong_tin_lop_hoc to role_giangvien, role_truongdonvi, role_truongkhoa;
grant execute on cap_nhat_diem to role_giangvien, role_truongdonvi, role_truongkhoa;


--Ke hoach mo
create or replace procedure xem_ds_ke_hoach_mo (c1 out SYS_REFCURSOR)
authid current_user
as
begin
    open c1 for
    select k.mahp, h.tenhp, k.hk, k.nam, k.mact 
    from admin_ols1.khmo k join admin_ols1.hocphan h
    on k.mahp = h.mahp;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure them_ke_hoach (m_mahp varchar2, m_hk integer, m_nam integer, m_mact varchar2)
authid current_user
as
begin
    execute immediate 'insert into admin_ols1.khmo values(''' || m_mahp || ''',' || m_hk || ',' || m_nam || ',''' || m_mact || ''')';
end;
/

create or replace procedure thay_doi_ke_hoach (m_mahp varchar2, m_hk_cu integer, m_hk_moi integer, m_nam_cu integer, m_nam_moi integer, m_mact_cu varchar2, m_mact_moi varchar2)
authid current_user
as
begin
    update admin_ols1.khmo set hk = m_hk_moi, nam = m_nam_moi, mact = m_mact_moi where mahp = m_mahp and hk = m_hk_cu and nam = m_nam_cu and mact = m_mact_cu;
end;
/

create or replace procedure xem_khm_cua_sv (c1 out SYS_REFCURSOR)
authid current_user
as
begin
    open c1 for
    select k.mahp, h.tenhp, k.hk, k.nam, k.mact 
    from admin_ols1.khmo k join admin_ols1.hocphan h
    on k.mahp = h.mahp
    except
    select k.mahp, h.tenhp, k.hk, k.nam, k.mact 
    from admin_ols1.dangky k join admin_ols1.hocphan h
    on k.mahp = h.mahp;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure xem_khm_da_dk(c1 out SYS_REFCURSOR)
authid current_user
as
begin
    open c1 for
    select k.masv, k.mahp, h.tenhp, k.hk, k.nam, k.mact 
    from admin_ols1.dangky k join admin_ols1.hocphan h
    on k.mahp = h.mahp;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

grant execute on xem_ds_ke_hoach_mo to role_sinhvien, role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on them_ke_hoach to role_giaovu;
grant execute on thay_doi_ke_hoach to role_giaovu;
grant execute on xem_khm_cua_sv to role_sinhvien, role_giaovu;
grant execute on xem_khm_da_dk to role_sinhvien, role_giaovu;
/


--Nhan su
create or replace procedure lay_ds_nhan_su(c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    select * from admin_ols1.nhansu;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure lay_thong_tin_nhan_su(pMANV in varchar2, c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select hoten,phai,ngsinh,phucap,dt,vaitro,tendv
    from admin_ols1.nhansu n join admin_ols1.donvi d on n.madv=d.madv
    where manv=pMANV;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure cap_nhat_sdt_nhan_su(pMANV in varchar2,sdt in varchar2)
authid current_user
as
begin
    update admin_ols1.nhansu set dt=sdt where manv=pMANV;
end;
/

create or replace procedure xem_vai_tro(c1 out SYS_REFCURSOR)
authid current_user
as
user varchar2(100);
role varchar2(100);
c_temp SYS_REFCURSOR;
begin
user := sys_context('userenv', 'session_user');
if (user like 'NV%') then
    open c1 for
    select vaitro from admin_ols1.nhansu where manv = user;
else
    open c1 for
    select 'Sinh vien' as vaitro from dual;
end if;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure them_nhan_su(m_manv varchar2, m_hoten varchar2, m_phai char, m_ngsinh date, m_phucap number, m_dt varchar2, m_vaitro varchar2, m_madv varchar2)
authid current_user
as
begin
    insert into admin_ols1.nhansu values (m_manv, m_hoten, m_phai, m_ngsinh, m_phucap, m_dt, m_vaitro, m_madv);
    begin
        admin_ols1.USP_CREATEUSER;
        admin_ols1.USP_ADDUSRMEM;
    end;
end;
/

create or replace procedure xoa_nhan_su(m_manv varchar2)
authid current_user
as
begin
    delete admin_ols1.nhansu where manv = m_manv;
    execute immediate 'drop user ' || m_manv; 
end;
/

create or replace procedure sua_nhan_su(m_manv varchar2, m_hoten varchar2, m_phai char, m_ngsinh date, m_phucap number, m_dt varchar2, m_vaitro_cu varchar2, m_vaitro_moi varchar2, m_madv varchar2)
authid current_user
as
revoke_role varchar2(20);
grant_role varchar2(20);
begin
    update admin_ols1.nhansu
    set hoten = m_hoten, phai = m_phai, ngsinh = m_ngsinh, phucap = m_phucap, dt = m_dt, vaitro = m_vaitro_moi, madv = m_madv
    where manv = m_manv;
    
    if (m_vaitro_cu != m_vaitro_moi) then
        IF (m_vaitro_cu = 'Nhan vien co ban') then
            revoke_role := 'ROLE_NHANVIEN';
        ELSIF (m_vaitro_cu = 'Giang vien') then
            revoke_role := 'ROLE_GIANGVIEN';
        ELSIF (m_vaitro_cu = 'Giao vu') then
            revoke_role := 'ROLE_GIAOVU';
        ELSIF (m_vaitro_cu = 'Truong don vi') then
            revoke_role := 'ROLE_TRUONGDONVI';
        END IF;    
        
        IF (m_vaitro_moi = 'Nhan vien co ban') then
            grant_role := 'ROLE_NHANVIEN';
        ELSIF (m_vaitro_moi = 'Giang vien') then
            grant_role := 'ROLE_GIANGVIEN';
        ELSIF (m_vaitro_moi = 'Giao vu') then
            grant_role := 'ROLE_GIAOVU';
        ELSIF (m_vaitro_moi = 'Truong don vi') then
            grant_role := 'ROLE_TRUONGDONVI';
        END IF;
        
        execute immediate 'Revoke ' || revoke_role || ' from ' || m_manv;
        execute immediate 'Grant ' || grant_role || ' to ' || m_manv;
    end if;
end;
/

grant execute on lay_ds_nhan_su to role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on lay_thong_tin_nhan_su to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on cap_nhat_sdt_nhan_su to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on xem_vai_tro to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;
grant execute on them_nhan_su to role_truongkhoa;
grant execute on xoa_nhan_su to role_truongkhoa;
grant execute on sua_nhan_su to role_truongkhoa;


--Sinh vien
create or replace procedure lay_danh_sach_sinh_vien(c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select *
    from admin_ols1.sinhvien;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure lay_thong_tin_sinh_vien(pMASV in varchar2, c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    Select hoten,phai,ngsinh,dchi,dt,mact,manganh,sotctl,dtbtl
    from admin_ols1.sinhvien s
    where masv=pMASV;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure cap_nhat_dia_chi_va_sdt_sinh_vien(pMASV in varchar2, diachi in varchar2,sdt in varchar2)
authid current_user
as
begin
    update admin_ols1.sinhvien set dchi=diachi, dt=sdt
    where masv=pMASV;
end;
/

create or replace procedure them_sinh_vien(pMASV in varchar2,hotensv in nvarchar2,phaisv in char,ngsinhsv in date, dchisv in nvarchar2,dtsv in varchar2,mactsv in varchar2,manganhsv in varchar2,sotctlsv in number,dtbtlsv in number)
authid current_user
as
begin
    insert into admin_ols1.sinhvien values (pMASV, hotensv, phaisv, ngsinhsv, dchisv, dtsv, mactsv, manganhsv, sotctlsv, dtbtlsv);
    execute immediate 'create user ' || pMASV || ' identified by ' || pMASV;
    execute immediate 'grant role_sinhvien to ' || pMASV;
end;
/

create or replace procedure cap_nhat_tt_sinh_vien(pMASV in varchar2,hotensv in nvarchar2,phaisv in char,ngsinhsv in date, dchisv in nvarchar2,dtsv in varchar2,mactsv in varchar2,manganhsv in varchar2,sotctlsv in number,dtbtlsv in number)
authid current_user
as
begin
    update admin_ols1.sinhvien set HOTEN=hotensv,PHAI=phaisv,NGSINH=ngsinhsv,DCHI=dchisv, DT=dtsv,MACT=mactsv,MANGANH=manganhsv,SOTCTL=sotctlsv,DTBTL=dtbtlsv
    where masv=pMASV;
end;
/

grant execute on lay_danh_sach_sinh_vien to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on lay_thong_tin_sinh_vien to role_sinhvien, role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on cap_nhat_dia_chi_va_sdt_sinh_vien to role_sinhvien;
grant execute on them_sinh_vien to role_giaovu;
grant execute on cap_nhat_tt_sinh_vien to role_giaovu;


--Phan cong
create or replace procedure xem_phan_cong(c1 out SYS_REFCURSOR)
authid current_user
as
begin
open c1 for
    select * from admin_ols1.phancong;
DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure them_phan_cong(m_magv varchar2, m_mahp varchar2, m_hk number, m_nam number, m_mact varchar2)
authid current_user
as
begin
    execute immediate 'insert into admin_ols1.phancong values (''' ||m_magv|| ''', ''' ||m_mahp|| ''', ' ||m_hk|| ', ' ||m_nam|| ', ''' ||m_mact|| ''')';
end;
/

create or replace procedure xoa_phan_cong(m_magv varchar2, m_mahp varchar2, m_hk number, m_nam number, m_mact varchar2)
authid current_user
as
begin
    execute immediate 'delete from admin_ols1.phancong where magv = ''' ||m_magv|| ''' and mahp = ''' ||m_mahp|| ''' and hk = ' ||m_hk|| ' and nam = ' ||m_nam|| ' and mact = ''' ||m_mact|| '''';
end;
/

create or replace procedure sua_phan_cong(m_magv_cu varchar2, m_magv_moi varchar2, m_mahp varchar2, m_hk number, m_nam number, m_mact varchar2)
authid current_user
as
begin
    execute immediate 'update admin_ols1.phancong set magv = ''' ||m_magv_moi|| ''' where magv = ''' ||m_magv_cu|| ''' and mahp = ''' ||m_mahp|| ''' and hk = ' ||m_hk|| ' and nam = ' ||m_nam|| ' and mact = ''' ||m_mact|| '''';
end;
/

grant execute on xem_phan_cong to role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on them_phan_cong to role_truongdonvi, role_truongkhoa;
grant execute on xoa_phan_cong to role_truongdonvi, role_truongkhoa;
grant execute on sua_phan_cong to role_giaovu, role_truongdonvi, role_truongkhoa;


--Don vi
create or replace procedure lay_ds_don_vi(c1 out SYS_REFCURSOR)
authid current_user
as
begin
    open c1 for
    select * from admin_ols1.donvi;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

grant execute on lay_ds_don_vi to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;


--Thong bao
create or replace procedure lay_thong_bao(c1 out SYS_REFCURSOR)
authid current_user
as
begin
    open c1 for
    select ID,noidung from admin_ols1.thongbao;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

grant execute on lay_thong_bao to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;
grant select on thongbao to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;