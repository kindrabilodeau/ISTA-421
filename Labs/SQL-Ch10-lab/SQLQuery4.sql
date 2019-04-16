-- Connection 2
USE TSQLV4;
SELECT productid, unitprice
FROM Production.Products
WHERE productid = 2;

-- Connection 2
-- Stop, then set the LOCK_TIMEOUT, then retry
SET LOCK_TIMEOUT 5000;

SELECT productid, unitprice
FROM Production.Products
WHERE productid = 2;

-- Connection 2
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

SELECT productid, unitprice
FROM Production.Products
WHERE productid = 2;

-- The READ COMMITTED Isolation Level
-- Connection 2
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

SELECT productid, unitprice
FROM Production.Products
WHERE productid = 2;

-- The REPEATABLE READ Isolation Level
-- Connection 2
UPDATE Production.Products
  SET unitprice += 1.00
WHERE productid = 2;

---------------------------------------------------------------------
-- The SERIALIZABLE Isolation Level
-- Connection 2
INSERT INTO Production.Products
    (productname, supplierid, categoryid,
     unitprice, discontinued)
  VALUES('Product ABCDE', 1, 1, 20.00, 0);

  -- Simple Deadlock Example
  BEGIN TRAN;

  UPDATE Sales.OrderDetails
    SET unitprice += 1.00
  WHERE productid = 2;
  
  SELECT productid, unitprice
  FROM Production.Products
  WHERE productid = 2;

COMMIT TRAN;