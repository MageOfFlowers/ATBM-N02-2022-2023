--g/
create or replace procedure gan_nhan_g
is
begin
update ATBM_OLS1.THONGBAO
set region_label2 = char_to_label('region_policy2','TK:KHMT:CS1, CS2')
where noidung = 't4';
end;
--h/