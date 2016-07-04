SELECT FirstName, LastName, AddressText FROM Employees
INNER JOIN Addresses
ON Employees.AddressID=Addresses.AddressID