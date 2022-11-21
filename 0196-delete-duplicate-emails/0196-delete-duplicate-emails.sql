/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
delete p1 from Person as p1 ,Person as p2 where p1.Email=p2.Email and p1.Id>p2.Id;
--select * from Person;