/* Write your T-SQL query statement below */
--select customer_number from orders group by customer_number 
--    having count(order_number)=(select max(c) from (select count(order_number) c from orders group by customer_number) t );


select top 1 customer_number from
 (select customer_number, count(order_number) order_count  from orders group by customer_number) a 
order by order_count desc  

