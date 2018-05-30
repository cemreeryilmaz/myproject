/*7A*/
select round(95.836,2) from dual;
/*7B*/
select trunc(95.836,2) from dual;
/*7C*/
select sysdate from dual;
select to_char(sysdate,'DD/MM/YYYY HH24:MI:SS') from dual;
/*7D*/
select calisan_adi, round(months_between(sysdate,ise_giris_tarihi),2)
from ebru.calisanlar;
