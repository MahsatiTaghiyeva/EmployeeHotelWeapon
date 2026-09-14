Employee employee1 = new Employee(new DateTime(2000, 5, 10))
{
    Name = "Ali",
    Surname = "Aliyev",
    Salary = 2500
};

Employee employee2 = new Employee(new DateTime(1998, 8, 20))
{
    Name = "Leyla",
    Surname = "Hasanova",
    Salary = 1800
};

Employee employee3 = new Employee(new DateTime(2002, 3, 15))
{
    Name = "Murad",
    Surname = "Mammadov",
    Salary = 3000
};

Employee[] employees = { employee1, employee2, employee3 };

int result = employee1.CountSelectedEmployees(
    employees,
    new DateTime(1999, 1, 1),
    new DateTime(2003, 1, 1),
    2000
);

Console.WriteLine(result);
