/* Write your T-SQL query statement below */
/*
select product_id,'store1' as store, store1 as price 
from products 
where store1 is not null

union

select product_id,'store2' as store, store2 as price 
from products 
where store2 is not null

union

select product_id,'store3' as store, store3 as price 
from products 
where store3 is not null
*/
/*
select * from 
(
    select product_id, 'store1' store, store1 price from Products
    union 
    select product_id, 'store2' store, store2 price from Products
    union
    select product_id, 'store3' store, store3 price from Products
)t 
where price is not null;
*/
SELECT product_id,store,price
FROM Products
UNPIVOT
(
	price
	FOR store in (store1,store2,store3)
) AS StorePivot;
