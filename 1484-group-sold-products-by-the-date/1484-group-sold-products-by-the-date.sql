/* Write your T-SQL query statement below */ 
-- select 
--     sell_date, COUNT(DISTINCT product) num_sold,
--     substring(
--         (
--             select ','+  act1.product as [text()] 
--             from (SELECT DISTINCT * FROM Activities) act1
--             where act1.sell_date=act2.sell_date
--             order by act1.product
--             for xml path('')
--         ),2,1000
--     ) as products
-- from Activities act2
-- group by sell_date
-- order by sell_date ; 
---- other solution  
Select
     sell_date,
      COUNT(DISTINCT product) num_sold, 
    STUFF((
          SELECT  ','+act1.product
          from (SELECT DISTINCT * FROM Activities) act1
          where act1.sell_date=act2.sell_date
        order by act1.product
          for xml path('')), 1, 1, '') as products 
from Activities act2
group by sell_date
 order by sell_date ;
