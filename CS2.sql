grant role_nhanvien to role_giangvien;
grant select on phancong to role_giangvien;
grant select, update(diemth, diemqt, diemck, diemtk) on dangky to role_giangvien;
/
create or replace function xemBT_phancong(p_schema varchar2, p_obj varchar2)
return varchar2
as
user varchar2(100);
begin
user := 'sys_context(''userenv'', ''session_user'')';
return 'MAGV = ' || user;
end;
/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'phancong', policy_name => 'xemBT_phancong', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_phancong', statement_types => 'select', update_check => TRUE );
/
/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'phancong', policy_name => 'xemBT_phancong')
*/
create or replace function xemBT_dangky(p_schema varchar2, p_obj varchar2)
return varchar2
as
begin
    return 'MAHP in (select mahp from phancong where magv = sys_context(''userenv'', ''session_user''))';
end;
/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'dangky', policy_name => 'xemBT_dangky', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_dangky', statement_types => 'select', update_check => TRUE );
/
/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'dangky', policy_name => 'xemBT_dangky')
*/
execute dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', object_name => 'dangky', policy_name => 'suaDiem_dangky', function_schema => 'ADMIN_OLS1', policy_function => 'xemBT_dangky', statement_types => 'update', sec_relevant_cols => 'diemth, diemqt, diemck, diemtk');
/*
execute dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', object_name => 'dangky', policy_name => 'suaDiem_dangky')
*/