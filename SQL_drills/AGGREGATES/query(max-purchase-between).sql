SELECT customer_id, ord_date, MAX(purch_amt) AS MaxPurchase
FROM orders
GROUP BY customer_id, ord_date
HAVING MAX(purch_amt) BETWEEN 2000 AND 6000;