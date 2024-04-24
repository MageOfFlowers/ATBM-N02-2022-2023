--Xem ds user
create or replace procedure DS_User (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    select USERNAME,Account_status from CDB_USERS a ,dba_pdbs b
    where 1=1 and user_id > 108 and user_id < 500
    and b.PDB_ID=a.CON_ID and username != 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
--Xem ds table
create or replace procedure ADMIN_OLS1.xem_ds_table (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT distinct(table_name)
                    FROM dba_tables
                    where owner = 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
--Tao user
CREATE OR REPLACE PROCEDURE Tao_User (Name VARCHAR2, Pasw VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'CREATE USER '||Name||' IDENTIFIED BY '||Pasw;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'GRANT CONNECT TO '||Name;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Tao role
CREATE OR REPLACE PROCEDURE Tao_Role (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'CREATE ROLE '||Name;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Xoa user
CREATE OR REPLACE PROCEDURE Xoa_User (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'DROP USER '||Name;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Xoa role
CREATE OR REPLACE PROCEDURE Xoa_Role (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'DROP ROLE '||Name;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Hieu chinh mk user
CREATE OR REPLACE PROCEDURE Doi_MK_User (Name VARCHAR2, newPass VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'alter user '|| Name ||' identified by '|| newPass;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Hieu chinh trang thai user
CREATE OR REPLACE PROCEDURE Doi_Trangthai_User (Name VARCHAR2, Status VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'alter user '|| Name ||' account '|| Status;
    EXECUTE IMMEDIATE(STRSQL);
END;
/
--Cap quyen U/I/D cho user
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
--Cap quyen U/I/D cho role
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
--Cap role cho user
create or replace procedure cap_role_cho_user (rolename varchar2,username varchar2)
as
STRSQL VARCHAR(2000);
begin
    STRSQL:='grant '||rolename||' to '||username;
    execute immediate(STRSQL);
end;
/
--Cap quyen select cho user/role
create or replace procedure cap_quyen_select_cho_user (username varchar2, bang varchar2, ten_cac_cot varchar2,tuy_chon boolean)
as
STRSQL VARCHAR(2000);
begin
    STRSQL:='create or replace view '||username||'_'||bang||' as
    select '||ten_cac_cot||' from '||bang;
    execute immediate(STRSQL);
    STRSQL:='grant select on view '||username||'_'||bang||' to '||username;
    if (tuy_chon=true) then STRSQL:=STRSQL||' with grant option'; end if;
    execute immediate(STRSQL);
end;
/
--Xem quyen cua user va role
create or replace procedure ADMIN_OLS1.xem_quyen_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    Select distinct table_name, privilege, grantable from (
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee = upper(p_user)
    union
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee in (select granted_role from DBA_ROLE_PRIVS where grantee = upper(p_user))
    union
    SELECT table_name, privilege, grantable
                    FROM ALL_COL_PRIVS
                    where grantor = 'ADMIN_OLS1' and grantee = p_user);
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
--Thu hoi quyen user
CREATE OR REPLACE PROCEDURE Thu_hoi_quyen_UserRole(Privilege VARCHAR2, Object VARCHAR2, Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'REVOKE '|| Privilege ||' ON '||Object||' FROM '||Name;
    EXECUTE IMMEDIATE(STRSQL);
END;
/

create or replace procedure DS_Proc (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT object_name FROM user_procedures WHERE object_type = 'PROCEDURE';
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure DS_View (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT view_name FROM all_views where owner = 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;
/

create or replace procedure ADMIN_OLS1.xem_ds_table (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT distinct(table_name)
                    FROM dba_tables
                    where owner = 'ADMIN_OLS1';
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure ADMIN_OLS1.xem_quyen_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    Select distinct table_name, privilege, grantable from (
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee = upper(p_user)
    union
    SELECT table_name, privilege, grantable
                    FROM dba_tab_privs 
                    where owner = 'ADMIN_OLS1' and grantee in (select granted_role from DBA_ROLE_PRIVS where grantee = upper(p_user))
    union
    SELECT table_name, privilege, grantable
                    FROM ALL_COL_PRIVS
                    where grantor = 'ADMIN_OLS1' and grantee = p_user);
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure ADMIN_OLS1.xem_role_user (p_user in varchar, c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    SELECT granted_role FROM DBA_ROLE_PRIVS WHERE grantee = p_user;
    DBMS_SQL.RETURN_RESULT(c1);
end;
