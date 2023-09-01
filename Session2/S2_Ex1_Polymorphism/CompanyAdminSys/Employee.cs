namespace S2_Ex1_Polymorphism.CompanyAdminSys;

public abstract class Employee
{
    protected Employee(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public abstract double GetMonthlySalary();
}