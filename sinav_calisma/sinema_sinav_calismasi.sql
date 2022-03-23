CREATE DATABASE sinema
USE sinema
CREATE TABLE tbl_kullanicilar
(
id int primary key identity,
kullanici_adi varchar(100),
sifre varchar(100)
)
CREATE TABLE tbl_koltuk_secimi
(
id int primary key identity,
film_adi varchar(50),
koltuk_no varchar(50)
)
