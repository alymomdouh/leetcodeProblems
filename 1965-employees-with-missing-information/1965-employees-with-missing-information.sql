/* Write your T-SQL query statement below */
select employee_id
from(
    select employee_id from Employees  
    union all select employee_id from Salaries
)  t
group by employee_id
having count(*)=1
order by 1
