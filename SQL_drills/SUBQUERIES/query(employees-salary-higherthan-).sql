SELECT first_name, last_name   
FROM employees   
WHERE salary > ( SELECT salary    
                FROM employees   
                WHERE employee_id=163); 
