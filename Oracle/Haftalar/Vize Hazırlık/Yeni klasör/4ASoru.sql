update ebru.meslekler set en_yuksek_maas=6750
where meslek_adi='BT_BÝL_MUH';
commit;
select * from ebru.meslekler;