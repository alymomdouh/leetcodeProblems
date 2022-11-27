/* Write your T-SQL query statement below */
select customer_number from orders 
    group by customer_number 
    having count(order_number) =
        (select max(c) from 
            (select count(order_number) c
            from orders 
            group by customer_number) t
        )
;