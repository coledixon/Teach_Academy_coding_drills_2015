SELECT e.department_id, e.first_name, e.job_id , d.department_name    
FROM employees e , departments d    
WHERE e.department_id = d.department_id    
AND  d.department_name = "Finance";