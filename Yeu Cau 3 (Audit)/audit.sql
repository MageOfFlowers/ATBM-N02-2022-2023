select value from v$option where parameter = 'Unified Auditing';
/
alter session set container = ATBM_3;
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

create or replace procedure bat_ghi_nhat_ky(doituong varchar2, nguoidung varchar2, hanhdong varchar2, trangthai varchar2, cachghi varchar2)
as
    STRSQL VARCHAR(2000);
    pol varchar(2000);
begin
    pol := doituong||nguoidung||hanhdong||'_policy';
    if (trangthai='whenever successful')then pol :=pol||'1'; 
    elsif (trangthai='whenever not successful')then pol :=pol||'0';
    else pol :=pol||'2'; end if;
    if (cachghi='by access')then pol :=pol||'3'; 
    else pol:=pol||'4'; end if;
    
    STRSQL := 'CREATE AUDIT POLICY '||pol||' ACTIONS '||hanhdong||' ON '||doituong;
    DBMS_OUTPUT.PUT_LINE(STRSQL);
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'AUDIT POLICY '||pol||' '||cachghi;
    
    if (nguoidung is not null) then
        STRSQL := STRSQL||' BY '||nguoidung;
    end if;
    if (trangthai!='all') then
        STRSQL := STRSQL||' '||trangthai;
    end if;
    dbms_output.put_line(STRSQL);
    EXECUTE IMMEDIATE(STRSQL);
--EXCEPTION
--WHEN OTHERS THEN
--    DBMS_OUTPUT.PUT_LINE('An error occurred');
end;

set serveroutput on;
grant execute on admin_ols1.bat_ghi_nhat_ky to sys;
exec admin_ols1.bat_ghi_nhat_ky('thongbao','NV001','select','whenever successful','by access');

SELECT policy_name, enabled_option, entity_name
  FROM audit_unified_enabled_policies


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
    
    
declare
p_MACT VARCHAR2(100);
TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);
user VARCHAR2(100);
Begin
user := SYS_CONTEXT('userenv', 'SESSION_USER');
SELECT MACT INTO p_MACT FROM admin_ols1.SINHVIEN WHERE MASV = SYS_CONTEXT('userenv', 'SESSION_USER');
select MAHP bulk collect into mahpArr from Admin_ols1.KHMO where MACT = p_MACT;
        if(mahpArr.count>1) then
            begin
            mahp_s:= chr(39)|| mahpArr(1) || chr(39);
                for x in 2..mahpArr.count 
                loop
                  mahp_s := mahp_s||','||chr(39)|| mahpArr(x)|| chr(39);
                end loop;
            end;
        end if;
        DBMS_OUTPUT.PUT_LINE( 'MAHP in (' || mahp_s || ')');
End;
