GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
CREATE OR REPLACE FUNCTION check_giang_vien (USER VARCHAR2)
RETURN BOOLEAN
AS
is_not_gv BOOLEAN := TRUE;
CURSOR gv_cursor IS
    SELECT MANV
    from  ADMIN_OLS1.NHANSU
    where VAITRO = 'Giang vien';
BEGIN
    FOR gv IN gv_cursor LOOP
        IF gv.MANV = user THEN
            begin
                is_not_gv := false;
                EXIT;
            end;
        END IF;
    END LOOP;
    
    RETURN is_not_gv;
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema   => 'ADMIN_OLS1',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_2A',
    audit_condition => 'check_giang_vien(''NV008'')',
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
SELECT * FROM DBA_FGA_AUDIT_TRAIL
WHERE policy_name = 'AUDIT_2A';
grant select on nhansu to role_giangvien;
update DANGKY set diemth = 10, diemtk = 5 where masv = 'SV003';