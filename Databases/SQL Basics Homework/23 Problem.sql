Select e.FirstName + ' ' + e.LastName as Employee, m.FirstName + ' ' + m.LastName as Manager From Employees e
Left Outer Join Employees m 
On e.ManagerID=m.EmployeeID
