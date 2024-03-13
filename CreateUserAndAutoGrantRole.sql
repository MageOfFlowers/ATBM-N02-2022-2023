CREATE OR REPLACE PROCEDURE USP_CREATEUSER
AS
    CURSOR CUR IS (SELECT MANV
                    FROM ADMIN_OLS1.NHANSU
                    WHERE MANV NOT IN (SELECT USERNAME
                                        FROM ALL_USERS));
    STRSQL VARCHAR(2000);
    USR VARCHAR2(5);
BEGIN
    OPEN CUR;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
            
        STRSQL := 'CREATE USER '||USR||' IDENTIFIED BY '||USR;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO '||USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
    CLOSE CUR;
END;

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
        FETCH CUR INTO USR, USR2;
        EXIT WHEN CUR%NOTFOUND;
        IF USR2 = 'Giao vu' THEN
            STRSQL := 'GRANT GVu TO '||USR;
        ELSIF USR2 = 'Nhan vien co ban' THEN
            STRSQL := 'GRANT NV TO '||USR;
        ELSIF USR3 = USR AND USR4 = 'Van phong khoa' THEN
            STRSQL := 'GRANT TK TO '||USR;
        ELSIF USR3 = USR THEN
            STRSQL := 'GRANT TDV TO '||USR; 
        ELSE STRSQL := 'GRANT GVien TO '||USR;
        END IF;
        EXECUTE IMMEDIATE (STRSQL);
    END LOOP;
    CLOSE CUR;
END;
