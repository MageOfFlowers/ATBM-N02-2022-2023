create or replace procedure xem_ds_ke_hoach_mo (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    select k.mahp, h.tenhp, k.hk, k.nam, k.mact 
    from khmo k join hocphan h
    on k.mahp = h.mahp;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure xem_ds_hoc_phan (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    select *
    from hocphan;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/
create or replace procedure them_ke_hoach (m_mahp varchar2, m_hk integer, m_nam integer, m_mact varchar2)
as
begin
    execute immediate 'insert into admin_ols1.khmo values(''' || m_mahp || ''',' || m_hk || ',' || m_nam || ',''' || m_mact || ''')';
end;
/