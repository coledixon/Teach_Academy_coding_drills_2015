SELECT CONCAT(first_name, +' '+ last_name) AS Name, salary, department_id, job_id
FROM employees
WHERE job_id = 
	(SELECT job_id 
	FROM employees 
	WHERE employee_id = 169);