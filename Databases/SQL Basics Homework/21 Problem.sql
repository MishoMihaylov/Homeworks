SELECT e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName 
as Manager, AddressText 
FROM Employees e
INNER JOIN Employees m 
ON e.ManagerID=m.EmployeeID
INNER JOIN Addresses a
ON e.AddressID=a.AddressID