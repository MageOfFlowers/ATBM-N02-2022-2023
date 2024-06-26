alter session set "_ORACLE_SCRIPT"=true;

create role ROLE_TRUONGKHOA
not identified;

grant ROLE_NHANVIEN to ROLE_TRUONGKHOA WITH ADMIN OPTION;
grant ROLE_GIANGVIEN to ROLE_TRUONGKHOA WITH ADMIN OPTION;
grant ROLE_GIAOVU to ROLE_TRUONGKHOA WITH ADMIN OPTION;
grant ROLE_TRUONGDONVI to ROLE_TRUONGKHOA WITH ADMIN OPTION;

grant select,insert, update, delete on NHANSU to ROLE_TRUONGKHOA;
grant select on HOCPHAN to ROLE_TRUONGKHOA;
grant select on KHMO to ROLE_TRUONGKHOA;
--grant select on KHMO to NV001;
grant SELECT ANY TABLE to ROLE_TRUONGKHOA;
grant create user, drop user to ROLE_TRUONGKHOA;
grant execute on USP_CREATEUSER to ROLE_TRUONGKHOA;
grant execute on USP_ADDUSRMEM to ROLE_TRUONGKHOA;
--SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = 'NV001';
/
create or replace function xem_phan_cong_chinh_minh_functionTK(p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
declare
user varchar2(100);
TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);

begin
    user := SYS_CONTEXT('userenv', 'SESSION_USER');
for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
loop
    IF r.granted_role = 'ROLE_TRUONGKHOA' then
    begin
        select MAHP bulk collect into mahpArr from Admin_ols1.HOCPHAN where MADV = 'VPK';
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
    end if;
    
end loop;
return '1=1';
end;
end;
/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'PHANCONG',
                            policy_name => 'xem_phan_cong_policyTK',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_phan_cong_chinh_minh_functionTK',
                            statement_types => 'insert,update, delete',
                            update_check => TRUE );
end;
/
/*
execute dbms_rls.drop_policy(object_schema => 'ADMIN_OLS1',object_name => 'phancong',policy_name => 'xem_phan_cong_policyTK');
*/
grant execute on XEM_CUA_CHINH_MINH_FUNCTION to NV001;
grant execute on DANG_KY_HOC_PHAN_TRONG_HOC_KY_NAY_FUNCTION to NV001;

