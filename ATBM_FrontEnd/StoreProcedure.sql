create or replace procedure xem_ke_hoach_mo (c1 out SYS_REFCURSOR)
as
begin
    open c1 for
    select k.mahp, h.tenhp, k.nam, k.mact 
    from khmo k join hocphan h
    on k.mahp = h.mahp;
    DBMS_SQL.RETURN_RESULT(c1);
end;
/