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
/*Chay lenh grant bang sys truoc khi chay:
grant select on DBA_SA_USER_GROUPS to admin_ols1;
*/

--1. Gan nhan cho nhan vien de co the doc toan bo thong bao cua sinh vien bat ke khoa nao cua co so ?o

/
create or replace procedure gan_nhan_h1(name in varchar2)
is
co_so varchar(20);
cs_temp varchar(10);
row_count number;
cursor cs_cur is
    select grp from DBA_SA_USER_GROUPS
    where user_name = name;
begin
    select count(distinct grp) into row_count from DBA_SA_USER_GROUPS where user_name = name;
    if (row_count = 0) then
        rollback;
    elsif (row_count = 1) then
        select grp into co_so from DBA_SA_USER_GROUPS where user_name = name;
    else
        open cs_cur;
        loop
            fetch cs_cur into cs_temp;
            exit when cs_cur%notfound;
            begin
                co_so := co_so || ',' || cs_temp;
            end;
        end loop;
        close cs_cur;
        co_so := LTRIM(co_so, ',');
    end if;
    begin
    sa_user_admin.set_user_labels('region_policy2', name, 'SV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:' || co_so);
    end;
end;
/
create or replace procedure gan_nhan_hang_loat_h1
is
    cursor cur is
        select manv from admin_ols1.nhansu
        where vaitro = 'Nhan vien co ban';
    user varchar2(10);
begin
    open cur;
    loop
        fetch cur into user;
        exit when cur%notfound;
        begin
            gan_nhan_h1(user);
        end;
    end loop;
    close cur;
end;
/
--exec gan_nhan_hang_loat_h1;

--2. Gan nhan cho 1 nhan vien de co the doc toan bo thong bao cua nhan vien cua co so do
create or replace procedure gan_nhan_h2(name in varchar2)
is
co_so varchar(20);
cs_temp varchar(10);
row_count number;
cursor cs_cur is
    select grp from DBA_SA_USER_GROUPS
    where user_name = name;
begin
    select count(distinct grp) into row_count from DBA_SA_USER_GROUPS where user_name = name;
    if (row_count = 0) then
        rollback;
    elsif (row_count = 1) then
        select grp into co_so from DBA_SA_USER_GROUPS where user_name = name;
    else
        open cs_cur;
        loop
            fetch cs_cur into cs_temp;
            exit when cs_cur%notfound;
            begin
                co_so := co_so || ',' || cs_temp;
            end;
        end loop;
        close cs_cur;
        co_so := LTRIM(co_so, ',');
    end if;
    begin
    sa_user_admin.set_user_labels('region_policy2', name, 'NV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:' || co_so);
    end;
end;
/
create or replace procedure gan_nhan_hang_loat_h2
is
    cursor cur is
        select manv from admin_ols1.nhansu
        where vaitro = 'Nhan vien co ban';
    user varchar2(10);
begin
    open cur;
    loop
        fetch cur into user;
        exit when cur%notfound;
        begin
            gan_nhan_h1(user);
        end;
    end loop;
    close cur;
end;
/
--3. Gan nhan cho truong don vi HTTT ?e co the doc toan bo thong bao cua Truong don vi bat ke khoa nao
create or replace procedure gan_nhan_h3(name in varchar2)
is
begin
    sa_user_admin.set_user_labels('region_policy2', name, 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
end;
/
create or replace procedure gan_nhan_hang_loat_h2
is
    cursor cur is
        select manv from admin_ols1.nhansu
        where vaitro = 'Truong don vi' and madv = 'HTTT';
    user varchar2(10);
begin
    open cur;
    loop
        fetch cur into user;
        exit when cur%notfound;
        begin
            gan_nhan_h1(user);
        end;
    end loop;
    close cur;
end;
/
















BEGIN 
sa_user_admin.set_user_labels('region_policy2', 'NV001', 'SV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');
END;
BEGIN 
 SA_USER_ADMIN.DROP_USER_ACCESS (
  policy_name       => 'region_policy2',
  user_name         => 'NV003');
END;
SELECT * FROM DBA_SA_USER_GROUPS;
SELECT * FROM DBA_SA_USER_COMPARTMENTS;