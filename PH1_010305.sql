SELECT * FROM dba_users;

--01
create or replace procedure ListUserAccounts
as
c1 SYS_REFCURSOR; 
begin
    open c1 for
    SELECT * FROM dba_users;
    DBMS_SQL.RETURN_RESULT(c1);
end;
//
EXEC ListUserAccounts;
/

--03
CREATE OR REPLACE PROCEDURE Tao_User (Name VARCHAR2, Pasw VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'CREATE USER '||Name||' IDENTIFIED BY '||Pasw;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Tao_User('Jin', '1231');
/

CREATE OR REPLACE PROCEDURE Tao_Role (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'CREATE ROLE '||Name;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Tao_Role('Role_Jin');
/

CREATE OR REPLACE PROCEDURE Xoa_User (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'DROP USER '||Name;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Xoa_User('Jin');
/

CREATE OR REPLACE PROCEDURE Xoa_Role (Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'DROP ROLE '||Name;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Xoa_Role('Role_Jin');
/

CREATE OR REPLACE PROCEDURE Doi_MK_User (Name VARCHAR2, newPass VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'alter user '|| Name ||' identified by '|| newPass;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Doi_MK_User('Jin', '133');
/

CREATE OR REPLACE PROCEDURE Doi_Trangthai_User (Name VARCHAR2, Status VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'alter user '|| Name ||' account '|| Status;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Doi_Trangthai_User('Jin', 'unlock');
/

--grant Select on NHANSU to Jin;
--revoke select on NHANSU from Jin;

--Grant select on NHANSU to Role_Jin;
--revoke select on NHANSU from Role_Jin;

--05
CREATE OR REPLACE PROCEDURE Thu_hoi_quyen_UserRole(Privilege VARCHAR2, Object VARCHAR2, Name VARCHAR2)
AS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'REVOKE '|| Privilege ||' ON '||Object||' FROM '||Name;
    EXECUTE IMMEDIATE(STRSQL);
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
//
EXEC Thu_hoi_quyen_UserRole('SELECT', 'NHANSU', 'Jin');
EXEC Thu_hoi_quyen_UserRole('SELECT', 'NHANSU', 'Role_Jin');
/


