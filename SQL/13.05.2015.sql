create database emre;
use emre;

create table ogrenci
(
	ogrenci_id int not null identity(1,1),
	ogrenci_adi varchar(30),
	dogum_tarihi date,
	constraint pk_ogrenci primary key(ogrenci_id)
);

insert into ogrenci values('Ahmet Ercan',convert(date,'17-04-1990',105));
insert into ogrenci values('Seda Ünlü',convert(date,'28-02-1988',105));
insert into ogrenci values('Figen Güllü',convert(date,'11-11-1989',105));
insert into ogrenci values('Sedat Kara',convert(date,'15-12-1978',105));

create function dbo.yasi_bul(@dogum_tarihi date)
returns int
as
begin
declare @yas int
select @yas = (year (getdate()) - year (@dogum_tarihi));
return @yas
end;

select ogrenci_adi,dogum_tarihi,dbo.yasi_bul(dogum_tarihi) as YAS from ogrenci;

--*******************************************--

use emre;

create table sonuclar
(
	hafta int,
	takim_evsahibi varchar(30),
	takim_deplasman varchar(30),
	skor_evsahibi int,
	skor_deplasman int
);

create table puan_durumu
(
	takim_adi varchar(30),
	puan int
);

insert into sonuclar values(31,'Torku Konya','Genclerbirliği',1,0);
insert into sonuclar values(31,'İstanbul Büyükşehir','Sivasspor',1,2);
insert into sonuclar values(31,'Kasımpaşa','Balıkesirspor',2,3);
insert into sonuclar values(31,'Karabükspor','Eskişehirspor',2,2);

insert into puan_durumu values('Torku Konya',38);
insert into puan_durumu values('Genclerbirliği',40);
insert into puan_durumu values('İstanbul Büyükşehir',51);
insert into puan_durumu values('Sivasspor',34);
insert into puan_durumu values('Kasımpaşa',35);
insert into puan_durumu values('Balıkesirspor',23);
insert into puan_durumu values('Karabükspor',24);
insert into puan_durumu values('Eskişehirspor',35);

create procedure dbo.puan_hesaplama @oynanan_hafta int
as
declare @evsahibi varchar(30), @deplasman varchar(30), @evsahibi_skor int, @deplasman_skor int
declare crs_takimlar cursor for
select takim_evsahibi, takim_deplasman, skor_evsahibi,skor_deplasman from sonuclar
where hafta = @oynanan_hafta;
open crs_takimlar
fetch next from crs_takimlar INTO @evsahibi,@deplasman,@evsahibi_skor,@deplasman_skor
while @@FETCH_STATUS = 0
begin
if @evsahibi_skor-@deplasman_skor > 0
update puan_durumu set puan = puan + 3 where takim_adi = @evsahibi;
else if @evsahibi_skor-@deplasman_skor < 0
update puan_durumu set puan = puan+3 where takim_adi=@deplasman;
else
update puan_durumu set puan = puan + 1 where takim_adi in(@evsahibi,@deplasman);
fetch next from crs_takimlar Into
@evsahibi,@deplasman,@evsahibi_skor,@deplasman_skor
end;
go

select * from puan_durumu order by puan desc;
exec dbo.puan_hesaplama 31;