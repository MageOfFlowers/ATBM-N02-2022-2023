create or replace procedure xem_ds_ke_hoach_mo (c1 out SYS_REFCURSOR)
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
as
begin
    execute immediate 'insert into admin_ols1.khmo values(''' || m_mahp || ''',' || m_hk || ',' || m_nam || ',''' || m_mact || ''')';
end;
/
create or replace procedure thay_doi_ke_hoach (m_mahp varchar2, m_hk integer, m_nam integer, m_mact varchar2)
as
begin
    execute immediate 'update admin_ols1.khmo set hk = ' || m_hk || ', nam = ' || m_nam || ', mact = ''' || m_mact || ''' where mahp = ''' || m_mahp || '';
end;
/
create or replace procedure lay_thong_tin_lop_hoc(pMAHP in varchar2, pHK in number, pNAM in number, pMACT in varchar2, c1 out SYS_REFCURSOR)
as
begin
open c1 for
    Select dk.masv, sv.hoten, sv.phai, dk.diemth, dk.diemqt, dk.diemck, dk.diemtk
    from admin_ols1.dangky dk join admin_ols1.sinhvien sv on dk.masv = sv.masv
    where dk.MAHP = pMAHP and dk.HK = pHK and dk.NAM = pNAM and dk.MACT = pMACT;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure lay_thong_tin_hoc_phan(pMAHP in varchar2, c1 out SYS_REFCURSOR)
as
begin
open c1 for
    Select tenhp, sotc, stlt, stth, sosvtd, madv
    from admin_ols1.hocphan 
    where MAHP = pMAHP;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure lay_ds_lop(c1 out SYS_REFCURSOR)
as
begin
open c1 for
    Select dk.MAHP, hp.TENHP, dk.HK, dk.NAM, dk.MACT
    from admin_ols1.dangky dk join admin_ols1.hocphan hp on dk.MAHP = hp.MAHP;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure cap_nhat_diem(pMAHP in varchar2, pHK in number, pNAM in number,pMACT in varchar2, pMASV in varchar2, 
                        pTH in number , pQT in number, pCK in number, pTK in number)
as
begin
update admin_ols1.dangky
set DIEMTH = pTH, DIEMQT = pQT, DIEMCK = pCK, DIEMTK = pTK
where MASV = pMASV and MAHP = pMAHP and HK = pHK and NAM = pNAM and MACT = pMACT;
end;
/
create or replace procedure xem_vai_tro(c1 out SYS_REFCURSOR)
as
role varchar2(100);
c_temp SYS_REFCURSOR;
begin
open c_temp for
    select vaitro from admin_ols1.nhansu
    where manv = sys_context('userenv', 'session_user');
fetch c_temp into role;
if role is not null then
    close c_temp;
    open c1 for select role as vaitro from dual;
else
    close c_temp;
    open c1 for select 'Sinh vien' as vaitro from dual;
end if;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure xem_phan_cong(c1 out SYS_REFCURSOR)
as
begin
open c1 for
    select * from admin_ols1.phancong;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure lay_ds_hoc_phan(c1 out SYS_REFCURSOR)
as
begin
open c1 for
    select * from admin_ols1.hocphan;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure lay_ds_nhan_su(c1 out SYS_REFCURSOR)
as
begin
open c1 for
    select * from admin_ols1.nhansu;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure them_phan_cong(m_magv varchar2, m_mahp varchar2, m_hk number, m_nam number, m_mact varchar2)
as
begin
    execute immediate 'insert into admin_ols1.phancong values (''' ||m_magv|| ''', ''' ||m_mahp|| ''', ' ||m_hk|| ', ' ||m_nam|| ', ''' ||m_mact|| ''')';
end;
/
grant execute on xem_ds_ke_hoach_mo to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on them_ke_hoach to role_giaovu;
grant execute on thay_doi_ke_hoach to role_giaovu;
grant execute on lay_thong_tin_lop_hoc to role_giangvien, role_truongdonvi, role_truongkhoa;
grant execute on lay_thong_tin_hoc_phan to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on lay_ds_lop to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa;
grant execute on cap_nhat_diem to role_giangvien, role_truongdonvi, role_truongkhoa;
grant execute on xem_vai_tro to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;
grant execute on xem_phan_cong to role_giangvien, role_truongdonvi, role_truongkhoa;
grant execute on lay_ds_hoc_phan to role_nhanvien, role_giangvien, role_giaovu, role_truongdonvi, role_truongkhoa, role_sinhvien;
grant execute on lay_ds_nhan_su to role_truongdonvi, role_truongkhoa;
grant execute on them_phan_cong to role_truongdonvi, role_truongkhoa;