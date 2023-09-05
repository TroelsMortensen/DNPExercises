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
}