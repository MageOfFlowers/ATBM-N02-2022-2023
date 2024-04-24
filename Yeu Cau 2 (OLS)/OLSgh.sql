--g/
create or replace procedure gan_nhan_g
is
begin
update ADMIN_OLS1.THONGBAO
set region_label2 = char_to_label('region_policy2','TK:KHMT:CS1, CS2')
where id = 4;
end;
--exec GAN_NHAN_G;
--h/
