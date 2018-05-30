create database TriggerDb;
if object_id('dbo.satislar','U') is not null drop table dbo.satislar;
if object_id('dbo.urunler','U') is not null drop table dbo.satislar;
if object_id('dbo.urunAdediGuncelle','U') is not null drop table dbo.satislar;

create table urunler
(
	urun_id int not null identity(1,1),
	urun_adi varchar(30),
	urun_adedi int,
	constraint pk_urunler primary key(urun_id)
);

create table satislar
(
	satis_id int not null identity(1,1),
	urun_id int,
	satýs_adedi int,
	constraint pk_satislar primary key (satis_id),
	constraint fk_urunler foreign key (urun_id) 
	references urunler(urun_id)
);

insert into urunler values ('IPhone 6',100);
insert into urunler values ('Samsung Galaxy S6',150);

select * from urunler;
select * from satislar;

create trigger urunAdediGuncelle on satislar
for insert
as
begin
declare @urunid int, @satisadedi int
select @urunid = urun_id, @satisadedi = satýs_adedi 
from inserted
update urunler set urun_adedi = urun_adedi-@satisadedi
end;

select * from urunler where urun_id = 1;
insert into satislar(urun_id,satýs_adedi) values (1,5);
select * from urunler where urun_id= 1;

create	trigger satisIptalEt on satislar
for delete 
as
begin
declare @urunid int, @satisadedi int
select @urunid = urun_id, @satisadedi = satýs_adedi from deleted
update urunler set urun_adedi = urun_adedi + @satisadedi where urun_id = @urunid
end;

select * from urunler where urun_id = 1;
delete from satislar where urun_id = 1 and satýs_adedi = 1;
select * from urunler where urun_id = 1;

create trigger tabloSilmeyiEngelle
on database
for DROP_TABLE, ALTER_TABLE
as
begin
print 'dikkat "tabloSilmeyiEngelle" trigger''ýný devre dýþý býrakmadan 
silme veya güncelleme yapýlmaz!'
Rollback;
end;
drop Table satislar;
disable trigger tabloSilmeyiEngelle on DATABASE;
drop Table satislar;
enable trigger tabloSilmeyiEngelle on DATABASE;

if object_id('kullaniciKisitla') is not null drop trigger kullaniciKisitla on all server
use TriggerDb
go
create trigger kullaniciKisitla
on all Server
for logon
as
begin
if original_login()='testUser' and (DATEPART (HOUR, GETDATE ())<9 OR 
DATEPART (HOUR,GETDATE())>=17)
begin
RAISERROR('Dikkat kullanicinin 09:00''dan önce ve 17:00''dan sonra login 
olmasi yasaktir',16,1);
rollback;
end
end;
