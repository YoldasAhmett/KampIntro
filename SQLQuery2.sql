--Select
Select ContactName BağlantıAdı,CompanyName ŞirketAdı,City Şehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive = Büyük küçük harf duyarsız
select * from products where CategoryID = 1

Select * from products where CategoryId = 1 or CategoryID = 3

select * from products where CategoryID = 1 and UnitPrice >= 10

select * from Products order by CategoryID

select * from Products order by CategoryID, ProductID 

select * from Products order by CategoryID asc --ascending = artan sırada
--Bu komut 2 üstteki komut ile aynı şey çünkü default olarak sıralamadan dolayı

select * from Products order by CategoryID desc --descending = azalan sırada

select * from Products where SupplierID = 1 order by UnitPrice desc

Select count(*) from Products

Select count(*) Adet from Products where CategoryID = 3

Select count(*) Adet from Products where CategoryID = 3

select CategoryID from Products group by CategoryID

select CategoryID, UnitPrice from Products group by CategoryID, UnitPrice

select count(*) from Products group by CategoryID

select CategoryID, UnitPrice, count(*) from Products group by CategoryID,UnitPrice

select CategoryId, count(*) From Products where UnitPrice > 20 group by CategoryID 

select CategoryId, count(*) Sayısı From Products where UnitPrice > 20
group by CategoryID having count(*) < 5

select * from Products inner join Categories --inner join: İki tabloda da
on Products.CategoryID = Categories.CategoryID --ortak olanları getir.

select Products.ProductID, Products.ProductName,
Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName,
Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID

select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID inner join Orders o 
on o.OrderID = od.OrderID -- Üç tabloyu inner join ettik.


select * from Products p left join [Order Details] od --left join:inner join +  
on p.ProductID = od.ProductID --solda olup sağda olmayanları da getir.

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Customers c right join Orders o --right joinde inner join + 
on c.CustomerID = o.CustomerID              --solda olup sağda olmayanları da getir.
where o.CustomerID is null
