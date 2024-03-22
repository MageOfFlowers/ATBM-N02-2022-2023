
create or replace procedure ADMIN_OLS1.xem_quyen_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT distinct(table_name)
                    FROM dba_tables
                    where owner = 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;

create or replace procedure ADMIN_OLS1.xem_ds_table (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT table_name, privilege
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee = upper(p_user);
    DBMS_SQL.RETURN_RESULT(c1);
end;

exec xem_quyen_user('A');

create role A;
grant select on ADMIN_OLS1.SINHVIEN to A;

show con_name
create user t1 IDENTIFIED BY 123;
grant select on ADMIN_OLS1.SINHVIEN to t1;