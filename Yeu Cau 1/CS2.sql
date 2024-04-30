grant role_nhanvien to role_giangvien;
grant select on phancong to role_giangvien;
grant select, update(diemth, diemqt, diemck, diemtk) on dangky to role_giangvien;
/
create or replace function xemBT_phancong(p_schema varchar2, p_obj varchar2)
return varchar2
as
    m_user varchar2(100);
    m_role varchar2(100);
begin
    m_user := 'sys_context(''userenv'', ''session_user'')';
    select vaitro 
    into m_role
    from admin_ols1.nhansu
    where manv = sys_context('userenv', 'session_user');
    if (m_role = 'Giang vien')
    then
        return 'MAGV = ' || m_user;
    else
        return '1=1';
    end if;
end;
/
begin
    dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                         object_name => 'phancong', 
                         policy_name => 'xemBT_phancong', 
                         function_schema => 'ADMIN_OLS1', 
                         policy_function => 'xemBT_phancong', 
                         statement_types => 'select', 
                         update_check => TRUE );
end;
/
/*
begin
    dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', 
                          object_name => 'phancong', 
                          policy_name => 'xemBT_phancong');
end;
*/
create or replace function xemBT_dangky(p_schema varchar2, p_obj varchar2)
return varchar2
as
    m_user varchar2(100);
    m_role varchar2(100);
    cursor role_cur is
    select role 
    into m_role
    from session_roles;
begin
    m_user := 'sys_context(''userenv'', ''session_user'')';
    select vaitro 
    into m_role
    from admin_ols1.nhansu
    where manv = sys_context('userenv', 'session_user');
    if (m_role = 'Giang vien')
    then
        return 'MAHP in (select mahp from phancong where magv = ' || m_user || ')';
    else 
        return '1=1';
    end if;
end;
/
begin
    dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', 
                         object_name => 'dangky', 
                         policy_name => 'xemBT_dangky', 
                         function_schema => 'ADMIN_OLS1', 
                         policy_function => 'xemBT_dangky', 
                         statement_types => 'select', 
                         update_check => TRUE );
end;
/
/*
begin 
    dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', 
                          object_name => 'dangky', 
                          policy_name => 'xemBT_dangky');
end;
*/
begin 
    dbms_rls.add_policy (object_schema => 'ADMIN_OLS1', 
                         object_name => 'dangky', 
                         policy_name => 'suaDiem_dangky', 
                         function_schema => 'ADMIN_OLS1', 
                         policy_function => 'xemBT_dangky', 
                         statement_types => 'update', 
                         sec_relevant_cols => 'diemth, diemqt, diemck, diemtk',
                         update_check => true);
end;
/*
begin 
    dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1', 
                          object_name => 'dangky', 
                          policy_name => 'suaDiem_dangky');
end;
*/