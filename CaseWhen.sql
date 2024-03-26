select FirstName,LastName,
   case(country)
    when  'USA' then 'Amerika'
    When 'UK' then 'Ingiltere'
    Else 'Belirsiz Ulke'
   End Ulke
from Employees
-- Unite price 50 ten kucuk olanlar Ucuz urun,50-150 arasinda olanlar Ekonomik
-- 150 ve uzerinde olanlar icin ise pahali ibaresini ekleyelim
Select ProductName, 
    case 
        When UnitPrice<50 then 'Ucuz Urun'
        when UnitPrice>=50 and UnitPrice<150 then 'Ekonomik Urun'
        else 'Pahali Urun'
    End UrunTipi
from Products 

Select p.ProductName,
    case 
        When p.UnitPrice<50 then sum(od.Quantity) 
        when (p.UnitPrice>=50 and p.UnitPrice<150) then sum(od.Quantity) 
        else sum(od.Quantity)
    End UrunTipi
from Products p
inner join [Order Details] od on od.ProductID =p.ProductID
group by p.ProductName,p.UnitPrice
