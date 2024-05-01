--c) Gan nhan cho 1 giáo v? ??c toan bo thong bao danh cho giao vu
CREATE OR REPLACE PROCEDURE Cap_quyen_c (name in varchar2)
is
begin
    SA_USER_ADMIN.SET_USER_LABELS('region_policy2',name,'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); 
end;

//exec Cap_quyen_c('NV006');


--d)
create or replace procedure gan_nhan_d
is
begin
update ADMIN_OLS1.THONGBAO
set region_label2 = char_to_label('region_policy2','TDV::')
where id = 4;
end;