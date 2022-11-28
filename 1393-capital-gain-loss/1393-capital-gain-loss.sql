/* Write your T-SQL query statement below */
-- SELECT stock_name, SUM(CASE WHEN operation = 'Buy' THEN (-1*price) ELSE price END ) AS capital_gain_loss FROM Stocks GROUP BY stock_name ;

SELECT
    src.stock_name AS stock_name,
    SUM(src.price) AS capital_gain_loss
FROM
(SELECT s.stock_name AS stock_name,CASE WHEN s.operation = 'Buy' THEN -s.price ELSE s.price END AS price
    FROM Stocks AS s ) AS src GROUP BY src.stock_name;