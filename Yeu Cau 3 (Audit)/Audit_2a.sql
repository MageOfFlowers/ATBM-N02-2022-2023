GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN_OLS1',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_2A',
    audit_condition => 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'') NOT IN (SELECT MANV FROM ADMIN_OLS1.NHANSU WHERE VAITRO = ''Giang vien'')',
    audit_column    => 'DIEMTH, DIEMQT, DIEMCK, DIEMTK',        
    statement_types => 'UPDATE',
    handler_module  => NULL,
    enable          => TRUE
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

SELECT * FROM DBA_FGA_AUDIT_TRAIL
WHERE policy_name = 'AUDIT_2A';

update DANGKY set diemth = 10, diemtk = 5 where masv = 'SV002';