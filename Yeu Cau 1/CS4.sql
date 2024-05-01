grant EXEMPT ACCESS POLICY to admin_ols1;
alter session set container = ATBM_3;
--create user ATBM_Admin identified by 123456 DEFAULT TABLESPACE USERS;
--ALTER USER ATBM_Admin quota unlimited on USERS;
--grant create table,create view,create trigger,create procedure,create user,create role,create session to ATBM_Admin;
--drop user ATBM_Admin cascade;

grant create session to ROLE_TruongDonVi;
grant select on phancong to ROLE_TruongDonVi;
--grant execute on ATBM_Admin.xem_phan_cong_giang_day_TrBM to ROLE_TruongDonVi;
grant ROLE_GiangVien to ROLE_TruongDonVi;
--drop role ROLE_TruongDonVi;
/
create or replace function Admin_ols1.sua_phan_cong_cua_TrBM (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
    DECLARE
        TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);
        user VARCHAR2(100);
    begin
        user := SYS_CONTEXT('userenv', 'SESSION_USER');
        for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
        loop
            IF r.granted_role = 'ROLE_TRUONGDONVI' then 
                begin
                select MAHP bulk collect into mahpArr from Admin_ols1.HOCPHAN where MADV in (select MADV from Admin_ols1.NHANSU where MANV=SYS_CONTEXT('userenv', 'SESSION_USER'));
                if(mahpArr.count>0) then
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
            elsif r.granted_role = 'ROLE_NHANVIEN' or r.granted_role = 'ROLE_SINHVIEN' or r.granted_role = 'ROLE_GIANGVIEN' then
            begin
                return '1=0';
            end;
            end if;
        END LOOP;
        return '1=1';
        
    end;
end;
--select * from ALL_POLICIES ;
--SELECT ATBM_Admin.sua_phan_cong_cua_TrBM('ATBM_Admin', 'phancong') FROM DUAL;
/
execute dbms_rls.add_policy(object_schema => 'Admin_ols1',object_name => 'phancong',policy_name => 'TrBM_PHANCONG',function_schema => 'Admin_ols1',policy_function => 'sua_phan_cong_cua_TrBM',statement_types => 'update,insert,delete',update_check => TRUE );
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
create or replace function Admin_ols1.xem_phan_cong_giang_day_TrBM (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
    DECLARE
        TYPE v_array_type IS VARRAY (20) OF CHAR(5);
        magvArr v_array_type;
        magv_s varchar(200);
        user VARCHAR2(100);
    begin
        user := SYS_CONTEXT('userenv', 'SESSION_USER');
        for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
        loop
            IF r.granted_role = 'ROLE_TRUONGDONVI' then 
                begin
                select MANV bulk collect into magvArr from Admin_ols1.NHANSU where MADV in (select MADV from Admin_ols1.NHANSU where MANV=SYS_CONTEXT('userenv', 'SESSION_USER'));
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
            elsif r.granted_role = 'ROLE_NHANVIEN' or r.granted_role = 'ROLE_SINHVIEN' then
            begin
                return '1=0';
            end;
            end if;
        END LOOP;
        return '1=1';
    end;
end;
/
--select * from ALL_POLICIES ;
--SELECT Admin_ols1.xem_phan_cong_giang_day_TrBM('Admin_ols1', 'phancong') FROM DUAL;
/
execute dbms_rls.add_policy(object_schema => 'Admin_ols1',object_name => 'phancong',policy_name => 'TrBM_PHANCONG_GIANGVIEN',function_schema => 'Admin_ols1',policy_function => 'xem_phan_cong_giang_day_TrBM',statement_types => 'select' );
/
--execute dbms_rls.drop_policy(object_schema => 'Admin_ols1',object_name => 'phancong',policy_name => 'TrBM_PHANCONG_GIANGVIEN');
/
