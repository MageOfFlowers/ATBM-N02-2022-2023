CREATE OR REPLACE PROCEDURE Cap_quyen_a (name in varchar2)
is
begin
    SA_USER_ADMIN.SET_USER_LABELS('region_policy2',name,'TK: HTTT, CNPM, KHMT, CNTT, TGMT, MMT: CS1, CS2'); 
end;
/
CREATE OR REPLACE PROCEDURE USP_Cap_quyen_hang_loat_a
AS
    CURSOR CUR IS (SELECT ns.MANV
                    FROM  ADMIN_OLS1.NHANSU ns inner join ADMIN_OLS1.DONVI dv on ns.MANV = dv.TRGDV 
                    WHERE ns.MANV IN (SELECT USERNAME
                                        FROM ALL_USERS) AND dv.TENDV = 'Van phong khoa');
    STRSQL VARCHAR(2000);
    USR VARCHAR2(5);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;
        
        begin
            SA_USER_ADMIN.SET_USER_LABELS('region_policy2',USR,'TK: HTTT, CNPM, KHMT, CNTT, TGMT, MMT: CS1, CS2'); 
        end;
    END LOOP;
    CLOSE CUR;
END;
/
conn lbacsys/123

exec USP_Cap_quyen_hang_loat_a;
/
CREATE OR REPLACE PROCEDURE Cap_quyen_b (name in varchar2, donvi in varchar2)
is
begin
    SA_USER_ADMIN.SET_USER_LABELS('region_policy',name,'TDV :'||donvi||':CS1, CS2'); 
end;
/
CREATE OR REPLACE PROCEDURE USP_Cap_quyen_hang_loat_b
AS
    CURSOR CUR IS (SELECT ns.MANV, ns.MADV
                    FROM  ADMIN_OLS1.NHANSU ns inner join ADMIN_OLS1.DONVI dv on ns.MANV = dv.TRGDV 
                    WHERE ns.MANV IN (SELECT USERNAME
                                        FROM ALL_USERS) AND dv.TENDV != 'Van phong khoa');
    STRSQL VARCHAR(2000);
    USR VARCHAR2(5);
    USR2 VARCHAR2(5);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO USR, USR2;
        EXIT WHEN CUR%NOTFOUND;
        
        begin
            SA_USER_ADMIN.SET_USER_LABELS('region_policy',USR,'TDV :'||USR2||':CS1, CS2'); 
        end;
    END LOOP;
    CLOSE CUR;
END;


