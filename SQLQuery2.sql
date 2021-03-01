--Select
--ANSI
--Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

--Select * from Customers where City= 'Berlin'

--Select * from Products where categoryId = 1 or CategoryID = 3

--Select * from Products where categoryId = 1 and UnitPrice >=10

--Select * from Products where CategoryID=1 order by UnitPrice desc  --ascending - descending

--select count(*)Adet from Products where CategoryID = 2

--select CategoryID,count(*)Sayi from Products where UnitPrice>20 group by CategoryID having count(*)<10

--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
--from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object

--Select * from Products left join [Order Details] on Products.ProductID = [Order Details].ProductID

Select * from Customers left join Orders on Customers.CustomerID = Orders.CustomerID order by OrderID





