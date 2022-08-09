/* Write your T-SQL query statement below */
-- SELECT weather.id AS 'Id' FROM  weather JOIN weather w 
-- ON DATEDIFF(day,w.recordDate, weather.recordDate) = 1 AND weather.Temperature > w.Temperature;
---
SELECT DISTINCT a.Id
FROM Weather a,Weather b
WHERE a.Temperature > b.Temperature
AND DATEDIFF(day,b.Recorddate, a.Recorddate) = 1
