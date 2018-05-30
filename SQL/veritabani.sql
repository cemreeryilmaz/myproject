create database ornek

create table marka(
marka_id int not null,
marka_adi varchar(30),
constraint pk_marka primary key(marka_id)
);

create table model(
model_id int not null,
model_adi varchar(30),
marka_id int,
constraint pk_model primary key (model_id),
constraint fk_marka foreign key(marka_id) references marka(marka_id)
);

insert into marka(marka_id,marka_adi)
values(1,'Opel');
insert into marka(marka_id,marka_adi)
values(2,'Hyundai');
insert into marka(marka_id,marka_adi)
values(3,'Toyota');
insert into marka(marka_id,marka_adi)
values(4,'Reneult');
insert into marka(marka_id,marka_adi)
values(5,'BMW');

select * from  marka;

insert into model(model_id,model_adi,marka_id)
values(100,'Vectre',1);

insert into model(model_id,model_adi,marka_id)
values(101,'120',2);

insert into model(model_id,model_adi,marka_id)
values(102,'Yaris',3);

insert into model(model_id,model_adi,marka_id)
values(103,'Clio',4);

insert into model(model_id,model_adi,marka_id)
values(104,'Focus',Null);

select * from model;



select  o.model_adi,m.marka_adi
from marka m inner join model o on m.marka_id=o.marka_id;

select  o.model_adi,m.marka_adi
from marka m full outer join model o on m.marka_id=o.marka_id;

select  o.model_adi,m.marka_adi
from marka m left join model o on m.marka_id=o.marka_id;

select  o.model_adi,m.marka_adi
from marka m right join  model o on m.marka_id=o.marka_id;


