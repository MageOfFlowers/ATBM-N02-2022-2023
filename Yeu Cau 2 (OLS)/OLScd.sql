--c) Gan nhan cho 1 giáo v? ??c toan bo thong bao danh cho giao vu
/
CREATE OR REPLACE PROCEDURE Cap_quyen_c (name in varchar2)
is
begin
    SA_USER_ADMIN.SET_USER_LABELS('region_policy2',name,'GVU:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2'); 
end;
/
create or replace procedure gan_nhan_hang_loat_h2
is
    cursor cur is
        select manv from admin_ols1.nhansu
        where vaitro = 'Giao vu';
    user varchar2(10);
begin
    open cur;
    loop
        fetch cur into user;
        exit when cur%notfound;
        begin
            Cap_quyen_c(user);
        end;
    end loop;
    close cur;
end;

--exec gan_nhan_hang_loat_h2;

--d)
create or replace procedure gan_nhan_d
is
begin
update ADMIN_OLS1.THONGBAO
set region_label2 = char_to_label('region_policy2','TDV::')
where id = 4;
end;

exec GAN_NHAN_D;

--SELECT * FROM DBA_SA_USER_GROUPS;
--SELECT * FROM DBA_SA_USER_COMPARTMENTS;