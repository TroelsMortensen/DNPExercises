namespace S2_Ex1_Polymorphism.CompanyAdminSys;

public class PartTimeEmployee : Employee
{
    private int hoursPerMonth;
    private double hourlyWage;

    public PartTimeEmployee(int hoursPerMonth, double hourlyWage, string name) : base(name)
    {
        this.hourlyWage = hourlyWage;
        this.hoursPerMonth = hoursPerMonth;
    }

    public override double GetMonthlySalary()
    {
        return hourlyWage * hoursPerMonth;
    }
}