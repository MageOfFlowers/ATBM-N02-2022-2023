BEGIN
 SA_SYSDBA.CREATE_POLICY (
  policy_name      => 'region_policy2',
  column_name      => 'region_label2');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 60,
   short_name    => 'TK',
   long_name     => 'TruongKhoa');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 50,
   short_name    => 'TDV',
   long_name     => 'TruongDonVi');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 40,
   short_name    => 'GVIEN',
   long_name     => 'GiangVien');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 30,
   short_name    => 'GVU',
   long_name     => 'GiaoVu');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 20,
   short_name    => 'NV',
   long_name     => 'NhanVien');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_LEVEL (
   policy_name   => 'region_policy2',
   level_num     => 10,
   short_name    => 'SV',
   long_name     => 'SinhVien');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '65',
   short_name      => 'HTTT',
   long_name       => 'HeThongThongTin');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '55',
   short_name      => 'CNPM',
   long_name       => 'CongNghePhanMem');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '45',
   short_name      => 'KHMT',
   long_name       => 'KhoaHocMayTinh');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '35',
   short_name      => 'CNTT',
   long_name       => 'CongNgheThongTin');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '25',
   short_name      => 'TGMT',
   long_name       => 'ThiGiacMayTinh');
END;
/
BEGIN
  SA_COMPONENTS.CREATE_COMPARTMENT (
   policy_name     => 'region_policy2',
   comp_num        => '15',
   short_name      => 'MMT',
   long_name       => 'MangMayTinh');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_GROUP (
  policy_name     => 'region_policy2',
  group_num       => 100,
  short_name      => 'CS1',
  long_name       => 'CoSo1');
END;
/
BEGIN
 SA_COMPONENTS.CREATE_GROUP (
  policy_name     => 'region_policy2',
  group_num       => 110,
  short_name      => 'CS2',
  long_name       => 'CoSo2');
END;

/
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'100', label_value=>'TK::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'110', label_value=>'TK:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'120', label_value=>'TK:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'130', label_value=>'TK:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'140', label_value=>'TK:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'150', label_value=>'TK:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'160', label_value=>'TK:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'101', label_value=>'TK::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'102', label_value=>'TK::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'111', label_value=>'TK:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'121', label_value=>'TK:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'131', label_value=>'TK:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'141', label_value=>'TK:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'151', label_value=>'TK:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'161', label_value=>'TK:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'112', label_value=>'TK:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'122', label_value=>'TK:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'132', label_value=>'TK:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'142', label_value=>'TK:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'152', label_value=>'TK:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'162', label_value=>'TK:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'200', label_value=>'TDV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'210', label_value=>'TDV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'220', label_value=>'TDV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'230', label_value=>'TDV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'240', label_value=>'TDV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'250', label_value=>'TDV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'260', label_value=>'TDV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'201', label_value=>'TDV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'202', label_value=>'TDV::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'211', label_value=>'TDV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'221', label_value=>'TDV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'231', label_value=>'TDV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'241', label_value=>'TDV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'251', label_value=>'TDV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'261', label_value=>'TDV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'212', label_value=>'TDV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'222', label_value=>'TDV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'232', label_value=>'TDV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'242', label_value=>'TDV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'252', label_value=>'TDV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'262', label_value=>'TDV:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'300', label_value=>'GVIEN::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'310', label_value=>'GVIEN:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'320', label_value=>'GVIEN:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'330', label_value=>'GVIEN:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'340', label_value=>'GVIEN:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'350', label_value=>'GVIEN:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'360', label_value=>'GVIEN:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'301', label_value=>'GVIEN::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'302', label_value=>'GVIEN::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'311', label_value=>'GVIEN:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'321', label_value=>'GVIEN:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'331', label_value=>'GVIEN:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'341', label_value=>'GVIEN:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'351', label_value=>'GVIEN:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'361', label_value=>'GVIEN:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'312', label_value=>'GVIEN:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'322', label_value=>'GVIEN:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'332', label_value=>'GVIEN:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'342', label_value=>'GVIEN:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'352', label_value=>'GVIEN:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'362', label_value=>'GVIEN:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'400', label_value=>'GVU::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'410', label_value=>'GVU:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'420', label_value=>'GVU:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'430', label_value=>'GVU:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'440', label_value=>'GVU:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'450', label_value=>'GVU:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'460', label_value=>'GVU:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'401', label_value=>'GVU::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'402', label_value=>'GVU::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'411', label_value=>'GVU:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'421', label_value=>'GVU:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'431', label_value=>'GVU:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'441', label_value=>'GVU:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'451', label_value=>'GVU:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'461', label_value=>'GVU:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'412', label_value=>'GVU:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'422', label_value=>'GVU:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'432', label_value=>'GVU:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'442', label_value=>'GVU:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'452', label_value=>'GVU:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'462', label_value=>'GVU:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'500', label_value=>'NV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'510', label_value=>'NV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'520', label_value=>'NV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'530', label_value=>'NV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'540', label_value=>'NV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'550', label_value=>'NV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'560', label_value=>'NV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'501', label_value=>'NV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'502', label_value=>'NV::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'511', label_value=>'NV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'521', label_value=>'NV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'531', label_value=>'NV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'541', label_value=>'NV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'551', label_value=>'NV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'561', label_value=>'NV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'512', label_value=>'NV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'522', label_value=>'NV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'532', label_value=>'NV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'542', label_value=>'NV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'552', label_value=>'NV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'562', label_value=>'NV:MMT:CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'600', label_value=>'SV::');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'610', label_value=>'SV:HTTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'620', label_value=>'SV:CNPM:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'630', label_value=>'SV:KHMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'640', label_value=>'SV:CNTT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'650', label_value=>'SV:TGMT:');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'660', label_value=>'SV:MMT:');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'601', label_value=>'SV::CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'602', label_value=>'SV::CS2');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'611', label_value=>'SV:HTTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'621', label_value=>'SV:CNPM:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'631', label_value=>'SV:KHMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'641', label_value=>'SV:CNTT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'651', label_value=>'SV:TGMT:CS1');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'661', label_value=>'SV:MMT:CS1');

execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'612', label_value=>'SV:HTTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'622', label_value=>'SV:CNPM:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'632', label_value=>'SV:KHMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'642', label_value=>'SV:CNTT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'652', label_value=>'SV:TGMT:CS2');
execute sa_label_admin.create_label (policy_name=>'region_policy2', label_tag=>'662', label_value=>'SV:MMT:CS2');

/
-------------------------------------------------
begin
SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
 POLICY_NAME => 'region_policy2',
 SCHEMA_NAME => 'ADMIN_OLS1',
 TABLE_NAME => 'THONGBAO',
 TABLE_OPTIONS => 'NO_CONTROL'
 );
 end;
 
 BEGIN
 SA_USER_ADMIN.SET_USER_LABELS('region_policy2','SV001','SV:HTTT:CS1');
END;

begin
SA_USER_ADMIN.SET_USER_LABELS('region_policy2','NV001','TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); 
end;    
begin
SA_USER_ADMIN.SET_USER_LABELS('region_policy2','NV002','Gvien:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); 
end;  
    BEGIN
        SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY2','ADMIN_OLS1','THONGBAO');
--        SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
--         policy_name => 'REGION_POLICY2',
--         schema_name => 'ADMIN_OLS1',
--         table_name => 'THONGBAO',
--         table_options => 'READ_CONTROL'
       -- );
    END;
    