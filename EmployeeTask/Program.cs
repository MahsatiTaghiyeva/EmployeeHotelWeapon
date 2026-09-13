Employee[] employees =
{
    new Employee(new DateTime(2000, 5, 10))
    {
        Name = "Ali",
        Surname = "Aliyev",
        Salary = 2500
    },

    new Employee(new DateTime(1998, 8, 20))
    {
        Name = "Leyla",
        Surname = "Hasanova",
        Salary = 1800
    },

    new Employee(new DateTime(2001, 3, 15))
    {
        Name = "Murad",
        Surname = "Mammadov",
        Salary = 3000
    },

    new Employee(new DateTime(1995, 12, 1))
    {
        Name = "Aysel",
        Surname = "Huseynova",
        Salary = 2500
    }
};

DateTime startDate = new DateTime(1999, 1, 1);
DateTime endDate = new DateTime(2002, 1, 1);

int count = 0;

foreach (var employee in employees)
{
    count += employee.CountSelectedEmployees(startDate, endDate, 2000);
}

Console.WriteLine($"Employees found: {count}");