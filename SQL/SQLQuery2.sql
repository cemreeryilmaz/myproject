create database ebru
use ebru
go
create table ogrenciler
(
ogrenci_id int not null,
ogr_adi varchar(30),
ogr_soyadi varchar(30)
);

insert into ogrenciler values(1,'ahmet','ercan');
insert into ogrenciler values(2,'ay�e','k�se');
insert into ogrenciler values(3,'hakan','savc�');

create table ogrenci_not(
ogr_id int not null,
sinav_adi varchar(15),
sinav_not int
);
insert into ogrenci_not values(1,'S�nav 1',56);
insert into ogrenci_not values(1,'S�nav 2',67);
insert into ogrenci_not values(1,'S�nav 3',89);
insert into ogrenci_not values(1,'S�nav 4',87);

insert into ogrenci_not values(2,'S�nav 1',45);
insert into ogrenci_not values(2,'S�nav 2',71);
insert into ogrenci_not values(2,'S�nav 3',34);
insert into ogrenci_not values(2,'S�nav 4',66);

insert into ogrenci_not values(3,'S�nav 1',11);
insert into ogrenci_not values(3,'S�nav 2',87);
insert into ogrenci_not values(3,'S�nav 3',55);
insert into ogrenci_not values(3,'S�nav 4',71);


create function ortalama_bul(@ogrenci_id int)
returns int
as
begin
declare @sinav_ortalama int;
select @sinav_ortalama=AVG(sinav_not) from ogrenci_not
where ogr_id=@ogrenci_id;
return @sinav_ortalama;
end
go

select ogr_adi,ogr_soyadi, dbo.ortalama_bul(ogrenci_id) 
as ORTALAMA_NOT from ogrenciler;

create table urunler
(
urun_id int not null identity(1,1),
urun_adi varchar(30),
alis_fiyati money,
vergi decimal(4,2)
);

insert into urunler values('Samsung Galaxy Note 3', 1250, 0.18);
insert into urunler values('IPhone 5s', 1800, 0.18);
insert into urunler values('Nexus 6', 1500, 0.08);
insert into urunler values('HTC One', 1900, 0.18);

select * from urunler;

create function fiyati_bul(@urun_id int)
returns money
as
begin 
declare @satis_fiyati money
select @satis_fiyati = alis_fiyati + (alis_fiyati * vergi)
from urunler where urun_id=@urun_id;
return @satis_fiyati
end
go

select urun_id,urun_adi,alis_fiyati, dbo.fiyati_bul(urun_id)
as SATI�_FIYATI from urunler;

create function topla(@sayi1 int, @sayi2 int)
returns int
as
begin
declare @sonuc int
set @sonuc = @sayi1 + @sayi2;
return @sonuc
end;
select dbo.topla(13,15)