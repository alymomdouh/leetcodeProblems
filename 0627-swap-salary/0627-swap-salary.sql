/* Write your T-SQL query statement below */
--update salary set sex = CHAR(ASCII('f') ^ ASCII('m') ^ ASCII(sex));
-- ather solution 
UPDATE salary SET sex=(CASE WHEN sex='m' THEN  'f' ELSE 'm' END)