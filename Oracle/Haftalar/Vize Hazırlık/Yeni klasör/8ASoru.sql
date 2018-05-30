select C.calisan_adi,C.calisan_soyadi, M.meslek_adi
from ebru.meslekler M inner join ebru.calisanlar C
on(M.meslek_id = C.meslek_id)
where C.maas<2500 and (sysdate-ise_giris_tarihi)/365>2;