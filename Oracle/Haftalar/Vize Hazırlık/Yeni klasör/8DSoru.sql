select C.calisan_adi, C.calisan_soyadi, C.maas,M.meslek_adi, B.bolum_adi,L.sehir
from ebru.calisanlar C, ebru.meslekler M, ebru.bolumler B, ebru.lokasyonlar L
where M.meslek_id = C.meslek_id
and C.bolum_id = B.bolum_id
and B.lokasyon_id = L.lokasyon_id;