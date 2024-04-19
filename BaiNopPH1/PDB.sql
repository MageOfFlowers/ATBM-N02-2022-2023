--DROP PLUGGABLE DATABASE ATBM_3 INCLUDING DATAFILES;
--alter pluggable database ATBM_3 close;
--/
alter session set "_ORACLE_SCRIPT"=true;
alter session set container = CDB$ROOT;
/
create pluggable database ATBM_3 admin user ATBM_OLS identified by 123
FILE_NAME_CONVERT=('C:\APP\ADMIN\PRODUCT\21C\ORADATA\XE\','C:\APP\ADMIN\PRODUCT\21C\ORADATA\ATBM_OLS3\');
/
ALTER PLUGGABLE DATABASE ALL OPEN;
ALTER PLUGGABLE DATABASE ATBM_3 SAVE STATE;
/
alter session set container = ATBM_3;
CREATE USER ADMIN_OLS1 IDENTIFIED BY 123 CONTAINER = CURRENT; 
/
grant dba to ADMIN_OLS1;
GRANT EXECUTE ANY PROCEDURE TO ADMIN_OLS1; 
GRANT CONNECT, RESOURCE TO ADMIN_OLS1 with admin option;
GRANT UNLIMITED TABLESPACE TO ADMIN_OLS1 with admin option;
GRANT SELECT ANY DICTIONARY TO ADMIN_OLS1 with admin option;
grant execute on dbms_rls to ADMIN_OLS1 with grant option;
grant create user to ADMIN_OLS1 with admin option;
grant create role to ADMIN_OLS1 with admin option;
GRANT CREATE SESSION TO ADMIN_OLS1 WITH ADMIN OPTION;
GRANT audit_system TO ADMIN_OLS1 WITH ADMIN OPTION;
grant create user,create role,drop user to ADMIN_OLS1 with admin option;
show con_name;
--alter session set container = CDB$ROOT;
ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;
alter session set container = ATBM_3;
grant select on dba_audit_trail to admin_ols1;
--grant select on sys.dba_objects to admin_ols1;
--grant select on sys.dba_source to admin_ols1;
grant execute on sa_audit_admin TO ADMIN_OLS1;
grant region_policy2_DBA TO ADMIN_OLS1;
GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO ADMIN_OLS1 WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_user_admin TO ADMIN_OLS1 WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_label_admin TO ADMIN_OLS1 WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO ADMIN_OLS1 WITH GRANT OPTION;
GRANT EXECUTE ON char_to_label TO ADMIN_OLS1 WITH GRANT OPTION;

grant alter database to ADMIN_OLS1;
GRANT LBAC_DBA TO ADMIN_OLS1;
GRANT EXECUTE ON sa_sysdba TO ADMIN_OLS1;

GRANT EXECUTE ON to_lbac_data_label TO ADMIN_OLS1;

EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
--SHUTDOWN IMMEDIATE;
--STARTUP; 

shutdown immediate;
startup mount;

alter database archivelog;

alter database open;
alter database close;

