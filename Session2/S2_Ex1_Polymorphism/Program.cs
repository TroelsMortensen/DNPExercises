// See https://aka.ms/new-console-template for more information

using S2_Ex1_Polymorphism.CompanyAdminSys;

Console.WriteLine("Starting example...");

Company comp = new Company();
Employee emp1 = new FullTimeEmployee(1234, "Peter");
Employee emp2 = new FullTimeEmployee(4325, "Jens");
Employee emp3 = new PartTimeEmployee(100, 125, "Anna");
Employee emp4 = new PartTimeEmployee(45, 110, "Julius");
comp.HireNewEmployee(emp1);
comp.HireNewEmployee(emp2);
comp.HireNewEmployee(emp3);
comp.HireNewEmployee(emp4);
Console.WriteLine("Total expenses: "+ comp.GetMonthlySalaryTotal());
Console.WriteLine("Most expensive employee:");
comp.DisplayMostExpensiveEmployee();
