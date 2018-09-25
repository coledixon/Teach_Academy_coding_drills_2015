SELECT city, MAX(grade)
FROM Students
GROUP BY city;