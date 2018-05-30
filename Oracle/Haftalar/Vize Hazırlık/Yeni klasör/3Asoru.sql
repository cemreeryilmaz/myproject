
insert into ebru.meslekler values (1,'BT_BÝL_MUH',3000,8000);
insert into ebru.meslekler values (2,'MUH_YON',2000,5000);
insert into ebru.meslekler values (3,'IK_YONYAR',2000,4500);
commit;
SELECT * FROM ebru.meslekler;



insert into ebru.lokasyonlar values(10,34330,'X MAH. Y SOK NO:12/3','ISTANBUL');
insert into ebru.lokasyonlar values(20,06680,'A MAH. B SOK NO:165','ANKARA');
insert into ebru.lokasyonlar values(30,35055,'D MAH. K SOK NO:456','IZMIR');
commit;
SELECT * FROM ebru.lokasyonlar;


insert into ebru.bolumler values(100,'BT',10);
insert into ebru.bolumler values(200,'MUH',20);
insert into ebru.bolumler values(300,'IK',30);
commit;
SELECT * FROM ebru.bolumler;

insert into ebru.calisanlar
values (1000, 'AHMET','KINALI',3450,TO_DATE('01.01.2010','DD.MM.YYYY'),1,100);
insert into ebru.calisanlar
values (2000, 'SEVDA','SU',2400,TO_DATE('07.12.1998','DD.MM.YYYY'),2,200);
insert into ebru.calisanlar
values (3000, 'HASAN','YARDIMCI',4500,TO_DATE('25.11.2013','DD.MM.YYYY'),3,300);
commit;
SELECT * FROM ebru.calisanlar;









