Select e.FirstName + ' ' + e.LastName as FullName, e.HireDate, d.Name From Employees e
JOIN Departments d
On e.DepartmentID=d.DepartmentID
Where d.Name in('Sales', 'Finance') AND e.HireDate BETWEEN '1995/01/01' AND '2005/01/01'
