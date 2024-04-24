alter session set container=ATBM_3

BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'admin_ols1',
   object_name        => 'nhansu',
   policy_name        => 'xem_phu_cap_nv_khac',
   audit_condition    => 'manv != sys_context(''userenv'', ''session_user'')', 
   audit_column       => 'PHUCAP',
   enable             =>  TRUE,
   statement_types    => 'SELECT');
END; 
BEGIN
 DBMS_FGA.ENABLE_POLICY(
  object_schema        => 'admin_ols1',
  object_name          => 'nhansu',
  policy_name          => 'xem_phu_cap_nv_khac',
  enable               => TRUE);
END;


conn NV001/NV001;
select * from admin_ols1.nhansu;

SELECT DBUSERNAME, SQL_TEXT, AUDIT_TYPE,EVENT_TIMESTAMP 
FROM UNIFIED_AUDIT_TRAIL 
WHERE OBJECT_SCHEMA = 'ADMIN_OLS1' AND OBJECT_NAME = 'NHANSU';