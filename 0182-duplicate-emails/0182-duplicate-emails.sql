/* Write your T-SQL query statement below */

select Email from (select Email, count(Email) as num from Person group by Email)as x where num > 1 ;