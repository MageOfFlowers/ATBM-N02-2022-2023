grant select, insert, delete on dangky to role_sinhvien;
grant select on hocphan to role_sinhvien;
grant select on khmo to role_sinhvien;
grant select, update(dchi, dt) on sinhvien to role_sinhvien;
grant role_sinhvien to SV001;
/
Create or replace function xem_cua_chinh_minh_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
user VARCHAR2(100);
Begin
user := SYS_CONTEXT('userenv', 'SESSION_USER');
for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
loop
    IF r.granted_role = 'ROLE_SINHVIEN' then 
        return 'MASV = ''' || user ||'''';
    end if;
END LOOP;
    return '1=1';
End;
/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'SINHVIEN',
                            policy_name => 'xem_cua_chinh_minh_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_cua_chinh_minh_function',
                            statement_types => 'select');
end;
/
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                      object_name => 'SINHVIEN',
                      policy_name => 'xem_cua_chinh_minh_policy');
end;
*/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'DANGKY',
                            policy_name => 'xem_cua_chinh_minh_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_cua_chinh_minh_function',
                            statement_types => 'select');
end;
/
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                      object_name => 'DANGKY',
                      policy_name => 'xem_cua_chinh_minh_policy');
end;
*/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'SINHVIEN',
                            policy_name => 'sua_cua_chinh_minh_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_cua_chinh_minh_function',
                            statement_types => 'update',
                            sec_relevant_cols => 'DCHI, DT',
                            update_check => true);
end;
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                      object_name => 'SINHVIEN',
                      policy_name => 'sua_cua_chinh_minh_policy');
end;
*/
/
Create or replace function xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
p_MACT VARCHAR2(100);
TYPE v_array_type IS VARRAY (20) OF CHAR(8);
        mahpArr v_array_type;
        mahp_s varchar(200);
user VARCHAR2(100);
Begin
user := SYS_CONTEXT('userenv', 'SESSION_USER');
for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
loop
    IF r.granted_role = 'ROLE_SINHVIEN' then 
        begin
        SELECT MACT INTO p_MACT FROM admin_ols1.SINHVIEN WHERE MASV = SYS_CONTEXT('userenv', 'SESSION_USER');
        select MAHP bulk collect into mahpArr from Admin_ols1.PHANCONG where MACT = p_MACT;
        if(mahpArr.count>1) then
            begin
            mahp_s:= chr(39)|| mahpArr(1) || chr(39);
                for x in 2..mahpArr.count 
                loop
                  mahp_s := mahp_s||','||chr(39)|| mahpArr(x)|| chr(39);
                end loop;
            end;
        end if;
        return 'MAHP in (' || mahp_s || ')';
        end;
    end if;
END LOOP;
return '1=1';
End;

/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'KHMO',
                            policy_name => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_function',
                            statement_types => 'select');
end;       
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'KHMO',
                            policy_name => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_policy');
end;
*/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'HOCPHAN',
                            policy_name => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_policy2',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_function',
                            statement_types => 'select');
end;    
/       
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'HOCPHAN',
                            policy_name => 'xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_policy2');
end;
*/
Create or replace function dang_ky_hoc_phan_trong_hoc_ky_nay_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
p_MACT VARCHAR2(100);
p_MAHP VARCHAR2(100);
p_NAM INTEGER;
p_HK INTEGER;
user VARCHAR2(100);
CURRENT_DATE date;
first date;
second date;
third date;
Begin
user := SYS_CONTEXT('userenv', 'SESSION_USER');
for r in (SELECT granted_role FROM DBA_ROLE_PRIVS where grantee = user)
loop
    IF r.granted_role = 'ROLE_SINHVIEN' then 
    begin
SELECT TRUNC(CURRENT_DATE) into current_date FROM dual;
first := to_date('1-JAN');
second := to_date('1-MAY');
third := to_date('1-SEP');
p_NAM := EXTRACT(YEAR FROM CURRENT_DATE);
IF EXTRACT(DAY FROM CURRENT_DATE) BETWEEN EXTRACT(DAY FROM first+14) AND EXTRACT(DAY FROM first) AND
    EXTRACT(MONTH FROM CURRENT_DATE) BETWEEN EXTRACT(MONTH FROM first+14) AND EXTRACT(MONTH FROM first) THEN
    p_HK := 1;
ELSIF EXTRACT(DAY FROM CURRENT_DATE) BETWEEN EXTRACT(DAY FROM second+14) AND EXTRACT(DAY FROM second) AND
    EXTRACT(MONTH FROM CURRENT_DATE) BETWEEN EXTRACT(MONTH FROM second+14) AND EXTRACT(MONTH FROM second) THEN
    p_HK := 2;
ELSIF EXTRACT(DAY FROM CURRENT_DATE) BETWEEN EXTRACT(DAY FROM third+14) AND EXTRACT(DAY FROM third) AND
    EXTRACT(MONTH FROM CURRENT_DATE) BETWEEN EXTRACT(MONTH FROM third+14) AND EXTRACT(MONTH FROM third) THEN
    p_HK := 3; 
ELSE
    p_HK := 0;
END IF;
user := SYS_CONTEXT('userenv', 'SESSION_USER');
SELECT MACT INTO p_MACT FROM SINHVIEN WHERE MASV = SYS_CONTEXT('userenv', 'SESSION_USER');
SELECT MAHP INTO p_MAHP FROM KHMO WHERE MACT = p_MACT;
return 'NAM = ''' || p_NAM ||''' AND HK = ''' || p_HK || ''' AND MASV = ''' || user || ''' AND MAHP = ''' || p_MAHP || '''';
end;
end if;
end loop;
return '1=1';
End;                                                    
/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'DANGKY',
                            policy_name => 'dang_ky_hoc_phan_trong_hoc_ky_nay_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'dang_ky_hoc_phan_trong_hoc_ky_nay_function',
                            statement_types => 'insert, delete',
                            update_check => TRUE );
end;
/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'KHMO',
                            policy_name => 'dang_ky_hoc_phan_trong_hoc_ky_nay_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'dang_ky_hoc_phan_trong_hoc_ky_nay_function',
                            statement_types => 'select');
end;
/
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'DANGKY',
                            policy_name => 'dang_ky_hoc_phan_trong_hoc_ky_nay_policy');
end;
*/
begin
dbms_rls.add_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'DANGKY',
                            policy_name => 'xem_hoc_phan_trong_hoc_ky_nay_policy',
                            function_schema => 'ADMIN_OLS1',
                            policy_function => 'xem_cua_chinh_minh_function',
                            statement_types => 'select',
                            update_check => TRUE );
end;
/*
begin
dbms_rls.drop_policy (object_schema => 'ADMIN_OLS1',
                            object_name => 'DANGKY',
                            policy_name => 'xem_hoc_phan_trong_hoc_ky_nay_policy');
end;
*/