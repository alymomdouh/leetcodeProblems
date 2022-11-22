/* Write your T-SQL query statement below */
-- SELECT DISTINCT sell_date, COUNT(DISTINCT product) AS num_sold, 
--     GROUP_CONCAT(DISTINCT product ORDER BY product ASC SEPARATOR ',') AS products # aggregate the product names in one cell
-- FROM Activities 
-- GROUP BY sell_date
-- ;
-- select sell_date, count(distinct product) as num_sold, 
-- group_concat(distinct product order by product ASC separator ',') as products from Activities 
-- group by sell_date
-- SELECT sell_date,
-- 		COUNT(DISTINCT(product)) AS num_sold, 
-- 		GROUP_CONCAT(DISTINCT product ORDER BY product ASC SEPARATOR ',') AS products
-- FROM Activities
-- GROUP BY sell_date
-- ORDER BY sell_date ASC
-- select sell_date, count(distinct product) as num_sold , 
-- group_concat(distinct product order by product asc separator ',') as products               
-- from activities  
-- group by sell_date
-- order by sell_date
-- select 
-- 	sell_date, 
-- 	COUNT(product) num_sold,  
-- 	group_concat(product order by product) products 
-- from (SELECT DISTINCT * FROM Activities) Activities
-- group by sell_date
-- order by sell_date
-- select 
--     sell_date, COUNT(DISTINCT product) num_sold, 
--     group_concat(DISTINCT product) products 
-- from Activities
-- group by sell_date
-- order by sell_date

select 
    sell_date, COUNT(DISTINCT product) num_sold,
    substring(
        (
            select ','+  act1.product as [text()] 
            from (SELECT DISTINCT * FROM Activities) act1
            where act1.sell_date=act2.sell_date
            order by act1.product
            for xml path('')
        ),2,1000
    ) as products
from Activities act2
group by sell_date
order by sell_date 
  
 
-- Select
--      sell_date,
--       COUNT(DISTINCT product) num_sold, 
--     STUFF((
--           SELECT  ','+act1.product
--           from (SELECT DISTINCT * FROM Activities) act1
--           where act1.sell_date=act2.sell_date
--         order by act1.product
--           for xml path('')), 1, 1, '') as products 
-- from Activities act2
-- group by sell_date
--  order by sell_date 
