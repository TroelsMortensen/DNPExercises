namespace S2_Ex1_Polymorphism.CompanyAdminSys;

public class Company
{
    private List<Employee> employees = new();


    public void HireNewEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public double GetMonthlySalaryTotal()
    {
        double sum = 0;
        foreach (Employee employee in employees)
        {
            sum += employee.GetMonthlySalary();
        }

        return sum;
    }

    public double GetMonthlySalaryTotalAlternative()
    {
        double sum = employees.Sum(employee => employee.GetMonthlySalary());
        return sum;
    }

    public void DisplayMostExpensiveEmployee()
    {
        Employee result = employees[0];
        foreach (Employee employee in employees)
        {
            if (employee.GetMonthlySalary() > result.GetMonthlySalary())
            {
                result = employee;
            }
        }

        Console.WriteLine(result.Name);
    }

    public void DisplayMostExpensiveEmployeeAlternative()
    {
        Employee result = employees
            .First(employee => employee.GetMonthlySalary() >= employees.Max(employee1 => employee1.GetMonthlySalary()));
        Console.WriteLine(result.Name);
    }
}