/* Write your T-SQL query statement below */

SELECT u.name, SUM(amount) AS BALANCE FROM USERS u, TRANSACTIONS t WHERE u.account = t.account
  GROUP BY t.account,u.name HAVING SUM(amount) > 10000