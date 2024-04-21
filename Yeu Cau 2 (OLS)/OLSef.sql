exec tao_thongbao('Thong bao nay danh cho sinh vien HTTT o co so 1','SV','HTTT','CS1');
/
BEGIN
        SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY2','ADMIN_OLS1','THONGBAO');
        SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
        POLICY_NAME => 'region_policy2',
        SCHEMA_NAME => 'ADMIN_OLS1',
        TABLE_NAME => 'THONGBAO',
        TABLE_OPTIONS => 'NO_CONTROL'
 );
END;
/
SELECT noidung,label_to_char(region_label2) as label FROM thongbao 
WHERE region_label2 = char_to_label('REGION_POLICY2', 'SV:HTTT:CS1') 
or region_label2 = char_to_label('REGION_POLICY2', 'SV::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'SV:HTTT:')
or region_label2 = char_to_label('REGION_POLICY2', 'SV::');
/
exec tao_thongbao('Thong bao nay danh cho truong bo mon KHMT o co so 1','TDV','KHMT','CS1');
/
BEGIN
        SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('REGION_POLICY2','ADMIN_OLS1','THONGBAO');
        SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
        POLICY_NAME => 'region_policy2',
        SCHEMA_NAME => 'ADMIN_OLS1',
        TABLE_NAME => 'THONGBAO',
        TABLE_OPTIONS => 'NO_CONTROL'
 );
END;
/
SELECT noidung,label_to_char(region_label2) as label FROM thongbao
WHERE region_label2 = char_to_label('REGION_POLICY2', 'TDV:KHMT:CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'TDV::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'TDV:KHMT:')
or region_label2 = char_to_label('REGION_POLICY2', 'TDV::')
or region_label2 = char_to_label('REGION_POLICY2', 'GVIEN:KHMT:CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'GVIEN::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'GVIEN:KHMT:')
or region_label2 = char_to_label('REGION_POLICY2', 'GVIEN::')
or region_label2 = char_to_label('REGION_POLICY2', 'GVU:KHMT:CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'GVU::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'GVU:KHMT:')
or region_label2 = char_to_label('REGION_POLICY2', 'GVU::')
or region_label2 = char_to_label('REGION_POLICY2', 'NV:KHMT:CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'NV::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'NV:KHMT:')
or region_label2 = char_to_label('REGION_POLICY2', 'NV::')
or region_label2 = char_to_label('REGION_POLICY2', 'SV:KHMT:CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'SV::CS1')
or region_label2 = char_to_label('REGION_POLICY2', 'SV:KHMT:')
or region_label2 = char_to_label('REGION_POLICY2', 'SV::');