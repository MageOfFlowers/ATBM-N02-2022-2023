GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
CREATE OR REPLACE FUNCTION lay_ds_giang_vien
RETURN NUMBER
IS
  emp_count NUMBER;
BEGIN
  SELECT COUNT(*) INTO emp_count
  FROM EMPLOYEES
  WHERE DEPARTMENT_ID = dept_id;

  RETURN emp_count;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN_OLS1',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_2A',
    audit_condition => '(select granted_role from dba_role_privs where grantee = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')) != ''ROLE_GIANGVIEN''',
    audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',        
    enable          => TRUE,
    statement_types => 'UPDATE'
  );
END;
/
/*
BEGIN
  DBMS_FGA.DROP_POLICY(
    object_schema => 'ADMIN_OLS1', 
    object_name   => 'DANGKY', 
    policy_name   => 'AUDIT_2A'
  );
END;
*/
select granted_role from dba_role_privs where grantee = SYS_CONTEXT('USERENV', 'SESSION_USER')
SELECT * FROM DBA_FGA_AUDIT_TRAIL
WHERE policy_name = 'AUDIT_2A';
grant select on nhansu to role_giangvien;
update DANGKY set diemth = 10, diemtk = 5 where masv = 'SV002';