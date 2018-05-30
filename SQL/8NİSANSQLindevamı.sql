create database rafael
go
use rafael 
go
create table notlar
(
ogrenci_no int,
ders_adi varchar(30),
ogr_not int

);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (1,'Matematik',80);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (1,'F�Z�K',70);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (1,'K�MYA',55);

insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (2,'Matematik',45);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (2,'F�Z�K',60);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (2,'K�MYA',83);

insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (3,'Matematik',90);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (3,'F�Z�K',60);
insert into notlar([ogrenci_no],[ders_adi],[ogr_not])
values (3,'K�MYA',89);
select * from notlar

select max(ogr_not) from notlar;
select min(ogr_not) from notlar;
select avg(ogr_not) from notlar;

select ders_adi, avg(ogr_not) as ORTALAMA from notlar
group by ders_adi;

select ders_adi , min(ogr_not) as EN_D���K_NOT from notlar
group by ders_adi;

select ders_adi , max(ogr_not) as EN_Y�SEK_NOT from notlar
group by ders_adi;

//*yukar�dakilerin tek c�mle ile  yaz�m�*//
select ders_adi , avg(ogr_not)as ORTALAMA ,	min(ogr_not)as EN_D���K,
max(ogr_not) as EN_Y�KSEK from notlar
group by ders_adi;


create table brans(
brans_id  int not null,
brans_adi varchar(30),
constraint pk_brans primary key(brans_id));

create table doktor(
doktor_id int not null,
doktor_adi varchar(30),
doktor_soyadi varchar(30),
brans_id int,

constraint pk_doktor primary key(doktor_id),
constraint fk_brans foreign key (brans_id)
references brans(brans_id),

);

insert into brans([brans_id],[brans_adi]) values(1,'Dahiliye');
insert into brans([brans_id],[brans_adi]) values(2,'Kardiyoloji');
insert into brans([brans_id],[brans_adi]) values(3,'G�z');
insert into brans([brans_id],[brans_adi]) values(4,'KBB');

select * from brans;

insert into doktor([doktor_id],[doktor_adi],[doktor_soyadi],[brans_id])
values(1,'Hakan','G�m��',4);
insert into doktor([doktor_id],[doktor_adi],[doktor_soyadi],[brans_id])
values(2,'Aylin','Sak�c�',3);
insert into doktor([doktor_id],[doktor_adi],[doktor_soyadi],[brans_id])
values(3,'Murat','Han',2);
insert into doktor([doktor_id],[doktor_adi],[doktor_soyadi],[brans_id])
values(4,'Salih','Can',2);
insert into doktor([doktor_id],[doktor_adi],[doktor_soyadi],[brans_id])
values(5,'Se�il','Kara',Null);

select * from doktor

/*�NNER JO�N  se�ili olanlar� getiriyor */
select d.doktor_adi,d.doktor_soyadi,b.brans_adi
from doktor as d inner join brans as b on(d.brans_id=b.brans_id);

/*FULL OUTER JO�N hepsini getiriyor*/
select d.doktor_adi,d.doktor_soyadi,b.brans_adi
from doktor as d full outer  join brans as b on(d.brans_id=b.brans_id);
/*R�GHT OUTER JO�N hepsini getiriyor*/
select d.doktor_adi,d.doktor_soyadi,b.brans_adi
from doktor as d right outer  join brans as b on(d.brans_id=b.brans_id);
/*LEFT OUTER JO�N hepsini getiriyor*/
select d.doktor_adi,d.doktor_soyadi,b.brans_adi
from doktor as d left outer  join brans as b on(d.brans_id=b.brans_id);
 

 /*cross join veri tutarl��� olmuyor cross s�navda olmayacak*/ 
 select d.doktor_adi,d.doktor_soyadi,b.brans_adi
from doktor as d 
cross join brans as b

/* i� i�e sorgular */ 
select d.doktor_adi, d.doktor_soyadi from doktor d
where d.brans_id=(select brans_id from brans where brans_adi='G�z');


