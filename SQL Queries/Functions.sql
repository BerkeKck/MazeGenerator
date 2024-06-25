-- CREATE FUNCTION dbo.ufnGetInventoryStock(@ProductID int)
-- RETURNS int
-- AS
-- -- Returns the stock level for the product.
-- BEGIN
--     DECLARE @ret int
--     SELECT @ret = SUM(p.Quantity)
--     FROM Production.ProductInventory p
--     WHERE p.ProductID = @ProductID
--         AND p.LocationID = '6'
--      IF (@ret IS NULL)
--         SET @ret = 0;
--     RETURN @ret;
-- END;

create function dbo.UrunSatisAdetleri(@productID int)
RETURNS int 
as 
BEGIN
  declare @Adet int,@return int;
  set @return =0
  select @adet=sum(quantity) from [Order Details]
  where ProductID=@productID 
  if(@Adet is not NULL)
     set  @return = @Adet   

 return @return     
End

select dbo.UrunSatisAdetleri(1)

Select ProductID,ProductName,dbo.UrunSatisAdetleri(ProductID) SatisAdedi 
from Products
Order by ProductID desc 