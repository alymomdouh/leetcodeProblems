/* Write your T-SQL query statement below */
-- SELECT user_id AS buyer_id, join_date, COALESCE(COUNT(o.order_id),0) AS orders_in_2019
-- FROM Users u LEFT JOIN Orders o ON u.user_id = o.buyer_id AND YEAR(order_date)='2019'
-- GROUP BY user_id ORDER BY user_id;

select user_id as buyer_id, join_date, 
count(order_id) as orders_in_2019
from Users u 
left join Orders o
on u.User_id = o.buyer_id
and  year(order_date) = '2019'
group by user_id,join_date
