GRANT INHERIT PRIVILEGES ON USER SYS TO ORDSYS;
CONNECT SYS AS SYSOPER
show pdbs;
BEGIN
 SA_SYSDBA.CREATE_POLICY (
  policy_name      => 'emp_ols_pol',
  column_name      => 'ols_col',
  default_options  => 'read_control, update_control');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 60,
   short_name    => 'TK',
   long_name     => 'TruongKhoa');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 50,
   short_name    => 'TDV',
   long_name     => 'TruongDonVi');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 40,
   short_name    => 'GVIEN',
   long_name     => 'GiangVien');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 30,
   short_name    => 'GVU',
   long_name     => 'GiaoVu');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 20,
   short_name    => 'NV',
   long_name     => 'NhanVien');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'emp_ols_pol',
   level_num     => 10,
   short_name    => 'SV',
   long_name     => 'SinhVien');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '65',
   short_name      => 'HTTT',
   long_name       => 'HeThongThongTin');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '55',
   short_name      => 'CNPM',
   long_name       => 'CongNghePhanMem');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '45',
   short_name      => 'KHMT',
   long_name       => 'KhoaHocMayTinh');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '35',
   short_name      => 'CNTT',
   long_name       => 'CongNgheThongTin');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '25',
   short_name      => 'TGMT',
   long_name       => 'ThiGiacMayTinh');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'emp_ols_pol',
   comp_num        => '15',
   short_name      => 'MMT',
   long_name       => 'MangMayTinh');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_GROUP (
  policy_name     => 'emp_ols_pol',
  group_num       => 100,
  short_name      => 'CS1',
  long_name       => 'CoSo1');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_GROUP (
  policy_name     => 'emp_ols_pol',
  group_num       => 110,
  short_name      => 'CS2',
  long_name       => 'CoSo2');
END;
/
BEGIN
 SA_USER_ADMIN.APPLY_SCHEMA_POLICY (
  policy_name      => 'emp_ols_pol',
  schema_name      => 'sys', 
  default_options  => NULL);
END;
/