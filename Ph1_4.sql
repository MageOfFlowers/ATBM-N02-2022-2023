create or replace procedure cap_quyen_cho_user (quyen varchar2,username varchar2,bang varchar2,tuy_chon boolean,cot varchar2)
as
STRSQL VARCHAR(2000);
begin
    if(quyen='UPDATE') then
        STRSQL:='grant update('||cot||') on '||bang||' to '||username;
    else
        STRSQL:='grant '||quyen||' on '||bang||' to '||username;
    end if;
    if(tuy_chon=true) then 
        STRSQL:=STRSQL||' with grant option';
    end if;
    execute immediate(STRSQL);
end;
/
create or replace procedure cap_quyen_cho_role (quyen varchar2,rolename varchar2,bang varchar2,cot varchar2)
as
STRSQL VARCHAR(2000);
begin
   if(quyen='UPDATE') then
        STRSQL:='grant update('||cot||') on '||bang||' to '||rolename;
    else
        STRSQL:='grant '||quyen||' on '||bang||' to '||rolename;
    end if;
    execute immediate(STRSQL);
end;
/
create or replace procedure cap_role_cho_user (rolename varchar2,username varchar2)
as
STRSQL VARCHAR(2000);
begin
    STRSQL:='grant '||rolename||' to '||username;
    execute immediate(STRSQL);
end;
/
create or replace procedure cap_quyen_select_cho_user (username varchar2, tablename varchar2, ten_cac_cot varchar2)
as
STRSQL VARCHAR(2000);
begin
    STRSQL:='create or replace view '||username||'_'||tablename||' as
    select '||ten_cac_cot||' from '||tablename;
    execute immediate(STRSQL);
    STRSQL:='grant select on view '||username||'_'||tablename||' to '||username;
    execute immediate(STRSQL);
end;
--drop user user1 cascade;
--create user user1 identified by 123;
--grant create session to user1;
--create role role1;
--grant update(MASV) on dangky to user1;
--exec cap_quyen_cho_user('update','user1','dangky',false,'MASV');
--exec cap_quyen_cho_user('delete','user1','sinhvien',false,'');
--show con_name;
--revoke select on ADMIN_OLS1.dangky from user1;
--exec cap_quyen_cho_role('update','role1','nhansu','MANV');
--exec cap_quyen_cho_role('delete','role1','nhansu','');
--
--exec cap_role_cho_user('role1','user2',false);