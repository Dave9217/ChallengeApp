

using ChallengeApp;

Employee employee1 = new Employee("Kamil", "Nowak", 25);
Employee employee2 = new Employee("Ania", "Kowalska", 28);
Employee employee3 = new Employee("Darek", "Zysk", 30);

employee1.Addscore(3);
employee1.Addscore(2);
employee1.Addscore(1);

employee2.Addscore(4);
employee2.Addscore(2);
employee2.Addscore(3);

employee3.Addscore(2);
employee3.Addscore(2);
employee3.Addscore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.maxResult > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.maxResult;
    }
}

Console.WriteLine("Pracownik z najwyzsza liczba punktow: " + employeeWithMaxResult.Name + " " +
    employeeWithMaxResult.Surname + " " + 
    employeeWithMaxResult.age + " " + " lat " + "z wynikiem" + " " + maxResult);
