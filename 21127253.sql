SHOW PDBS;
select FILE_NAME from dba_data_files;
create pluggable database ATBM admin user n02 identified by oracle
FILE_NAME_CONVERT=('C:\APP\USER\PRODUCT\21C\ORADATA\XE\','C:\APP\USER\PRODUCT\21C\ORADATA\ATBM\');
ALTER PLUGGABLE DATABASE ALL OPEN;
ALTER PLUGGABLE DATABASE ATBM SAVE STATE;

conn n02/oracle@//localhost:1521/ATBM
select * from dba_users;
SELECT value
FROM v$parameter
WHERE name = 'service_names';

ALTER SESSION SET "_ORACLE_SCRIPT"=true;
ALTER PLUGGABLE DATABASE ATBM CLOSE;
DROP PLUGGABLE DATABASE ATBM INCLUDING DATAFILES;  