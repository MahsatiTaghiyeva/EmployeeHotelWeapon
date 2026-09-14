public class Employee
{
        public string Name {get; set;} = "";
    public string Surname {get; set;} = "";
    public DateTime Birthday {get; set;}
    public double Salary {get; set;}
    public Employee(DateTime birthday)
    {
        Birthday = birthday;
    }
    public int CountSelectedEmployees(Employee[] employees, DateTime startDate, DateTime endDate, double salary = 2000)
    {        
        int count = 0;
        foreach(var employee in employees){
        if(employee.Birthday> startDate &&  employee.Birthday < endDate && employee.Salary > salary)
            count++;
        }
        return count;
    }
}