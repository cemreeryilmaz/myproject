select * from ebru.bolumler B right outer join ebru.lokasyonlar L
on (B.lokasyon_id= L.lokasyon_id)
where L.sehir in('ANKARA','MERSÝN');