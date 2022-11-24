/* Write your T-SQL query statement below */
select v.customer_id,COUNT(*) as count_no_trans  from Visits v where v.visit_id not in(select visit_id  from Transactions) GROUP BY customer_id;