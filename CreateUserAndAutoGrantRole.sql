CREATE OR REPLACE PROCEDURE USP_CREATEUSER
AS
    CURSOR CUR IS (SELECT MANV
                    FROM ADMIN_OLS1.NHANSU
                    WHERE MANV NOT IN (SELECT USERNAME
                                        FROM ALL_USERS)
                    UNION SELECT MASV
                    FROM ADMIN_OLS1.sinhvien
                    WHERE MASV NOT IN (SELECT USERNAME
                                        FROM ALL_USERS));
    STRSQL VARCHAR(2000);
    USR VARCHAR2(5);
BEGIN
    OPEN CUR;
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
--    EXECUTE IMMEDIATE(STRSQL);
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
            
        STRSQL := 'CREATE USER '||USR||' IDENTIFIED BY '||USR;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO '||USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
--    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
--    EXECUTE IMMEDIATE(STRSQL);
    CLOSE CUR;
END;
/
exec USP_CREATEUSER;
/
create role role_giaovu;
create role role_giangvien;
create role role_truongkhoa;
create role role_nhanvien;
create role role_truongdonvi;
create role role_sinhvien;
/
CREATE OR REPLACE PROCEDURE USP_ADDUSRMEM
AS
    CURSOR CUR IS (SELECT ns.MANV, ns.VAITRO, dv.TRGDV, dv.TENDV
                    FROM  ADMIN_OLS1.NHANSU ns inner join ADMIN_OLS1.DONVI dv on ns.MADV = dv.MADV 
                    WHERE ns.MANV IN (SELECT USERNAME
                                        FROM ALL_USERS));
    STRSQL VARCHAR(2000);
    USR VARCHAR2(5);
    USR2 VARCHAR2(50);
    USR3 VARCHAR2(5);
    USR4 VARCHAR2(50);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR, USR2, USR3, USR4;
        EXIT WHEN CUR%NOTFOUND;
        IF USR2 = 'Giao vu' THEN
            STRSQL := 'GRANT role_giaovu TO '||USR;
        ELSIF USR2 = 'Nhan vien co ban' THEN
            STRSQL := 'GRANT role_nhanvien TO '||USR;
        ELSIF USR3 = USR AND USR4 = 'Van phong khoa' THEN
            STRSQL := 'GRANT role_truongkhoa TO '||USR;
        ELSIF USR3 = USR THEN
            STRSQL := 'GRANT role_truongdonvi TO '||USR; 
        ELSE STRSQL := 'GRANT role_giangvien TO '||USR;
        END IF;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
/
CREATE OR REPLACE PROCEDURE USP_ADDUSRSTU
AS
    CURSOR CUR IS (SELECT MASV
                   FROM ADMIN_OLS1.SINHVIEN
                   WHERE MASV IN (SELECT USERNAME
                                  FROM ALL_USERS));
    USR VARCHAR2(5); 
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
        EXECUTE IMMEDIATE 'GRANT role_sinhvien TO ' || USR;
    END LOOP;
    CLOSE CUR;
END;
/
exec USP_ADDUSRMEM;
/
exec USP_ADDUSRSTU;