create user ebru identified by ASDF1234 default tablespace users;
alter user ebru quota 20m on users;

CREATE TABLE EBRU.BOLUMLER
(
  BOLUM_ID number(4),
  BOLUM_ADI varchar2(30)
);
create table EBRU.CALISANLAR
(
  CALISAN_ID number(3),
  CALISAN_ADI varchar2(20),
  BOLUM_ID NUMBER(4)
);

INSERT INTO EBRU.BOLUMLER VALUES(1,'YONETIM');
INSERT INTO EBRU.BOLUMLER VALUES(2,'MUHASEBE');
INSERT INTO EBRU.BOLUMLER VALUES(3,'IK');
INSERT INTO EBRU.BOLUMLER VALUES(4,'SATIS PAZARLAMA');
COMMIT;

SELECT * FROM EBRU.BOLUMLER;


INSERT INTO EBRU.CALISANLAR VALUES (100,'AHMET',1);
INSERT INTO EBRU.CALISANLAR VALUES (101,'MEHMET',2);
INSERT INTO EBRU.CALISANLAR VALUES (102,'FATMA',3);
INSERT INTO EBRU.CALISANLAR VALUES (103,'ALI',2);
INSERT INTO EBRU.CALISANLAR VALUES (104,'AYSE',3);
INSERT INTO EBRU.CALISANLAR VALUES (105,'FARUK',NULL);
COMMIT;

SELECT * FROM EBRU.CALISANLAR;

SELECT
CAL.CALISAN_ADI,
BOL.BOLUM_ADI
FROM EBRU.CALISANLAR CAL INNER JOIN EBRU.BOLUMLER BOL
ON(CAL.BOLUM_ID=BOL.BOLUM_ID);

SELECT
CAL.CALISAN_ADI,
BOL.BOLUM_ADI
FROM EBRU.CALISANLAR CAL LEFT OUTER JOIN EBRU.BOLUMLER BOL
ON(CAL.BOLUM_ID=BOL.BOLUM_ID);

SELECT
CAL.CALISAN_ADI,
BOL.BOLUM_ADI
FROM EBRU.CALISANLAR CAL RIGHT OUTER JOIN EBRU.BOLUMLER BOL
ON(CAL.BOLUM_ID=BOL.BOLUM_ID);


SELECT
CAL.CALISAN_ADI,
BOL.BOLUM_ADI
FROM EBRU.CALISANLAR CAL FULL OUTER JOIN EBRU.BOLUMLER BOL
ON(CAL.BOLUM_ID=BOL.BOLUM_ID);

SELECT
CAL.CALISAN_ADI,
BOL.BOLUM_ADI
FROM EBRU.CALISANLAR CAL,EBRU.BOLUMLER BOL;



