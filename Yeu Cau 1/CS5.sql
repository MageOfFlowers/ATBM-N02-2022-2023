alter session set "_ORACLE_SCRIPT"=true;

create role ROLE_TRUONGKHOA
not identified;

grant ROLE_GIANGVIEN to ROLE_TRUONGKHOA;
grant select, update, delete on NHANSU to ROLE_GIANGVIEN;
grant SELECT ANY TABLE on NHANSU to ROLE_GIANGVIEN;


create function xem_phan_cong_chinh_minh_function(p_schema varchar2, p_obj varchar2)
return varchar2
as
user varchar2(100);
begin
    user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MANV INTO p_MANV FROM NHANSU WHERE MANV = SYS_CONTEXT('userenv', 'SESSION_USER') and MANV = 'VPK';
    SELECT MAGV INTO p_MAGV FROM PHANCONG WHERE MAGV = p_MANV;
    return 'MAGV = ''' || p_MAGV || '''';
end;

execute dbms_rls.add_policy (object_schema => 'ROLE_TRUONGKHOA',
                            object_name => 'PHANCONG',
                            policy_name => 'xem_phan_cong_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_phan_cong_chinh_minh_function',
                            statement_types => 'select', 'delete',
                            update_check => TRUE );