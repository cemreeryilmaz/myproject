select * from ebru.calisanlar C left outer join ebru.bolumler B
on (C.bolum_id = B.bolum_id)
where B.bolum_adi in('BT','SATIS','MUHASEBE');