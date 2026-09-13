public class Employee
{
    public string Name {get; set;} = "";
    public string Surname {get; set;} = "";
    public DateTime Birthday {get; set;}
    public double Salary {get; set;}
    public int CountSelectedEmployees(DateTime startDate, DateTime endDate, double salary)
    {
        int count = 0;
        if(Birthday> startDate &&  Birthday < endDate && Salary > 2000)
            count++;
        return count;
    }
    public Employee(DateTime birthday)
    {
        Birthday = birthday;
    }
}