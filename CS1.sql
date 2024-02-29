alter session set "_ORACLE_SCRIPT"=true;

create role ROLE_NHANVIEN
not identified;

create function xem_thong_tin_chinh_minh_function(p_schema varchar2, p_obj varchar2)
return varchar2
as
user varchar2(100);
begin
user := sys_context('userenv', 'session_user');
return 'MANV = ' || user;
end;

execute dbms_rls.add_policy (object_schema => 'ROLE_NHANVIEN',
                            object_name => 'NHANSU',
                            policy_name => 'xem_thong_tin_chinh_minh_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_thong_tin_chinh_minh_function',
                            statement_types => 'select',
                            update_check => TRUE );

execute dbms_rls.add_policy (object_schema => 'ROLE_NHANVIEN',
                            object_name => 'SINHVIEN',
                            policy_name => 'sua_thong_tin_chinh_minh_policy',
                            function_schema => 'sec_mgr',
                            policy_function => 'xem_thong_tin_chinh_minh_function',
                            statement_types => 'update',
                            sec_relevant_cols => 'ĐT');

grant select on SINHVIEN, DONVI, HOCPHAN, KHMO to ROLE_NHANVIEN
