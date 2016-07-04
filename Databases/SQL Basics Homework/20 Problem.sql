select a.FirstName, a.LastName, e.FirstName + ' ' + e.LastName as ManagerName from Employees a
INNER JOIN Employees e
ON a.ManagerID=e.EmployeeID