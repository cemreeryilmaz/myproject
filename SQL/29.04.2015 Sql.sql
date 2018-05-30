Create database ebru

create table kisiler
(
kisi_id int,
kisi_adi varchar(30),
kisi_not int
);
insert into kisiler values (1,'ahmet',80);
insert into kisiler values(2,'ayse', 50);
insert into kisiler values (3,'selim',75);
insert into kisiler values(4,'fatma', 40);

create procedure UGecenler
As
select * from kisiler where kisi_not>55;
go
exec UGecenler;

create procedure UOrtalama
As
DECLARE @ort int
select @ort = AVG(kisi_not) from kisiler;
select * from kisiler where kisi_not>@ort;
go
exec UOrtalama;

create procedure UKisiGetir
@kullanici_id int
as
select * from kisiler where kisi_id =@kullanici_id;
go
exec UKisiGetir 1;

--------------------------------------
create table calisan
(
calisan_id int not null identity(1,1),
adi varchar(20),
soyadi varchar(20),
telefon varchar(20),
maas int
);
insert into calisan values('Ahmet','Ercan',2125554466,1200);
insert into calisan values('Mehmet','Yakut',2125554467,3200);
insert into calisan values('Hakan','Kutan',2125554456,4200);
insert into calisan values('Ezgi','Birben',2125519466,5400);
insert into calisan values('Ayse','Develi',2125394466,2000);
insert into calisan values('Fatma','Gurkan',2125512466,2500);

select *  from calisan;

create view vcalisan_ozet
as
select calisan_id, adi, soyadi from calisan;
select * from vcalisan_ozet;

create view vcalisan_ozet2
as
select adi, soyadi, maas from calisan
where adi like 'a%'
with check option;
insert into vcalisan_ozet values('Mahmut','Gunduz');
select * from vcalisan_ozet2;

insert into vcalisan_ozet values ('salim','G�len',2000);
insert into vcalisan_ozet2 values('ahmet','G�len',3000);

-- SCHEMAB�ND�NG ifadesi ile V�EW'in ba�l� oldu�u tablodaki kolonlar�
-- kitleyip kolonlar�n silinmesini ve de�i�iklik yap�lmas�n� engeller

create view vcalisan_ozet3
with SCHEMABINDING
AS
SELECT adi, soyadi, telefon from dbo.calisan;
select * from vcalisan_ozet3;

drop table dbo.calisan;

-- ENCRYPT�ON V�EW leri �ifreleyip sorgular�n g�r�n�r olmas�n�
-- engeller. Kaynaklar�n gizlili�ini sa�layan koddur.
-- Kullan�c� sadece olu�turulan view ile ilgili verilere eri�ebilir kaynak
-- tablolarla ilgili veriye eri�emez.

create view vcalisan_ozet4
with encryption
as
select adi, soyadi from calisan;
select *  from vcalisan_ozet4;