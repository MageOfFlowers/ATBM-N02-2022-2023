CREATE TABLE THONGBAO(
    id number GENERATED ALWAYS as IDENTITY(START with 1 INCREMENT by 1),
    noidung nvarchar2(1000)
);
/
--drop table thongbao;
--/
--select * from admin_ols1.thongbao;
--/
--select * from all_sa_labels;
/
create or replace procedure tao_thongbao (noidung nvarchar2, level varchar2, compartment varchar2, p_group varchar2)
as 
STRSQL VARCHAR(2000);
begin
--    BEGIN
--        SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY2','ADMIN_OLS1','THONGBAO');
--        SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
--         policy_name => 'REGION_POLICY2',
--         schema_name => 'ADMIN_OLS1',
--         table_name => 'THONGBAO',
--         table_options => 'NO_CONTROL'
--        );
--    END;
    STRSQL:='insert into thongbao(noidung) values ('''|| noidung ||''')'; 
--    dbms_output.put_line(STRSQL);
    EXECUTE IMMEDIATE (STRSQL);
    STRSQL:='update thongbao set region_label2 = char_to_label(''region_policy2'','''||level||':';
    if compartment is not null then
        STRSQL:=STRSQL||compartment;
    end if;
    STRSQL:=STRSQL||':';
    if p_group is not null then
        STRSQL:=STRSQL||p_group;
    end if;
    STRSQL:=STRSQL||''') where noidung = '''||noidung||'''';
--    dbms_output.put_line(STRSQL);
    EXECUTE IMMEDIATE (STRSQL);
--    BEGIN
--        SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY2','ADMIN_OLS1','THONGBAO');
--        SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
--         policy_name => 'REGION_POLICY2',
--         schema_name => 'ADMIN_OLS1',
--         table_name => 'THONGBAO',
--         table_options => 'READ_CONTROL',
--        predicate => NULL
--        );
--    END;
end;
/

--UPDATE thongbao
--SET region_label2 = CHAR_TO_LABEL('REGION_POLICY2','SV:'); 

set serveroutput on;
exec tao_thongbao('Thong bao nay danh cho sinh vien HTTT o CS1','SV','HTTT','CS1');
exec tao_thongbao('Thong bao nay danh cho truong bo mon phu trach co so 1','TDV',null,'CS1');
exec tao_thongbao('Thong bao nay danh cho truong bo mon phu trach co so 2','TDV',null,'CS2');
exec tao_thongbao('Thong bao nay danh cho truong khoa','TK',null,null);
exec tao_thongbao('Thong bao nay danh cho nganh HTTT','SV','HTTT',null);
exec tao_thongbao('Thong bao nay danh cho nganh CNPM','SV','CNPM',null);
exec tao_thongbao('Thong bao nay danh cho giang vien','GVien',null,null);
exec tao_thongbao('Thong bao nay danh cho giao vu co so 1','GVu',null,'CS1');
exec tao_thongbao('Thong bao nay danh cho sinh vien','SV',null,null);

insert into thongbao(noidung) values ('ha');
UPDATE admin_ols1.thongbao
SET region_label2 = CHAR_TO_LABEL('REGION_POLICY2','SV::')
where noidung = 'ha';

exec tao_user('SV001','123');
grant select on thongbao to NV001;

BEGIN
 SA_USER_ADMIN.SET_USER_LABELS('region_policy2','SV001','SV:HTTT:CS1');
END;
create role role_sinhvien;
grant role_sinhvien to SV001;
grant select on thongbao to role_sinhvien;
grant select on thongbao to NV002;
/

SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where grantee = 'ADMIN_OLS1';
--alter session set container = ATBM_3;

--create or replace view nhan_ols
--as
--select * from dba_sa_user_levels where policy_name = 'REGION_POLICY2';

create or replace procedure xem_user_level(p_user in varchar2,c1 out SYS_REFCURSOR)
as
begin
open c1 for
select row_level from dba_sa_user_levels where policy_name = 'REGION_POLICY2' and user_name = p_user;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure xem_user_compartment(p_user in varchar2,c1 out SYS_REFCURSOR)
as
begin
open c1 for
select comp from dba_sa_user_compartments where policy_name = 'REGION_POLICY2' and user_name = p_user;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure xem_user_group(p_user in varchar2,c1 out SYS_REFCURSOR)
as
begin
open c1 for
select grp from dba_sa_user_groups where policy_name = 'REGION_POLICY2' and user_name = p_user;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure xem_user_group(p_user in varchar2,c1 out SYS_REFCURSOR)
as
begin
open c1 for
select grp from dba_sa_user_groups where policy_name = 'REGION_POLICY2' and user_name = p_user;
DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure gan_nhan (user nvarchar2, level varchar2, compartment varchar2, p_group varchar2)
as 
STRSQL VARCHAR(2000);
begin
    STRSQL:=level||':';
    if compartment is not null then
        STRSQL:=STRSQL||compartment;
    end if;
    STRSQL:=STRSQL||':';
    if p_group is not null then
        STRSQL:=STRSQL||p_group;
    end if;
     BEGIN
     SA_USER_ADMIN.SET_USER_LABELS('region_policy2',user,STRSQL);
    END;
end;
/