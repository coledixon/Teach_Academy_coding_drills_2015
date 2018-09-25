SELECT customer_id, MAX(purch_amt) AS MaxPurchase$
FROM orders
GROUP BY customer_id;