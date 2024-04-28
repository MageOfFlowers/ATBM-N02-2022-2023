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
user varchar2(1000);
begin
    user := 'sys_context(''userenv'', ''session_user'')';
    return 'MANV = '|| user;
end;
/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'xemBT_nhansu', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_nhansu', statement_types => 'select', update_check => TRUE );

/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'xemBT_nhansu')
*/
/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'suaBT_nhansu', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_nhansu', statement_types => 'update', sec_relevant_cols => 'DT');
/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'nhansu', policy_name => 'suaBT_nhansu')
*/