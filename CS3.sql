alter session set container = XEPDB1;
--create user ATBM_Admin identified by 123456 DEFAULT TABLESPACE USERS;
--ALTER USER ATBM_Admin quota unlimited on USERS;
--grant create table,create view,create trigger,create procedure,create user,create role,create session to ATBM_Admin;
--drop user ATBM_Admin cascade;

create role ROLE_GIAOVU not identified;
--grant ROLE_NHANVIEN to ROLE_GIAOVU;
grant create session to ROLE_GIAOVU;
grant select,insert,update on sinhvien to ROLE_GIAOVU;
grant select,insert,update on donvi to ROLE_GIAOVU;
grant select,insert,update on khmo to ROLE_GIAOVU;
grant select,insert,update on hocphan to ROLE_GIAOVU;
--drop role ROLE_GIAOVU;
grant select,update on phancong to ROLE_GIAOVU;
grant select,update on v_phan_cong_vpk to ROLE_GIAOVU;
create or replace function ATBM_Admin.sua_phan_cong_cua_vpk (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
    DECLARE
        TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);
    begin
        select MAHP bulk collect into mahpArr from HOCPHAN where MADV= 'VPK';
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
--SELECT sua_phan_cong_cua_vpk('ATBM_Admin', 'phancong') FROM DUAL;
/
execute dbms_rls.add_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'GIAOVU_PHANCONG',policy_function => 'sua_phan_cong_cua_vpk',statement_types => 'select,update',update_check => TRUE );
/
--execute dbms_rls.drop_policy(object_schema => 'ATBM_Admin',object_name => 'phancong',policy_name => 'GIAOVU_PHANCONG');
/
grant select on DANGKY to ROLE_GIAOVU;
/
create or replace function dang_ki_cho_sv (p_schema IN VARCHAR2, p_obj varchar2) return varchar2
as
begin
if(TO_DATE(EXTRACT(YEAR FROM sysdate) || '-01-01', 'YYYY-MM-DD')>= trunc(sysdate)-14 and TO_DATE(EXTRACT(YEAR FROM sysdate) || '-01-01', 'YYYY-MM-DD')<= trunc(sysdate)) then
    return 'Nam='||EXTRACT(YEAR FROM sysdate)||' and HK=1';
end if;
if(TO_DATE(EXTRACT(YEAR FROM sysdate) || '-05-01', 'YYYY-MM-DD')>= trunc(sysdate)-14 and TO_DATE(EXTRACT(YEAR FROM sysdate) || '-05-01', 'YYYY-MM-DD')<= trunc(sysdate)) then
    return 'Nam='||EXTRACT(YEAR FROM sysdate)||' and HK=2';
end if;
if(TO_DATE(EXTRACT(YEAR FROM sysdate) || '-09-01', 'YYYY-MM-DD')>= trunc(sysdate)-14 and TO_DATE(EXTRACT(YEAR FROM sysdate) || '-09-01', 'YYYY-MM-DD')<= trunc(sysdate)) then
    return 'Nam='||EXTRACT(YEAR FROM sysdate)||' and HK=3';
end if;
return '1=0';
end;
/
execute dbms_rls.add_policy(object_schema => 'ATBM_Admin',object_name => 'dangky',policy_name => 'GIAOVU_DANGKY',function_schema => 'ATBM_Admin',policy_function => 'dang_ki_cho_sv',statement_types => 'insert,delete',update_check => TRUE );
/
--execute dbms_rls.drop_policy(object_schema => 'ATBM_Admin',object_name => 'dangky',policy_name => 'GIAOVU_DANGKY');
--select * from ALL_POLICIES ;
--SELECT dang_ki_cho_sv('ATBM_Admin', 'dangky') FROM DUAL;
--show pdbs
