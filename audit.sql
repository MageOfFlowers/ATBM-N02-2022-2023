select value from v$option where parameter = 'Unified Auditing';
/
GRANT create session, audit_admin, audit_viewer TO admin_ols1;
/
create audit policy role_audit_pol_test
ACTIONS select on admin_ols1.thongbao;
/
noaudit policy role_audit_pol_test by admin_ols1, nv001;
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
SELECT action_name, return_code, object_schema, object_name, system_privilege, unified_audit_policies,event_timestamp
FROM unified_audit_trail where  dbusername = 'NV001'
ORDER BY event_timestamp;

select * from thongbao;