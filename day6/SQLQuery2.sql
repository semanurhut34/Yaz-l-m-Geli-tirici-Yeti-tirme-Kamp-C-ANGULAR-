--Select
--ANSI Standartı
--select ContactName As Adi,City As Sehir from Customers;
--select * from Customers where City ='London';

--case insensitive (Büyük küçük harf duyarsız)
--select * from Products where categoryId=1 and UnitPrice<=10;

--asc, ascending
select * from Products order By ProductName asc;

select count(*) from Products;

select categoryID, count(*) from Products group by categoryId --Her üründen kaç tane olduğunu da gösteriyor.

select categoryID, count(*) from Products where UnitPrice>20
group by categoryId having count(*)<10

select * from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO-DATA Transformation Object (c# ile bağlantı)
--inner join,sadece eşleşen kayıtları getirir.

--left join,solda olup sağda olmayanları da getir.
select * from Products p left join [Order Details] od on p.ProductID =od.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID where o.CustomerID is null