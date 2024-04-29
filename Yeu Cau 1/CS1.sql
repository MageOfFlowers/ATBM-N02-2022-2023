grant select, update(DT) on nhansu to role_nhanvien;
grant update on nhansu to role_nhanvien;
grant select on sinhvien to role_nhanvien;
grant select on donvi to role_nhanvien;
grant select on hocphan to role_nhanvien;
grant select on khmo to role_nhanvien;
revoke role_nhanvien from admin_ols1;
/
create or replace function ADMIN_OLS1.xemBT_nhansu(p_schema varchar2, p_obj varchar2)
return varchar2
as
m_user varchar2(100);
m_role varchar2(100);
begin
    m_user := sys_context('userenv', 'session_user');
    select vaitro into m_role
    from admin_ols1.nhansu
    where manv = m_user;
    exception
    when NO_DATA_FOUND then
        m_role := 'Unknown';
    if (m_role = 'Nhan vien co ban') then
        return 'MANV = '|| m_user;
    else 
        return '1=1';
    end if;
end;
/
begin 
    dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', 
                         object_name => 'nhansu', 
                         policy_name => 'xemBT_nhansu', 
                         function_schema => 'ADMIN_OLS1',
                         policy_function => 'xemBT_nhansu',
                         statement_types => 'select',
                         update_check => TRUE );
end;
/*
begin
    dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', 
                          object_name => 'nhansu', 
                          policy_name => 'xemBT_nhansu');
end;
*/
/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'suaBT_nhansu', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_nhansu', statement_types => 'update', sec_relevant_cols => 'DT');
/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'suaBT_nhansu')
*/