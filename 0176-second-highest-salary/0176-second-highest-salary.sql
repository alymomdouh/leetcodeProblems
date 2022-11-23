/* Write your T-SQL query statement below */
-- # Write your MySQL query statement below
--select IFNULL((select top 1 distinct(Salary)  from Employee order by Salary desc , 1), NULL) SecondHighestSalary;
 
 select max(Salary) as SecondHighestSalary from  Employee where Salary not in( select max(Salary) from Employee)
-- --## Write your MySQL query statement below
-- SELECT IFNULL(
-- (SELECT distinct Salary
-- FROM Employee
-- ORDER BY Salary desc limit 1,1)
-- , null) as SecondHighestSalary ;