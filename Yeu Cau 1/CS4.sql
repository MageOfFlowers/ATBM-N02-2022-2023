alter session set container = XEPDB1;
--create user ATBM_Admin identified by 123456 DEFAULT TABLESPACE USERS;
--ALTER USER ATBM_Admin quota unlimited on USERS;
--grant create table,create view,create trigger,create procedure,create user,create role,create session to ATBM_Admin;
--drop user ATBM_Admin cascade;

create role ROLE_TruongDonVi not identified;
grant create session to ROLE_TruongDonVi;
grant select on phancong to ROLE_TruongDonVi;
--grant execute on ATBM_Admin.xem_phan_cong_giang_day_TrBM to ROLE_TruongDonVi;
--grant ROLE_GiangVien to ROLE_TruongDonVi;
--drop role ROLE_TruongDonVi;
/
create or replace function ATBM_Admin.sua_phan_cong_cua_TrBM (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
    DECLARE
        TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);
    begin
        select MAHP bulk collect into mahpArr from ATBM_Admin.HOCPHAN where MADV in (select MADV from ATBM_Admin.NHANSU where MANV=SYS_CONTEXT('userenv', 'SESSION_USER'));
        if(mahpArr.count>1) then
            begin
            mahp_s:= chr(39)|| mahpArr(1) || chr(39);
                for x in 2..mahpArr.count 
                loop
                  mahp_s := mahp_s||','||chr(39)|| mahpArr(x)|| chr(39);
                end loop;
            end;
        end if;
        return 'MAHP in (' || mahp_s || ')';
    end;
end;
--select * from ALL_POLICIES ;
--SELECT ATBM_Admin.sua_phan_cong_cua_TrBM('ATBM_Admin', 'phancong') FROM DUAL;
/
execute dbms_rls.add_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'TrBM_PHANCONG',function_schema => 'ATBM_Admin',policy_function => 'sua_phan_cong_cua_TrBM',statement_types => 'update,insert,delete',update_check => TRUE );
/
--execute dbms_rls.drop_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'TrBM_PHANCONG');
--/
--set serveroutput on format wrapped;
--begin
--  dbms_output.put_line(sys.diutil.bool_to_int(TO_DATE(EXTRACT(YEAR FROM sysdate) || '-09-01', 'YYYY-MM-DD')>= trunc(sysdate)-14 and TO_DATE(EXTRACT(YEAR FROM sysdate) || '-09-01', 'YYYY-MM-DD')<= trunc(sysdate)));
--end;
--select * from dba_roles

--create user NV002 identified by 123456 DEFAULT TABLESPACE USERS;
--grant ROLE_TruongDonVi to NV002;
--drop user NV02 cascade;
/
create or replace function ATBM_Admin.xem_phan_cong_giang_day_TrBM (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
    DECLARE
        TYPE v_array_type IS VARRAY (20) OF CHAR(5);
        magvArr v_array_type;
        magv_s varchar(200);
    begin
        select MANV bulk collect into magvArr from ATBM_Admin.NHANSU where MADV in (select MADV from ATBM_Admin.NHANSU where MANV=SYS_CONTEXT('userenv', 'SESSION_USER'));
        
        if(magvArr.count>1) then
            begin
            magv_s:= chr(39)|| magvArr(1) || chr(39);
                for x in 2..magvArr.count 
                loop
                  magv_s := magv_s||','||chr(39)|| magvArr(x)|| chr(39);
                end loop;
            end;
        end if;
        return 'MAGV in (' || magv_s || ')';
    end;
end;
/
--select * from ALL_POLICIES ;
--SELECT ATBM_Admin.xem_phan_cong_giang_day_TrBM('ATBM_Admin', 'phancong') FROM DUAL;
/
execute dbms_rls.add_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'TrBM_PHANCONG_GIANGVIEN',function_schema => 'ATBM_Admin',policy_function => 'xem_phan_cong_giang_day_TrBM',statement_types => 'select' );
/
--execute dbms_rls.drop_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'TrBM_PHANCONG');
/
