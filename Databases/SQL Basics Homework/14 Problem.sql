SELECT FirstName + ' ' + LastName as FullName, Salary
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)
ORDER BY Salary DESC