use FNFTraining

CREATE TABLE TestEmployee (
    Emp_Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary INT,
    Manager_Id INT
);

INSERT INTO TestEmployee (Emp_Id, Name, Salary, Manager_Id) VALUES
(1, 'Rohit', 20000, 3),
(2, 'Sangeeta', 12000, 5),
(3, 'Sanjay', 10000, 5),
(4, 'Arun', 25000, 3),
(5, 'Zaheer', 30000, NULL);

SELECT E.Name AS emp_Name, M.Name AS mgr_name
FROM TestEmployee E
LEFT JOIN TestEmployee M ON E.Manager_Id = M.Emp_Id
ORDER BY E.Name;



