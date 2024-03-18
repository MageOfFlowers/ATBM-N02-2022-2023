alter session set "_ORACLE_SCRIPT"=true;

create role ROLE_TRUONGKHOA
not identified;

grant ROLE_GIANGVIEN to ROLE_TRUONGKHOA;

create function xem_phan_cong_chinh_minh_function(p_schema varchar2, p_obj varchar2)
return varchar2
as
user varchar2(100);
begin
user := sys_context('userenv', 'session_user');
return 'MAGV = ' || user;
end;

create function xem_phan_cong_chinh_minh_function(p_schema varchar2, p_obj varchar2)
return varchar2
as
user varchar2(100);
begin
user := sys_context('userenv', 'session_user');
return 'MAGV = ' || user;
end;

execute dbms_rls.add_policy (object_schema => 'ROLE_TRUONGKHOA',
                            object_name => 'PHANCONG',
                            policy_name => 'xem_phan_cong_chinh_minh_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_phan_cong_chinh_minh_function',
                            statement_types => 'select',
                            update_check => TRUE );

execute dbms_rls.add_policy (object_schema => 'ROLE_GIANGVIEN',
                            object_name => 'DANGKY',
                            policy_name => 'xem_lop_chinh_minh_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_phan_cong_chinh_minh_function',
                            statement_types => 'select',
                            update_check => TRUE );

execute dbms_rls.add_policy (object_schema => 'ROLE_GIANGVIEN',
                            object_name => 'DANGKY',
                            policy_name => 'sua_diem_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_phan_cong_chinh_minh_function',
                            statement_types => 'update',
                            sec_relevant_cols => 'DIEMTH', 'DIEMQT', 'DIEMCK', 'DIEMTK');
