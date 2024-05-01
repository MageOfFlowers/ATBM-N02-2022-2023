GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
CREATE OR REPLACE FUNCTION check_giang_vien
RETURN VARCHAR2
AS
CURSOR gv_cursor IS
    SELECT MANV
    from  ADMIN_OLS1.NHANSU
    where VAITRO = 'Giang vien';
BEGIN
    FOR gv IN gv_cursor LOOP
        IF gv.MANV = sys_context('userenv', 'session_user') THEN
            RETURN 1;
        END IF;
    END LOOP;
    RETURN 0;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN_OLS1',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_3A',
    audit_condition => 'admin_ols1.check_giang_vien()=0',
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
    policy_name   => 'AUDIT_3A'
  );
END;
*/
SELECT DBUSERNAME, SQL_TEXT, AUDIT_TYPE,EVENT_TIMESTAMP 
FROM UNIFIED_AUDIT_TRAIL 
WHERE OBJECT_SCHEMA = 'ADMIN_OLS1' AND OBJECT_NAME = 'DANGKY' and audit_type='FineGrainedAudit';

update DANGKY set diemth = 10, diemtk = 5 where masv = 'SV003';