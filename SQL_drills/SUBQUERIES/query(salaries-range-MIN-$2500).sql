SELECT *   
FROM employees   
WHERE salary BETWEEN    
(SELECT MIN(salary)   
FROM employees) AND 2500;