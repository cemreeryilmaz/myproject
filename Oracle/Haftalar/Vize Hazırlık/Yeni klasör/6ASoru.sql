select * from ebru.cal�sanlar
where maas>4000 and (sysdate-ise_giris_tarihi)/365>10
order by maas desc;