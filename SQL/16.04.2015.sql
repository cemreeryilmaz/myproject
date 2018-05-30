create database ornek1
select getdate();
select sysdatetime();
select sysutcdatetime();

select day (getdate());
select day ('2014-02-23');

select month (getdate());
select month ('2014-02-23');

select year (getdate());
select month ('2014-02-23');

select DATEDIFF(yyyy,'2001-03-27', getdate());
select DATEDIFF(mm,'2001-03-27', getdate());
select DATEDIFF(dd,'2001-03-27', getdate());

select convert (varchar(19), getdate());

declare @isim varchar(30);
set @isim='Ayhan';
select @isim as ISIM;

declare @ad varchar(30);
declare @soyad varchar(30);
set @ad = 'Hakan';
set @soyad = 'Karabacak';
select CHARINDEX('ba',@soyad) as soyad_INDEX;
select LEFT (@ad,2) as SOLDAN;
select RIGHT (@ad,2) as SAÐDAN;
select LEN (@soyad) as UZUNLUK;
select LOWER(@ad) as AD, UPPER(@soyad) as SOYAD;
select REVERSE(@ad) as TERSTEN_ISIM;
select SUBSTRING(@ad,2,4) as SUBSTRING_ORNEK;



create table notlar(
adý varchar(30),
notu int
);
insert into notlar values ('Cansu',78);
insert into notlar values ('Ezgi',60);
insert into notlar values ('Aylin',85);
insert into notlar values ('Buse',80);

declare @ortalama int;
select ortalama = AVG(notu) from notlar;
if(@ortalama>=70)
begin
print 'ORTALAMA 70 TEN YÜKSEK';
end
else
begin
print 'ORTALAMA 70 TEN DÜÞÜK';
end
