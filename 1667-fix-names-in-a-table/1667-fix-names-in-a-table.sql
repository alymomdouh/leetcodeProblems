/* Write your T-SQL query statement below */
-- select user_id, 
--     concat(upper(left(name,1)),lower(substring(name,2))) as name
-- from Users 
-- order by user_id

-- select user_id,
--        concat(upper(left(name, 1)), lower(right(name, length(name) - 1))) as name
-- from Users
-- group by 1
-- order by 1;

 select user_id,upper(substring(name,1,1)) 
    + lower(substring(name,2,9999999)) as name 
from Users
order by user_id
