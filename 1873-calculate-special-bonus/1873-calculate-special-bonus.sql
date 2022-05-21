/* Write your T-SQL query statement below */
-- # Write your MySQL query statement below



 

SELECT employee_id  , CAST(
             CASE
                  WHEN employee_id % 2 = 0 or name like 'M%'
                     THEN 0
                  ELSE salary
             END as int ) as "Bonus"
FROM Employees