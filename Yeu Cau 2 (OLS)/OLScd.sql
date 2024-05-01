--c) Gan nhan cho 1 giáo v? ??c toan bo thong bao danh cho giao vu
CREATE OR REPLACE PROCEDURE Cap_quyen_a (name in varchar2)
is
begin
    SA_USER_ADMIN.SET_USER_LABELS('region_policy2',name,'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); 
end;

--d)
create or replace procedure gan_nhan_g
is
begin
update ADMIN_OLS1.THONGBAO
set region_label2 = char_to_label('region_policy2','TK:KHMT:CS1, CS2')
where id = 4;
end;