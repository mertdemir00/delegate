// See https://aka.ms/new-console-template for more information
using LambdaDelegateEventOrnek;

Console.WriteLine("Hello, World!");

int[] tumRakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
IEnumerable<int> tekRakamlar = (IEnumerable<int>)tumRakamlar.Where(x => x % 2 == 1);
foreach (int rakam in tekRakamlar)
    Console.WriteLine(rakam);

List<Employee> Employees = new List<Employee>
{
    new Employee{id = 1, Salary=1200, Name="Emre"},
    new Employee{id = 2, Salary=1100, Name="Ahmet"},
    new Employee{id = 3, Salary=2030, Name="Ali"},
    new Employee{id = 4, Salary=2010, Name="Hakan"},
};
var lambda = Employees.Where(i => i.Salary < 1750).OrderBy(i => i.Name);
foreach (var employee in lambda)
{
    Console.WriteLine(employee.ToString());
}

DelegateOrnek delegateOrnek = new DelegateOrnek();
delegateOrnek.Yazdir();