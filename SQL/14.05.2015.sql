---query1function------------------------------------------------------
create database emre;
use emre;

create table calisan
(
	calisan_id int not null identity(1,1),
	calisan_adi varchar (30),
	ise_baslama_tarihi date,
	isten_ayrilma_tarihi date,
	constraint pk_calisan primary key (calisan_id)
);

insert into calisan values 
('Ahmet Ercan',CONVERT(date,'21-04-2012',105),null);

insert into calisan values 
('Seda Unlu',CONVERT(date,'18-03-1998',105),CONVERT(date,'30-07-2010',105));

insert into calisan values 
('Figen Güçlü',CONVERT(date,'11-11-2013',105),null);

insert into calisan values 
('Sedat Kara',CONVERT(date,'15-12-2009',105),CONVERT(date,'30-07-2010',105));

create function dbo.calisama_yilini_bul(@calisan_id int)
returns int
begin
declare @calisma_yili int;
select @calisma_yili = YEAR(ISNULL(isten_ayrilma_tarihi,Getdate()))-
---calisan isten ayrilma tarihi calisma yolunu bulan sql cümleciðini yazýnýz.
YEAR(ise_baslama_tarihi) from calisan where calisan_id = @calisan_id;
return @calisma_yili;
end;

select calisan_adi,ise_baslama_tarihi,dbo.calisma_yilini_bul(calisan_id)
as	CALISMA_YILI from calisan;

---query2join---------------------------------------------------------------------

use emre
go

create table musteri
(
	musteri_id int not null identity(1,1),
	musteri_adi varchar(30),
	musteri_soyadi varchar(20),
	constraint pk_musteri primary key (musteri_id)
);

create table urun
(
	urun_id int not null identity(100,10),
	urun_adi varchar(30),
	urun_fiyati money,
	constraint pk_urun primary key (urun_id)
);

create table musteri_detay
(
	musteri_id int,
	urun_id int,
	urun_adedi int,
	constraint fk_musteri foreign key(musteri_id)
	references musteri(musteri_id),
	constraint fk_urun foreign key(urun_id)
	references urun(urun_id)
);

insert into urun values('Televizyon',2500);
insert into urun values('Buzdolabý',2200);
insert into urun values('Çamaþýr Mak.',2450);

insert into Musteri values('Ahmet','Ercan');
insert into Musteri values('Semih','Kaya');
insert into Musteri values('Tülay','Güneþ');

select * from urun;

insert into musteri_detay values(1,120,2);
insert into musteri_detay values(2,110,1);
insert into musteri_detay values(3,100,4);

select m.musteri_adi,m.musteri_soyadi,u.urun_adi,u.urun_fiyati,md.urun_adedi
from musteri m inner join musteri_detay md on m.musteri_id = md.musteri_id
inner join urun u on md.urun_id = u.urun_id;

---query3view--------------------------------------------------------------------

use emre
go

create table pozisyon
(
	pozisyon_id int not null,
	pozisyon_adi varchar(30),
	constraint pk_pozisyon primary key (pozisyon_id)
);

insert into pozisyon values(1,'Genel Müdür');
insert into pozisyon values(2,'Genel Müdür Yardýmcýsý');
insert into pozisyon values(3,'Direktör');
insert into pozisyon values(4,'Müdür');
insert into pozisyon values(5,'Yönetici');
insert into pozisyon values(6,'Uzman');

create table calisanlar
(
	calisan_id int not null identity(100,1),
	calisan_adi varchar(30),
	maas money,
	pozisyon_id int,
	constraint fk_pozisyon foreign key(pozisyon_id)
	references pozisyon(pozisyon_id)
);

insert into calisanlar values('Buse Gül',4200,5);
insert into calisanlar values('Hakan Baþgil',25700,,1);
insert into calisanlar values('Tomris Uar',17500,2);
insert into calisanlar values('Fatma Subaþý',2800,6);
insert into calisanlar values('Fazlý Tüzen',12000,3);
insert into calisanlar values('Cemile Cemþit',10000,5);

create view dbo.vcalisan_bilgileri
as
select c.calisan_adi, c.maas, p.pozisyon_adi
from calisan c inner join pozisyon p on c.pozisyon_id = p.pozisyon_id
where p.pozisyon_adi not in ('Genel Müdür','Genel Müdür Yardýmcýsý');

select * from vcalisan_bilgileri;

create procedure dbo.zam_yap
as
begin
update calisanlar set maas = maas*1.1 where pozisyon_id in (4,5,6);
update calisanlar set maas = maas*1.5 where pozisyon_id in (1,2,3);
end;

select * from calisanlar;
exec dbo.zam_yap;
select * from calisanlar;

---query4trigger---------------------------------------------------------

create table calisan
(
	calisan_id int identity(1,1) not null,
	calisan_adi varchar(30),
	ise_baslama_tarihi date,
	isten_ayrilma_tarihi date,
	constraint pk_calisan primary key(calisan_id)
);

create trigger rg_insert_calisan on calisan1
for insert
as
begin
declare @giris_tarihi date;
declare @ayrilma_tarihi date;
select @giris_tarihi = ise_baslama_tarihi, @ayrilma_tarihi = isten_ayirilma_tarihi
from inserted;
if @ayrilma_tarihi < @giris_tarihi
begin
print 'Ýþten ayrilma tarihi iþe giriþ tarihinden küçük olamaz!';
rollback;
end; 
else
begin
commit;
end;
end;

insert into calisan1 values('Ahmet Bayhan',CONVERT(date,'17-04-1990',105),
CONVERT(date,'16-04-1990',105));