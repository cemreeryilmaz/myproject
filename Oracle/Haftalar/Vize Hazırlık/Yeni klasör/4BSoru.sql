delete from ebru.calisanlar
where ise_giris_tarihi<TO_DATE('01.01.1998', 'DD.MM.YYYY');
commit;