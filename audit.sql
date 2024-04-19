select value from v$option where parameter = 'Unified Auditing';
/
GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
create audit policy role_audit_pol_test
ACTIONS select on admin_ols1.thongbao;
/
noaudit policy role_audit_pol_test;
drop audit policy role_audit_pol_test;
/
audit policy role_audit_pol_test;
/
select * from unified_audit_trail;
select * from audit_unified_policies where object_schema='admin_ols1';
/
create table test_audit(
    id number
    );
drop table test_audit;
/
SELECT dbusername, action_name, return_code, object_schema, object_name, system_privilege, unified_audit_policies,event_timestamp
FROM unified_audit_trail where  dbusername = 'NV001'
ORDER BY event_timestamp;

select * from thongbao;

create or replace procedure bat_ghi_nhat_ky(a boolean, b boolean, c boolean)
as
    STRSQL VARCHAR(2000);
begin
if (a=true) then
    STRSQL := 'AUDIT SELECT ON thongbao BY ACCESS WHENEVER SUCCESSFUL';
    EXECUTE IMMEDIATE(STRSQL);
end if;
end;

exec bat_ghi_nhat_ky(true,false,false);

create or replace procedure xem_nhat_ky(c1 out SYS_REFCURSOR)
as
begin
open c1 for
SELECT dbusername, action_name, to_char(return_code) as return_code, object_schema, object_name, system_privilege, unified_audit_policies,event_timestamp
FROM unified_audit_trail
ORDER BY event_timestamp;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
SELECT 
    object_name
FROM 
    user_procedures
WHERE
    object_type = 'PROCEDURE';
