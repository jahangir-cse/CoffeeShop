CREATE DATABASE CoffeShop
USE CoffeShop

CREATE TABLE Items(
Id INT IDENTITY(1,1),
Name varchar(30),
Price float
)

drop table Items

select * from Items

INSERT INTO Items(Name,Price) values ('Cold',100)
INSERT INTO Items(Name,Price) values ('Hot',50)
INSERT INTO Items values ('Black',200)

delete from Items
where Id=4

update Items
set
Name='Black',Price=120
where Id=6
