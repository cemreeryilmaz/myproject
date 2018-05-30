drop table ebru.meslekler cascade constraint;
drop table ebru.calisanlar cascade constraint;
drop table ebru.bolumler cascade constraint;
drop table ebru.lokasyonlar cascade constraint;

create table ebru.meslekler
(
meslek_id number(4),
meslek_adi varchar2(30), 
en_dusuk_maas number(8),
en_yuksek_maas number(8), 
constraint pk_meslekler primary key(meslek_id)
);

create table ebru.lokasyonlar
(
lokasyon_id number(4),
posta_kodu number(5), 
adres varchar2(50), 
sehir varchar2(20), 
constraint pk_lokasyonlar primary key(lokasyon_id)
);

 create table ebru.bolumler
 (
 bolum_id number(4), 
 bolum_adi varchar2(30), 
 lokasyon_id number(4),
 constraint pk_bolumler primary key (bolum_id)
 );
 
 create table ebru.calisanlar
 (
 calisan_id number(4),
 calisan_adi varchar2(30), 
 calisan_soyadi varchar2(30),
 maas number(8),
 ise_giris_tarihi date,
 meslek_id number(4), 
 bolum_id number(4), 
 constraint pk_calisanlar primary key (calisan_id)
 );
 
 alter table ebru.calisanlar add constraint
 fk_meslekler foreign key (meslek_id)
 references ebru.meslekler(meslek_id);
 
 alter table ebru.calisanlar add constraint
 fk_bolumler foreign key(bolum_id)
 references ebru.bolumler(bolum_id);
 
 alter table ebru.bolumler add constraint
 fk_lokasyonlar foreign key(lokasyon_id)
 references ebru.lokasyonlar(lokasyon_id);
 
 
 
 
 
 
 
 
 
 



