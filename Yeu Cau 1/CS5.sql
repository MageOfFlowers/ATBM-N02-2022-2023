alter session set "_ORACLE_SCRIPT"=true;

create role ROLE_TRUONGKHOA
not identified;

grant ROLE_GIANGVIEN to ROLE_TRUONGKHOA;
grant select, update, delete on NHANSU to ROLE_GIANGVIEN;
grant SELECT ANY TABLE on NHANSU to ROLE_GIANGVIEN;


create or replace function xem_phan_cong_chinh_minh_function(p_schema varchar2, p_obj varchar2)
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

execute dbms_rls.add_policy (object_schema => 'ROLE_TRUONGKHOA',
                            object_name => 'PHANCONG',
                            policy_name => 'xem_phan_cong_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_phan_cong_chinh_minh_function',
                            statement_types => 'select', 'delete',
                            update_check => TRUE );