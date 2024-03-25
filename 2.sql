
create or replace procedure ADMIN_OLS1.xem_ds_table (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT distinct(table_name)
                    FROM dba_tables
                    where owner = 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;

create or replace procedure ADMIN_OLS1.xem_quyen_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    Select distinct table_name, privilege, grantable from (
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee = upper(p_user)
    union
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee in (select granted_role from DBA_ROLE_PRIVS where grantee = upper(p_user))
    union
    SELECT table_name, privilege, grantable
                    FROM ALL_COL_PRIVS
                    where grantor = 'ADMIN_OLS1' and grantee = p_user);
    DBMS_SQL.RETURN_RESULT(c1);
end;

create or replace procedure ADMIN_OLS1.xem_role_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT granted_role FROM DBA_ROLE_PRIVS WHERE grantee = p_user;
    DBMS_SQL.RETURN_RESULT(c1);
end;