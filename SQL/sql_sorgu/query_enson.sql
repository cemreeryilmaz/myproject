use emre
go
create table bolumler(
	bolum_id int not null,
	bolum_adi varchar(20),
	constraint pk_bolumler primary key(bolum_id), 
);

use emre
go
create table altbolumler(
	altbolum_id int not null,
	altbolum_adi varchar(20),
	bolum_id int,
	constraint pk_altbolumler primary key(altbolum_id),
	constraint fk_bolumler foreign key(bolum_id)
	references bolumler(bolum_id)
);

use emre
go
create table urunler(
	urunkodu int not null,
	urunadi varchar(20),
	markakodu int,
	altbolum_id int,
	aciklama varchar(max),
	fiyati int,
	stokmiktari int,
	constraint pk_urunler primary key(urunkodu),
	constraint fk_altbolumler foreign key(altbolum_id)
	references altbolumler(altbolum_id)
);

use emre
go
create table markalar(
	markakodu int not null,
	marka_adi varchar(20),
	constraint pk_markalar primary key(markakodu) 
);

use emre
go
	alter table urunler add	constraint fk_markalar foreign key(markakodu)
	references markalar(markakodu)
;

use emre
go
create table faturadetay(
	detayno int not null,
	faturano int,
	urunkodu int,
	urunadedi int,
	constraint pk_faturadetay primary key(detayno),
	constraint fk_urunler foreign key(urunkodu)
	references urunler(urunkodu)
);

use emre
go
create table faturalar(
	faturano int not null,
	faturatarihi date,
	musterikod int,
	constraint pk_faturalar primary key(faturano),	
);

use emre
go
	alter table faturadetay add constraint fk_faturalar foreign key(faturano) 
	references faturalar(faturano)
;

use emre
go
create table musteriler(
	musterikod int not null,
	musteriadi varchar(20),
	musteriadresi varchar(15),
	musteritel varchar(15),
	mustericinsiyet varchar(10),
	constraint pk_musteriler primary key(musterikod),	
);

use emre
go
	alter table faturalar add constraint fk_musteriler foreign key (musterikod)
	references musteriler (musterikod)
;

use emre
go
insert into bolumler (bolum_id,bolum_adi) values (1,'bilgisayar');
insert into bolumler (bolum_id,bolum_adi) values (2,'telefon');
insert into bolumler (bolum_id,bolum_adi) values (3,'dig.ses.gor.');

select * from bolumler;

select * from bolumler;

use emre
go
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(1,'masaustu bilg.',1);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(2,'avucici bilg.',1);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(3,'tasinabilir',1);

insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(4,'ev telef.',2);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(5,'cep telef.',2);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(6,'fax',2);

insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(7,'mp3 player',3);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(8,'dig.foto.mak.',3);
insert into altbolumler (altbolum_id,altbolum_adi,bolum_id) values(9,'dvd player',3);

select * from altbolumler;

use emre
go
insert into markalar (markakodu,marka_adi) values (1,'apple');
insert into markalar (markakodu,marka_adi) values (2,'samsung');
insert into markalar (markakodu,marka_adi) values (3,'asus');
insert into markalar (markakodu,marka_adi) values (4,'lenovo');
insert into markalar (markakodu,marka_adi) values (5,'sony');

select * from markalar;

select * from altbolumler;

insert into urunler(urunkodu,urunadi,markakodu,altbolum_id,aciklama,fiyati,stokmiktari)
values (1,'iphone',1,5,'apple',2850,45);
insert into urunler(urunkodu,urunadi,markakodu,altbolum_id,aciklama,fiyati,stokmiktari)
values (2,'galaxy s6',2,5,'samsung',2000,80);

select * from urunler;

use emre
go
select * from musteriler;
insert into musteriler(musterikod,musteriadi,musteriadresi,musteritel,mustericinsiyet)
values (1,'okan altun','sefaköy','212 444-44-44','erkek');
insert into musteriler(musterikod,musteriadi,musteriadresi,musteritel,mustericinsiyet)
values (2,'cemre eryýlmaz','cennet','212 444-44-43','erkek');

use emre
go
select * from musteriler;
insert into faturalar(faturano,faturatarihi,musterikod)
values (100,'12.03.2015',1);
insert into faturalar(faturano,faturatarihi,musterikod)
values (101,'11.03.2015',2);

select * from faturalar;

use emre
go
select * from faturalar;
select * from musteriler;
select * from urunler;

insert into faturadetay(detayno,faturano,urunkodu,urunadedi)
values(100,100,1,2);
insert into faturadetay(detayno,faturano,urunkodu,urunadedi)
values(1001,101,1,3);

select * from faturadetay;