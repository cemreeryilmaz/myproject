create database ornek

create table ogrenci(
ogrenci_id int not null identity(1,1),
ogrenci_adi varchar(20),
ogrenci_soyadi varchar(20),
ogrenci_not int,
constraint pk_ogrenci primary key(ogrenci_id)
);

insert into ogrenci values ('ahmet','ercan',70);
insert into ogrenci values ('hakan','ozturk',50);
insert into ogrenci values ('selin','çiftçi',90);
insert into ogrenci values ('müge','yaman',30);

create function dbo.not_harfini_bul(@ogrenci_not int)
returns varchar
as
begin
declare @not_harfi varchar;
if @ogrenci_not>80
set @not_harfi ='A';
else if @ogrenci_not>70
set @not_harfi ='B';
else if @ogrenci_not>60
set @not_harfi ='C';
else if @ogrenci_not>50
set @not_harfi ='D';
else if @ogrenci_not>40
set @not_harfi ='F';
return @not_harfi;
end;

select ogrenci_adi, ogrenci_soyadi, ogrenci_not, dbo.not_harfini_bul(ogrenci_not)
as NOT_HARFÝ from ogrenci;

------------------------------------------
------PROSEDURE--------
------------------------------------------
create procedure dbo.ad_birlestirme(@ogrenci_id int)
as
begin
select ogrenci_adi+' '+ogrenci_soyadi from ogrenci where ogrenci_id=@ogrenci_id;
end;
exec dbo.ad_birlestirme 1;

-----------------------------------------
-------VIEW------
-----------------------------------------

create table ogrenci_detay(
ogrenci_id int,
dogum_yeri varchar(30),
constraint fk_ogrenci foreign key (ogrenci_id) references ogrenci(ogrenci_id)
);

insert into ogrenci_detay values (1,'SAMSUN');
insert into ogrenci_detay values (2,'ADANA');
insert into ogrenci_detay values (1,'ÝSTANBUL');
insert into ogrenci_detay values (1,'ÝZMÝR');


----Joinli sorgu
select o1.ogrenci_adi,o1.ogrenci_soyadi,o2.dogum_yeri
from ogrenci o1 inner join ogrenci_detay o2
on(o1.ogrenci_id=o2.ogrenci_id);

----View e dönüþtürülmüþ hali
create view dbo.ogrenci_bilgileri
as
select o1.ogrenci_adi, o1.ogrenci_soyadi, o2.dogum_yeri
from ogrenci o1 inner join ogrenci_detay o2
on(o1.ogrenci_id=o2.ogrenci_id);

select * from ogrenci_bilgileri;


--------Stored Procedure------------
create table yas_bilgileri(
kisi_id int identity(1,1),
yas int 
);

insert into yas_bilgileri values(21);
insert into yas_bilgileri values(50);
insert into yas_bilgileri values(65);
insert into yas_bilgileri values(35);
insert into yas_bilgileri values(25);
insert into yas_bilgileri values(39);
insert into yas_bilgileri values(41);
insert into yas_bilgileri values(55);
insert into yas_bilgileri values(24);
insert into yas_bilgileri values(47);
insert into yas_bilgileri values(29);

select * from yas_bilgileri;

create procedure dbo.yas_dagilimi
as
declare @yas1 int;
declare @yas2 int;
declare @yas3 int;
declare @yas4 int;

select @yas1 = COUNT(*)from yas_bilgileri where yas betweeen 20 and 30;
select @yas2 = COUNT(*)from yas_bilgileri where yas betweeen 30 and 40;
select @yas3 = COUNT(*)from yas_bilgileri where yas betweeen 40 and 50;
select @yas4 = COUNT(*)from yas_bilgileri where yas betweeen 50 and 60;

print '20-30 Yaþ arasý kiþi sayýsý:' +convert(varchar(5),@yas1);
print '30-40 Yaþ arasý kiþi sayýsý:' +convert(varchar(5),@yas2);
print '40-50 Yaþ arasý kiþi sayýsý:' +convert(varchar(5),@yas3);
print '50-60 Yaþ arasý kiþi sayýsý:' +convert(varchar(5),@yas4);
