SELECT MAX(purch_amt) AS MaxSalesPurchase
FROM orders
WHERE ord_date = '2012-08-17'
GROUP BY salesman_id;