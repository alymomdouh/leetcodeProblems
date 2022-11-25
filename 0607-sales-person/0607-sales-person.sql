/* Write your T-SQL query statement below */
-- SELECT salesperson.name FROM salesperson WHERE 
-- salesperson.sales_id not in (
--  SELECT orders.sales_id FROM orders
--  Left JOIN company on orders.com_id = company.com_id
--         WHERE company.name = 'RED')
        
 --- other solution 
 select salesperson.name
from orders o join company c on (o.com_id = c.com_id and c.name = 'RED')
right join salesperson on salesperson.sales_id = o.sales_id
where o.sales_id is null;