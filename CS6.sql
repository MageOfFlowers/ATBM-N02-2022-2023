alter session set "_ORACLE_SCRIPT"=true;

CREATE ROLE ROLE_SINHVIEN
NOT IDENTIFIED;

Create function xem_cua_chinh_minh_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
user VARCHAR2(100);
Begin
user := SYS_CONTEXT(‘userenv’, ‘SESSION_USER’);
return ‘MASV = ‘ || user;
End;

execute dbms_rls.add_policy (object_schema => ‘ROLE_SINHVIEN’,
                            object_name => ‘SINHVIEN’,
                            policy_name => ‘xem_cua_chinh_minh_policy’,
                            function_schema => ‘sec_mgr’,
                            policy_function => ‘xem_cua_chinh_minh_function’,
                            statement_types => ‘select’,
                            update_check => TRUE );
                            
execute dbms_rls.add_policy (object_schema => ‘ROLE_SINHVIEN’,
                            object_name => ‘SINHVIEN’,
                            policy_name => ‘sua_cua_chinh_minh_policy’,
                            function_schema => ‘sec_mgr’,
                            policy_function => ‘xem_cua_chinh_minh_function’,
                            sec_relevant_cols => ‘DCHI’, 'DT');

Create function xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
p_MACT VARCHAR2(100);
p_MAMH VARCHAR2(100);
user VARCHAR2(100);
Begin
user := SYS_CONTEXT(‘userenv’, ‘SESSION_USER’);
SELECT MACT INTO p_MACT FROM SINHVIEN WHERE MASV = SYS_CONTEXT(‘userenv’, ‘SESSION_USER’);
SELECT MAMH INTO p_MAMH FROM KHMO WHERE MACT = p_MACT;
return ‘MAMH = ‘ || p_MAMH;
End;

execute dbms_rls.add_policy (object_schema => ‘ROLE_SINHVIEN’,
                            object_name => ‘KHMO’, 'HOCPHAN',
                            policy_name => ‘xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_policy’,
                            function_schema => ‘sec_mgr’,
                            policy_function => ‘xem_mon_hoc_trong_chuong_trinh_cua_chinh_minh_function’,
                            statement_types => ‘select’,
                            update_check => TRUE );
         
                         
Create function dang_ky_hoc_phan_trong_hoc_ky_nay_function(p_schema varchar2, p_obj varchar2)
Return varchar2
As
p_MACT VARCHAR2(100);
p_MAMH VARCHAR2(100);
p_NAM INTEGER;
p_HK INTEGER;
user VARCHAR2(100);
CURRENT_DATE date;
first date;
second date;
third date;
Begin
SELECT TRUNC(CURRENT_DATE) AS current_date FROM dual;
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
user := SYS_CONTEXT(‘userenv’, ‘SESSION_USER’);
SELECT MACT INTO p_MACT FROM SINHVIEN WHERE MASV = SYS_CONTEXT(‘userenv’, ‘SESSION_USER’);
SELECT MAMH INTO p_MAMH FROM KHMO WHERE MACT = p_MACT;
return ‘NAM = ‘ || p_NAM AND 'HK = ' || p_HK AND 'MASV = ' || user;
End;                                                    

execute dbms_rls.add_policy (object_schema => ‘ROLE_SINHVIEN’,
                            object_name => ‘DANGKY’,
                            policy_name => ‘dang_ky_hoc_phan_trong_hoc_ky_nay_policy’,
                            function_schema => ‘sec_mgr’,
                            policy_function => ‘dang_ky_hoc_phan_trong_hoc_ky_nay_function’,
                            statement_types => ‘insert’, 'delete',
                            update_check => TRUE );
                            
execute dbms_rls.add_policy (object_schema => ‘ROLE_SINHVIEN’,
                            object_name => ‘DANGKY’,
                            policy_name => ‘xem_hoc_phan_trong_hoc_ky_nay_policy’,
                            function_schema => ‘sec_mgr’,
                            policy_function => ‘xem_cua_chinh_minh_function’,
                            statement_types => ‘select’,
                            update_check => TRUE );