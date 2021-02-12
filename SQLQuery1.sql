Select Products.ProductName [Ürün Adı],
Sum([Order Details].Quantity * [Order Details].UnitPrice) [Kazanılan Toplam Miktar]
from Products inner join [Order Details]
On Products.ProductID = [Order Details].ProductID inner join Orders 
On [Order Details].OrderID = Orders.OrderID
group by Products.ProductName
Order by Sum([Order Details].Quantity * [Order Details].UnitPrice) desc