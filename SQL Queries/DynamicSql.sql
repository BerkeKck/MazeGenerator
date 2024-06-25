
DECLARE @sql nvarchar(max) -- String degisken tanimlama
Set @sql=' Select *  from Products' -- Deger atama
--exec @sql --Bu sekilde calismiyor
exec sp_executesql @sql  -- Calistirma
--Yada 
Exec (@sql)
-- Verilen tablodaki kayit sayisini veren procedure 

-- create procedure KayitSayisi (@tablo as varchar(max))
-- as 
-- BEGIN
-- Declare @sql as nvarchar(max)
-- set @sql = 'Select count(*) from ' + @tablo
-- exec sp_executesql @sql 
-- End

-- exec KayitSayisi 'Customers'

create Table ''