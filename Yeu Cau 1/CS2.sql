grant role_nhanvien to role_giangvien;
grant select on phancong to role_giangvien;
grant select, update on dangky to role_giangvien;
/
create or replace function xemBT_phancong(p_schema varchar2, p_obj varchar2)
return varchar2
as
    m_user varchar2(100);
    m_role varchar2(100);
begin
    m_user := sys_context('userenv', 'session_user');
    for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = m_user)
    loop
        IF (r.granted_role = 'ROLE_GIANGVIEN') then 
            return 'MAGV = ''' || m_user ||'''';
        end if;
    END LOOP;
        return '1=1';
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
begin
    m_user := sys_context('userenv', 'session_user');
    for r in (select granted_role from DBA_ROLE_PRIVS where grantee = m_user)
    loop
        if r.granted_role = 'ROLE_GIANGVIEN' then 
            return 'MAHP IN (SELECT MAHP FROM ADMIN_OLS1.PHANCONG WHERE MAGV = ''' || user ||''')';
        end if;
    end loop;
    return '1=1';
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